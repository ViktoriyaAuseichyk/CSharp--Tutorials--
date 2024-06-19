using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson_4._2
{
    // This programme allows you to use a given web page address 
    // to select all links to other pages, telephone numbers,
    // postal addresses and saves the results into text files.

    internal class Program
    {
        static string DownloadHTML(string url)
        {
            try
            {
                var client = new WebClient();
                client.Encoding = Encoding.UTF8;
                return client.DownloadString(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error happened during download: {0}.", ex.Message);
                return null;
            }
        }

        static FileInfo WriteContentInFile(string path, string content)
        {
            var file = new FileInfo($@"{path}\Contnent.txt");
            FileStream stream = file.Create();
            stream.Close();
            StreamWriter writer = file.CreateText();
            writer.WriteLine(content);
            writer.Close();
            return file;
        }

        class PartialComparer : IEqualityComparer<Match>
        {
            public bool Equals(Match x, Match y)
            {
                return x.Value == y.Value;
            }

            public int GetHashCode(Match obj)
            {
                return obj.Value.GetHashCode();
            }
        }
        static void GetPhoneNumbers(string path, FileInfo file)
        {
            var newfile = new FileInfo($@"{path}\PhoneNumbersInfo.txt");

            FileStream stream = newfile.Create();

            stream.Close();

            // +38 044 344 19 20
            string pattern = @"\+(([0-9]{2,3})\s?)+";

            StreamReader reader = file.OpenText();
            StreamWriter writer = newfile.CreateText();

            var regex = new Regex(pattern);

            var line = reader.ReadLine();

            while (line != null)
            {
                var matchResult = regex.IsMatch(line);

                if (matchResult == true)
                {
                    MatchCollection matched = regex.Matches(line);
                    var list = new List<Match>();

                    for (int i = 0; i < matched.Count; i++)
                    {
                        list.Add(matched[i]);
                    }

                    var result = list.Distinct(new PartialComparer()).ToList();

                    for (int i = 0; i < result.Count; i++)
                    {
                        writer.Write(result[i]);
                    }

                    writer.WriteLine();

                    line = reader.ReadLine();
                }
                else
                {
                    line = reader.ReadLine();
                }
            }

            reader.Close();
            writer.Close();
        }

        static void GetEmailAddresses(string path, FileInfo file)
        {
            var newfile = new FileInfo($@"{path}\EmailAddressesInfo.txt");

            FileStream stream = newfile.Create();

            stream.Close();

            // support@itvdn.com
            string pattern = @"[A-Za-z0-9._-]+\@[A-Za-z]+\.[A-Za-z]+";

            StreamReader reader = file.OpenText();
            StreamWriter writer = newfile.CreateText();

            var regex = new Regex(pattern);

            var line = reader.ReadLine();

            while (line != null)
            {
                var matchResult = regex.IsMatch(line);

                if (matchResult == true)
                {
                    MatchCollection matched = regex.Matches(line);
                    var list = new List<Match>();

                    for (int i = 0; i < matched.Count; i++)
                    {
                        list.Add(matched[i]);
                    }

                    var result = list.Distinct(new PartialComparer()).ToList();

                    for (int i = 0; i < result.Count; i++)
                    {
                        writer.Write(result[i]);
                    }

                    writer.WriteLine();

                    line = reader.ReadLine();
                }
                else
                {
                    line = reader.ReadLine();
                }
            }

            reader.Close();
            writer.Close();
        }

        static void GetLinks(string path, FileInfo file)
        {
            var newfile = new FileInfo($@"{path}\LinksInfo.txt");

            FileStream stream = newfile.Create();

            stream.Close();

            // https://join.skype.com/invite/fu6kCDCnLmEK
            string pattern = @"(http(s)?:)(\/+[\w.-]+)+";

            StreamReader reader = file.OpenText();
            StreamWriter writer = newfile.CreateText();

            var regex = new Regex(pattern);

            var line = reader.ReadLine();

            while (line != null)
            {
                var matchResult = regex.IsMatch(line);

                if (matchResult == true)
                {
                    MatchCollection matched = regex.Matches(line);
                    var list = new List<Match>();

                    for (int i = 0; i < matched.Count; i++)
                    {
                        list.Add(matched[i]);
                    }

                    var result = list.Distinct(new PartialComparer()).ToList();

                    for (int i = 0; i < result.Count; i++)
                    {
                        writer.Write(result[i]);
                    }

                    writer.WriteLine();

                    line = reader.ReadLine();
                }
                else
                {
                    line = reader.ReadLine();
                }
            }

            reader.Close();
            writer.Close();
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter the path to the folder where the data folder will later be created:");
            string PathOfDirectory = Console.ReadLine();
            var directory = new DirectoryInfo(PathOfDirectory);
            Console.WriteLine("Enter a name for the new folder:");
            string subDirictory = Console.ReadLine();
            directory.CreateSubdirectory(subDirictory);
            */
            string defaultPathOfDirectory = @"D:\Vika\C# Professional\ДЗ\4. Работа с текстом. Регулярные выражения\Lesson_4.2";
            var defaultDirectory = new DirectoryInfo(defaultPathOfDirectory);
            string defaultSubDirictory = "Data";
            defaultDirectory.CreateSubdirectory(defaultSubDirictory);

            /*Console.WriteLine("Enter the address of the web page:");
            string url = Console.ReadLine();*/

            string defaultULR = "https://itvdn.com/ru/support";

            // string htmlContent = DownloadHTML(url);

            string htmlContent = DownloadHTML(defaultULR);
            
            //string path = $@"{PathOfDirectory}\{subDirictory}";

            string defaultPath = $@"{defaultPathOfDirectory}\{defaultSubDirictory}";

            // var file = WriteContentInFile(path, htmlContent);

            var defaultFile = WriteContentInFile(defaultPath, htmlContent);

            /*
            if (htmlContent != null)
            {
                GetPhoneNumbers(path, file);
                GetEmailAddresses(path, file);
                GetLinks(path, file);
                Console.WriteLine("The results are saved in the files: PhoneNumbersInfo.txt, EmailAddressesInfo.txt and LinksInfo.txt");
            }
            else
            {
                Console.WriteLine("Unable to load HTML code of the site.");
            }
            */

            if (htmlContent != null)
            {
                GetPhoneNumbers(defaultPath, defaultFile);
                GetEmailAddresses(defaultPath, defaultFile);
                GetLinks(defaultPath, defaultFile);
                Console.WriteLine("The results are saved in the files: PhoneNumbersInfo.txt, EmailAddressesInfo.txt and LinksInfo.txt");
            }
            else
            {
                Console.WriteLine("Unable to load HTML code of the site.");
            }


            Console.ReadKey();
        }
    }
}

