using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SahafUygulamasi.Utilities
{
	public static class Hasher
	{
		public static string Md5Hash(string mesaj)
		{
			MD5 mD5 = MD5.Create();  
			byte[] bytes = System.Text.UTF8Encoding.UTF8.GetBytes(mesaj);
			byte[] hashedData = mD5.ComputeHash(bytes);
			string strHashedData = "";
			foreach (byte b in hashedData)
			{
				strHashedData += b.ToString("x2"); 
			}
			return strHashedData;
		}
	}
}
