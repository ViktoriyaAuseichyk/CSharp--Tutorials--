using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Label_1:
            Console.WriteLine("What do you want to do..to 'listen' or to 'record' a treck?");
            string choice_1 = Console.ReadLine();

            Console.WriteLine();

            var player = new Player();
            string choice_2;

            switch (choice_1)
            {
                case "listen":
                    {
                        IPlayable button = player;
                        button.Play();

                        do
                        {
                            Console.WriteLine();

                            choice_2 = Player.ChoiceUser();

                            switch (choice_2)
                            {
                                case "pause":
                                    {
                                        button.Pause();
                                        break;
                                    }
                                case "stop":
                                    {
                                        button.Stop();
                                        break;
                                    }
                                default :
                                    {
                                        Console.WriteLine("This button was not found. Try again");
                                        break;
                                    }
                            }
                        }
                        while (choice_2 != "stop");

                        break;
                    }

                case "record":
                    {
                        IRecodable button = player;
                        button.Record();

                        do
                        {
                            Console.WriteLine() ;

                            choice_2 = Player.ChoiceUser();

                            switch (choice_2)
                            {
                                case "pause":
                                    {
                                        button.Pause();
                                        break;
                                    }
                                case "stop":
                                    {
                                        button.Stop();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("This button was not found. Try again");
                                        break;
                                    }
                            }
                        }
                        while (choice_2 != "stop");

                        break;
                    }
                default:
                    {
                        Console.WriteLine("This function was not found. Try again");
                        Console.WriteLine();
                        goto Label_1;
                    }
            }

            // Приведение экземпляров к нужному типу
            /*Player player = new Player();
            // Это... 
            player.Play(); 
            (player as IPlayable).Stop();
            // Тоже самое, что это 
            IPlayable player_1 = player as IPlayable;
            player_1.Stop();

            player.Record();
            (player as IRecodable).Stop();*/

            Console.ReadKey();
        }
    }
}
