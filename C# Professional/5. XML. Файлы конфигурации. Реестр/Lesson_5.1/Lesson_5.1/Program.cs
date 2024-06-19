using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace Lesson_5._1
{
    internal class Program
    {
        static public void Space()
        {
            Console.WriteLine();

            Console.WriteLine(new string('-', 50));

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string path = "D:\\Vika\\C# Professional\\ДЗ\\5. XML. Файлы конфигурации. Реестр\\Lesson_5.1\\Lesson_5.1\\TelephoneBook.xml";
            
            var document = new XmlDocument();
            
            document.Load(path);
            
            Console.WriteLine(document.InnerText);
            
            Space();
           
            Console.WriteLine(document.InnerXml);

            Space();

            var newDocument = new XPathDocument(path);

            var navigator = newDocument.CreateNavigator();

            var compile = navigator.Compile("MyContacts/Contact/Name");
            
            var iterator = navigator.Select(compile);
            
            foreach ( var item in iterator) 
            {
                Console.WriteLine(item);
            }

            Space();

            var stream = new FileStream(path, FileMode.Open);

            var reader = new XmlTextReader(stream);

            string pattern = @"\+\(\w+\)(\s\w+)+";
            
            var regex = new Regex(pattern);
            
            while (reader.Read())
            {
                if (regex.IsMatch(reader.Value))
                {
                    Console.WriteLine(reader.Value);
                }
                else
                {
                    ;
                }

            }

            Console.ReadKey();
        }
    }
}
