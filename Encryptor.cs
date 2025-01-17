using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cosy
{
	public class Encryptor
	{
		private static readonly string signature = "COSY";
		private static readonly uint version = 1;
		private static readonly byte[] iv = new byte[16];
		private static Aes aes = Aes.Create();
		private static SHA256 sha = SHA256.Create();
		public static byte[] Encrypt(byte[] data, string key)
		{
			byte[] raw = Encoding.UTF8.GetBytes(key);
			aes.Key = sha.ComputeHash(raw);
			return aes.EncryptCfb(data, iv, PaddingMode.None);
		}
		public static byte[] Decrypt(byte[] data, string key)
		{
			byte[] raw = Encoding.UTF8.GetBytes(key);
			aes.Key = sha.ComputeHash(raw);
			return aes.DecryptCfb(data, iv, PaddingMode.None);
		}
		public static void Compile(string path, byte[] data, string key)
		{
			byte[] hash = sha.ComputeHash(data);
			FileStream stream = File.OpenWrite(path);
			stream.Position = 0;
			byte[] magic = Encoding.UTF8.GetBytes(signature);
			stream.Write(magic);
			byte[] ver = BitConverter.GetBytes(version);
			stream.Write(ver);
			byte[] encodedHash = Encrypt(hash, key);
			stream.Write(encodedHash);
			byte[] encodedData = Encrypt(data, key);
			stream.Write(encodedData);
			stream.Close();
		}
		public static byte[] Decompile(string path, string key)
		{
			FileStream stream = File.OpenRead(path);
			stream.Position = 0;
			byte[] raw = new byte[4];
			stream.ReadExactly(raw, 0, raw.Length);
			string magic = Encoding.UTF8.GetString(raw);
			if (magic == signature)
			{
				stream.ReadExactly(raw, 0, raw.Length);
				uint ver = BitConverter.ToUInt16(raw, 0);
				if (ver == version)
				{
					raw = new byte[32];
					stream.ReadExactly(raw, 0, raw.Length);
					MessageBox.Show(Convert.ToHexString(raw));
					byte[] temp = Decrypt(raw, key);
					string check = Convert.ToHexString(temp);
					raw = new byte[stream.Length - stream.Position];
					while (stream.Read(raw, 0, raw.Length) != 0) { }
					byte[] decrypted = Decrypt(raw, key);
					string hash = Convert.ToHexString(sha.ComputeHash(decrypted));
					if (check == hash)
					{
						stream.Close();
						return decrypted;
					}
					throw new("Invalid hash");
				}
				throw new("Invalid version");
			}
			throw new("Invalid file");
		}
	}
}