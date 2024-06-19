using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lesson_3._3
{
    internal class Program
    {
        public void FindFile()
        {

        }
        static void Main(string[] args)
        {
            string pathForTXT = "D:\\Vika\\C# Professional\\ДЗ\\3. Программирование ввода-вывода С#\\Lesson_3.3\\Test\\Test.txt";

            FileStream source = File.OpenRead(pathForTXT);

            StreamReader reader = new StreamReader(source);

            Console.WriteLine(reader.ReadToEnd());

            reader.Close();
            source.Close();

            source = File.OpenRead(pathForTXT);

            string pathForZIP = "D:\\Vika\\C# Professional\\ДЗ\\3. Программирование ввода-вывода С#\\Lesson_3.3\\Test\\Test.zip";

            FileStream destination = File.Create(pathForZIP);
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            int bt = source.ReadByte();

            while (bt != -1)
            {
                compressor.WriteByte((byte)bt);
                bt = source.ReadByte();
            }

            compressor.Close();
            source.Close();

            source = File.OpenRead(pathForZIP);

            string pathForNewTXT = "D:\\Vika\\C# Professional\\ДЗ\\3. Программирование ввода-вывода С#\\Lesson_3.3\\Test\\NewTest.txt";

            destination = File.Create(pathForNewTXT);
            GZipStream decompressor = new GZipStream(source, CompressionMode.Decompress);

            bt = decompressor.ReadByte();

            while (bt != -1)
            {
                destination.WriteByte((byte)bt);
                bt = decompressor.ReadByte();
            }

            decompressor.Close();
            source.Close();

            Console.ReadKey();

        }
    }
}
