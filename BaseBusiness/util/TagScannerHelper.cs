using System;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using BaseBusiness.Utils;
using System.IO;
using System.Windows.Forms;
using BaseBusiness;
using Microsoft.Extensions.Configuration;
namespace BaseBusiness.util
{
    public sealed class TagScannerHelper
    {
        private static readonly Lazy<TagScannerHelper> _instance = new Lazy<TagScannerHelper>(() => new TagScannerHelper());
        public static TagScannerHelper Instance => _instance.Value;

        private readonly object _syncRoot = new object();
        private SerialPort _serialPort;
        private readonly StringBuilder _buffer = new StringBuilder();
        private int _clientCount = 0;

        public event Action<string> CodeReceived;

        public bool IsConnected => _serialPort != null && _serialPort.IsOpen;
        public string CurrentPortName { get; private set; }

        private TagScannerHelper() { }
        public  string Convert10To8TagNo(string s10TagNo)
        {
            string sTagNo = "";

            string sHexTagNo = Convert.ToInt64(s10TagNo).ToString("X");
            while (sHexTagNo.Length < 8)
            {
                sHexTagNo = "0" + sHexTagNo;
            }

            string FCode = sHexTagNo.Substring(2, 2);

            FCode = Int32.Parse(FCode, System.Globalization.NumberStyles.HexNumber).ToString();
            while (FCode.Length < 3)
            {
                FCode = "0" + FCode;
            }
            string LCode = sHexTagNo.Substring(4, 4);
            LCode = Int32.Parse(LCode, System.Globalization.NumberStyles.HexNumber).ToString();
            while (LCode.Length < 5)
            {
                LCode = "0" + LCode;
            }

            sTagNo = FCode + LCode;
            return sTagNo;
        }
        public bool Connect(string portName, int baudRate = 9600)
        {
            //if (string.IsNullOrWhiteSpace(portName))
            //{
            //    try
            //    {
            //        string iniPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.ini");
            //        if (!File.Exists(iniPath))
            //        {
            //            Console.WriteLine("COMPort key not found in appsettings.json. Please update the configuration.");
            //            return false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("COMPort key not found in settings.ini. Please update the configuratio Missing configuration");
            //            return false;
                  
            //        }
            //    }
            //    catch { }
            //    return false;
            //}

            lock (_syncRoot)
            {
                _clientCount = Math.Max(_clientCount, 0);
                if (IsConnected && string.Equals(CurrentPortName, portName, StringComparison.OrdinalIgnoreCase))
                {
                    _clientCount++;
                    return true;
                }

                try
                {
                    // Clean up any existing port
                    InternalCloseAndDispose();

                    // Close legacy global port if still open to avoid COM conflicts
                    try
                    {
                        if (Global.TagScannerPort != null && Global.TagScannerPort.IsOpen &&
                            string.Equals(Global.TagScannerPort.PortName, portName, StringComparison.OrdinalIgnoreCase))
                        {
                            Global.TagScannerPort.DataReceived -= null; // no-op safety
                            Global.TagScannerPort.Close();
                            Global.TagScannerPort.Dispose();
                            Global.TagScannerPort = null;
                            Global.TagCOMPortName = null;
                        }
                    }
                    catch { }

                    _serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One)
                    {
                        Handshake = Handshake.None,
                        ReadTimeout = 500,
                        WriteTimeout = 500
                    };
                    _serialPort.DataReceived += OnDataReceived;
                    _serialPort.Open();
                    CurrentPortName = portName;
                    _clientCount = 1;
                    return true;
                }
                catch (Exception ex)
                {
                    InternalCloseAndDispose();
                    try
                    {
                        Console.WriteLine($"Unable to connect to the device via port {portName}.\nReason: {ex.Message}");
                        return false;
                       
                    }
                    catch { }
                    return false;
                }
            }
        }

        /// <summary>
        /// Đọc cấu hình từ settings.ini và thử kết nối. Hiển thị thông báo nếu thiếu file/cấu hình hoặc kết nối thất bại.
        /// </summary>
        public bool ConnectFromSettings(IConfiguration configuration, int baudRate = 9600)
        {
            try
            {
                string comPort = configuration["COMPort"];

                if (string.IsNullOrWhiteSpace(comPort))
                {
                    Console.WriteLine("⚠ COMPort key not found in appsettings.json. Please update configuration.");
                    return false;
                }

                return Connect(comPort, baudRate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Unable to read COMPort setting. Reason: {ex.Message}");
                return false;
            }
        }

        public void Disconnect()
        {
            lock (_syncRoot)
            {
                if (_clientCount > 1)
                {
                    _clientCount--;
                    return;
                }
                InternalCloseAndDispose();
                _clientCount = 0;
            }
        }

        private void InternalCloseAndDispose()
        {
            try
            {
                if (_serialPort != null)
                {
                    _serialPort.DataReceived -= OnDataReceived;
                    if (_serialPort.IsOpen)
                    {
                        _serialPort.Close();
                    }
                    _serialPort.Dispose();
                }
            }
            catch { }
            finally
            {
                _serialPort = null;
                CurrentPortName = null;
                _buffer.Clear();
            }
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var sp = (SerialPort)sender;
                int bytesToRead = sp.BytesToRead;
                if (bytesToRead <= 0) return;

                byte[] readBuffer = new byte[bytesToRead];
                sp.Read(readBuffer, 0, bytesToRead);

                string rawData = Encoding.ASCII.GetString(readBuffer);
                _buffer.Append(rawData);

                string bufferStr = RemoveControlChars(_buffer.ToString());
                var matches = Regex.Matches(bufferStr, @"\d{10,}");
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        string cleaned = match.Value;
                        if (!string.IsNullOrWhiteSpace(cleaned) && cleaned.Length >= 10)
                        {
                            try { CodeReceived?.Invoke(cleaned); } catch { }
                        }
                    }

                    int lastMatchEnd = matches[matches.Count - 1].Index + matches[matches.Count - 1].Length;
                    string remaining = bufferStr.Substring(lastMatchEnd);
                    _buffer.Clear();
                    _buffer.Append(remaining);
                }
            }
            catch { }
        }

        private static string RemoveControlChars(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (c >= 32 || c == '\r' || c == '\n') sb.Append(c);
            }
            return sb.ToString();
        }
    }
}


