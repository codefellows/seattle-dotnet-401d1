using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Source: http://www.c-sharpcorner.com/article/hashing-passwords-in-net-core-with-tips/
            Console.WriteLine("Hello World!");

            string[] passwords = { "Amanda", "P@SSW0RD", "password", "p@ssw0rd" };

            foreach (var password in passwords)
            {
                string salt = getSalt();
                Console.WriteLine($@"{{
                    'password': '{password}', 
                    'salt': '{salt}',
                    'hash': '{getHash(password + salt)}'
                     }}"
                );
            }

        }

        private static string getHash(string text)
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private static string getSalt()
        {
            byte[] bytes = new byte[128 / 8];
            using (var keyGenerator = RandomNumberGenerator.Create())
            {
                keyGenerator.GetBytes(bytes);

                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}
