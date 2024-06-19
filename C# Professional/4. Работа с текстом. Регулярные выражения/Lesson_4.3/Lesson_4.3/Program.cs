using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

namespace Lesson_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Encoding encoding = Encoding.UTF8;
            var file = new FileInfo(@"D:\Vika\C# Professional\ДЗ\4. Работа с текстом. Регулярные выражения\Lesson_4.3\Content.txt");
            var newFile = new FileInfo(@"D:\Vika\C# Professional\ДЗ\4. Работа с текстом. Регулярные выражения\Lesson_4.3\NewContent.txt");

            FileStream stream = newFile.Create();
            stream.Close();



            string pattern = @"[\s,.](([вВ])|([Бб]ез)|([Дд]о)|([Дд]ля)|([Зз]а)|([Чч]ерез)|([Нн]ад)|([Пп]о)|([Ии]з)|([Уу])|([Оо]коло)|([Пп]од)|([Оо])|([Пп]ро)|([Дд]о)|([Нн]а)|([Кк])|([Пп]еред)|([Пп]ри)|([Сс])|([Мм]ежду))[\s,.]";
            string newWord = " Гав! ";

            
            StreamReader reader = file.OpenText();
            StreamWriter writer = newFile.CreateText();

            var line = reader.ReadLine();
            Console.WriteLine(line);

            while (line != null)
            {
                writer.WriteLine(Regex.Replace(line, pattern, newWord));
                line = reader.ReadLine();
                Console.WriteLine(line);
            }

            reader.Close();
            writer.Close();

            Console.ReadKey();
        }
    }
}
