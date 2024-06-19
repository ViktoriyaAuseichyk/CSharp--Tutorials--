using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;

namespace Lesson_4._4
{
    class Product
    {
        string name;
        double price;
        double count; 

        public Product(string name, double price, double count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public override string ToString()
        {
            return $"Name: {name}, Count: {count}, Price: {price}, FullPrice: {price * count}";
        }
    }

    internal class Program
    {
        static public void CreateInfoForCheque()
        {
            var product_1 = new Product("Potato", 2.58, 0.8);
            var product_2 = new Product("Salat", 5.08, 2);
            var product_3 = new Product("Carrot", 3.26, 0.6);
            var product_4 = new Product("Nut", 15.02, 1.2);
            var product_5 = new Product("Beef", 10.04, 1.8);

            var directory = new DirectoryInfo(@"D:\Vika\C# Professional\ДЗ\4. Работа с текстом. Регулярные выражения\Lesson_4.4");
            directory.CreateSubdirectory("InfoForCheque");
            var file = new FileInfo(directory.FullName + @"\InfoForCheque\Cheque.txt");
            var stream = file.Create();
            stream.Close();
            StreamWriter writer = file.CreateText();
            writer.WriteLine(product_1.ToString());
            writer.WriteLine(product_2.ToString());
            writer.WriteLine(product_3.ToString());
            writer.WriteLine(product_4.ToString());
            writer.WriteLine(product_5.ToString());
            writer.Close();

        }

        static public void ReadInfoForUSCulture(string path)
        {
            var american = new CultureInfo("en-US");

            StreamReader reader = new StreamReader(path);

            Console.WriteLine("Purchase cheque:");

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(reader.ReadToEnd());

            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Date: {DateTime.Now.ToString(american)}, {american}");
        }

        static public void ReadInfoForRUCulture(string path)
        {
            var russian = new CultureInfo("ru-Ru");

            StreamReader reader = new StreamReader(path);

            Console.WriteLine("Purchase cheque:");

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(reader.ReadToEnd());

            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Date: {DateTime.Now.ToString(russian)}, {russian}");
        }

        static void Main(string[] args)
        {
            CreateInfoForCheque();
            
            string path = @"D:\Vika\C# Professional\ДЗ\4. Работа с текстом. Регулярные выражения\Lesson_4.4\InfoForCheque\Cheque.txt";

            ReadInfoForUSCulture(path);

            Console.WriteLine(new string('-', 50));

            ReadInfoForRUCulture(path);

            Console.ReadKey();

        }
    }
}
