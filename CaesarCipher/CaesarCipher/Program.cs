using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        public static char x (char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key)-d) % 26) + d);
        }

        public static string E(string input, int key)
        {
            string output = string.Empty;

            foreach(char ch in input)
                output += x(ch, key);
                return output;
        }

        public static string D (string input, int key)
        {
            return E(input, 26 - key);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a message to encrypt:");
            string userIn = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Please enter a key to encrypt the message!");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("The encrypted data is:");
            string cT = E(userIn, key);
            Console.WriteLine(cT);
            Console.WriteLine("\n");

            Console.WriteLine("Please enter the key to decrypt");
            int nKey = Convert.ToInt32(Console.ReadLine());
            if(nKey != key)
            {
                Console.WriteLine("That is not the right key goodbye!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n");

                Console.WriteLine("Your decrypted message is:");
                string w = D(cT, key);
                Console.WriteLine(w);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
