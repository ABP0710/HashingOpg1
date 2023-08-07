using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpg1
{
    internal class HMAC
    {
        //HAMC key length
        private const int keyLength = 32;


        //method to make the key
        public static byte[] GenerateKey()
        {
            var randomNumberGenerator = RandomNumberGenerator.Create();
            byte[] randomBytes = new byte[keyLength]; 
            randomNumberGenerator.GetBytes(randomBytes);

            return randomBytes;
        }


        public static byte[] ComputeHmacsha1(byte[] toBeHashed, byte[] key)
        {
            var hmac = new HMACSHA1(key);
            return hmac.ComputeHash(toBeHashed);
        }

        public static byte[] ComputeHmacsha256(byte[] toBeHashed, byte[] key)
        {
            var hmac = new HMACSHA256(key);
            return hmac.ComputeHash(toBeHashed);
        }

        public static byte[] ComputeHmacSha384(byte[] toBeHashed, byte[] key)
        {
            var hmac = new HMACSHA384(key);
            return hmac.ComputeHash(toBeHashed);
        }

        public static byte[] ComputeHmacsha512(byte[] toBeHashed, byte[] key)
        {
            var hmac = new HMACSHA512(key);
            return hmac.ComputeHash(toBeHashed);
        }

        public static byte[] ComputeHmacmd5(byte[] toBeHashed, byte[] key)
        {
            var hmac = new HMACMD5(key);
            return hmac.ComputeHash(toBeHashed);
        }
    }
}
