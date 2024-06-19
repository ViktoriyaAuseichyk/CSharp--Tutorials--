using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любую большую букву английского алфавита: ");
            string letter = Console.ReadLine();
            char character = Convert.ToChar(letter);
            int key = 216; 
            char encrypted_character = (char)(character ^ key);
            char decrypted_character = (char)(encrypted_character ^ key);
            Console.WriteLine($"Зашифрованный символ: {encrypted_character}");
            Console.WriteLine($"Разшифрованный символ: {decrypted_character}");
            Console.ReadKey();
        }
    }
}
