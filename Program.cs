using System.Text;

namespace HashingOpg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv det der skal hashes");

            string tekst = Console.ReadLine();
            string tekst2 = tekst;
            string tekst3 = tekst2 + "x";

            var key = HMAC.GenerateKey(); 

            var tHmacMd5 = HMAC.ComputeHmacmd5(Encoding.UTF8.GetBytes(tekst), key);
            var t2HmacMd5 = HMAC.ComputeHmacmd5(Encoding.UTF8.GetBytes(tekst2), key);
            var t3HmacMd5 = HMAC.ComputeHmacmd5(Encoding.UTF8.GetBytes(tekst3), key);

            var tHmacSha1 = HMAC.ComputeHmacsha1(Encoding.UTF8.GetBytes(tekst), key);
            var t2HmacSha1 = HMAC.ComputeHmacsha1(Encoding.UTF8.GetBytes(tekst2), key);
            var t3HmacSha1 = HMAC.ComputeHmacsha1(Encoding.UTF8.GetBytes(tekst3), key);

            var tHmacSha256 = HMAC.ComputeHmacsha256(Encoding.UTF8.GetBytes(tekst), key);
            var t2HmacSha256 = HMAC.ComputeHmacsha256(Encoding.UTF8.GetBytes(tekst2), key);
            var t3HmacSha256 = HMAC.ComputeHmacsha256(Encoding.UTF8.GetBytes(tekst3), key);

            var tHmacSha384 = HMAC.ComputeHmacSha384(Encoding.UTF8.GetBytes(tekst), key);
            var t2HmacSha384 = HMAC.ComputeHmacSha384(Encoding.UTF8.GetBytes(tekst2), key);
            var t3HmacSha384 = HMAC.ComputeHmacSha384(Encoding.UTF8.GetBytes(tekst3), key);

            var tHmacSha512 = HMAC.ComputeHmacsha512(Encoding.UTF8.GetBytes(tekst),key);
            var t2HmacSha512 = HMAC.ComputeHmacsha512(Encoding.UTF8.GetBytes(tekst2), key);
            var t3HmacSha512 = HMAC.ComputeHmacsha512(Encoding.UTF8.GetBytes(tekst3), key);


            Console.WriteLine("HMAC");
            Console.WriteLine("Nøgle = " + BitConverter.ToString(key) );
            Console.WriteLine();
            Console.WriteLine("MD5");
            Console.WriteLine("teskt 1 hash = " + Convert.ToBase64String(tHmacMd5));
            Console.WriteLine("teskt 2 hash = " + Convert.ToBase64String(t2HmacMd5));
            Console.WriteLine("teskt 3 hash = " + Convert.ToBase64String(t3HmacMd5));
            Console.WriteLine();
            Console.WriteLine("Sha1");
            Console.WriteLine("teskt 1 hash = " + Convert.ToBase64String(tHmacSha1));
            Console.WriteLine("teskt 2 hash = " + Convert.ToBase64String(t2HmacSha1));
            Console.WriteLine("teskt 3 hash = " + Convert.ToBase64String(t3HmacSha1));
            Console.WriteLine();
            Console.WriteLine("Sha256");
            Console.WriteLine("teskt 1 hash = " + Convert.ToBase64String(tHmacSha256));
            Console.WriteLine("teskt 2 hash = " + Convert.ToBase64String(t2HmacSha256));
            Console.WriteLine("teskt 3 hash = " + Convert.ToBase64String(t3HmacSha256));
            Console.WriteLine();
            Console.WriteLine("Sha384");
            Console.WriteLine("teskt 1 hash = " + Convert.ToBase64String(tHmacSha384));
            Console.WriteLine("teskt 2 hash = " + Convert.ToBase64String(t2HmacSha384));
            Console.WriteLine("teskt 3 hash = " + Convert.ToBase64String(t3HmacSha384));
            Console.WriteLine();
            Console.WriteLine("Sha512");
            Console.WriteLine("teskt 1 hash = " + Convert.ToBase64String(tHmacSha512));
            Console.WriteLine("teskt 2 hash = " + Convert.ToBase64String(t2HmacSha512));
            Console.WriteLine("teskt 3 hash = " + Convert.ToBase64String(t3HmacSha512));

        }
    }
}