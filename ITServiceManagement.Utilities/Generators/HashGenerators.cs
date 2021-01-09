using System;
using System.Security.Cryptography;
using System.Text;

namespace ITServiceManagement.Utilities.Generators
{
    public static class HashGenerators
    {
        /// <summary>
        /// Get a password and hash it using MD5
        /// </summary>
        /// <param name="password"></param>
        /// <returns> Hash password </returns>
        public static string Md5EnCoding(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            var mainBytes = Encoding.Default.GetBytes(password);
            var encodeBytes = md5.ComputeHash(mainBytes);

            return BitConverter.ToString(encodeBytes);
        }
    }
}
