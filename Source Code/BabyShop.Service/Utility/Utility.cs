using System.Text;
using System.Security.Cryptography;
using System.IO;
using System;
namespace BabyShop.Service.Utility
{
    public static class Utility
    {
        //private byte[] IV = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
        //private byte[] key = new byte[0];
        
        //public static string Encrypt(string queryStringuserId, string SEEncryptionKey)
        //{
        //    string str;
        //    try
        //    {
        //        this.key = Encoding.UTF8.GetBytes(SEEncryptionKey.Substring(0, 8));
        //        DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
        //        byte[] bytes = Encoding.UTF8.GetBytes(queryStringuserId);
        //        MemoryStream stream = new MemoryStream();
        //        CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(this.key, this.IV), CryptoStreamMode.Write);
        //        stream2.Write(bytes, 0, bytes.Length);
        //        stream2.FlushFinalBlock();
        //        str = Convert.ToBase64String(stream.ToArray());
        //    }
        //    catch (Exception exception)
        //    {
        //        throw exception;
        //    }
        //    return str;
        //}
        //public static string Decrypt(string stringToDecrypt, string SEEncryptionKey)
        //{
        //    string str;
        //    byte[] buffer = new byte[stringToDecrypt.Length];
        //    try
        //    {
        //        this.key = Encoding.UTF8.GetBytes(SEEncryptionKey.Substring(0, 8));
        //        DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
        //        buffer = Convert.FromBase64String(stringToDecrypt);
        //        MemoryStream stream = new MemoryStream();
        //        CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(this.key, this.IV), CryptoStreamMode.Write);
        //        stream2.Write(buffer, 0, buffer.Length);
        //        stream2.FlushFinalBlock();
        //        str = Encoding.UTF8.GetString(stream.ToArray());
        //    }
        //    catch (Exception exception)
        //    {
        //        throw exception;
        //    }
        //    return str;
        //}

        public static string NullToEmpty(this string value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            return value;
        }
    }
}