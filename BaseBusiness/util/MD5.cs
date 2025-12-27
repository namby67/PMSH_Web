using System;
using System.Security.Cryptography;
using System.Text;

namespace BaseBusiness.Util
{
	/// <summary>
	/// Summary description for MD5.
	/// </summary>
	public static class MD5
	{
        public static string passPhrase = "Pas5pr@se";        // can be any string
        public static string saltValue = "s@1tValue";        // can be any string
        public static string hashAlgorithm = "SHA1";             // can be "MD5"
        public static int passwordIterations = 2;                  // can be any number
        public static string initVector = "@CSS@CSS@CSS@CSS"; // must be 16 bytes
        public static int keySize = 256;

        public static string Hash(string toEncrypt) 
		{ 
			System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create (); 
			string encrypted = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(toEncrypt))).Replace("-", String.Empty).ToLower();
			encrypted = encrypted.Replace("+","tgtplus");
			encrypted = encrypted.Replace("&","tgtamper");
			encrypted = encrypted.Replace("?","tgtquestion");

			return encrypted; 
		}

        public static string MD5Hash(this string s)
        {
            using var provider = System.Security.Cryptography.MD5.Create();
            byte[] hashBytes = provider.ComputeHash(Encoding.UTF8.GetBytes(s));
            return Convert.ToBase64String(hashBytes);
        }

        public static string Encrypt(string plainText)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            passPhrase,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
                                                             keyBytes,
                                                             initVectorBytes);

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         encryptor,
                                                         CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);

            return cipherText;
        }
    }
}
