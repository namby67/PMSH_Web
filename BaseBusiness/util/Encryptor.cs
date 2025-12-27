using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BaseBusiness.util
{
	/// <summary>
	/// Summary description for Encryptor.
	/// </summary>
	public class Encryptor
	{
		public static string Hash(string toEncrypt)
		{
			System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
			string encrypted = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(toEncrypt))).Replace("-", String.Empty).ToLower();
			return encrypted;
		}
	}
}