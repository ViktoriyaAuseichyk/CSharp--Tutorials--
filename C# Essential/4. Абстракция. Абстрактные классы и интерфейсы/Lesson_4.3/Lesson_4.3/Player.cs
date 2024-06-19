using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    internal class Player : IPlayable, IRecodable
    {
        static public string ChoiceUser()
        {
            Console.WriteLine("Do you want to press the 'pause' or 'stop' button.");
            string choice = Console.ReadLine();
            Console.WriteLine();
            return choice;
        }

        void IPlayable.Play()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You have pushed the play button. The treck is plaing");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        void IPlayable.Pause() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You have pushed the pause button. The treck is paused");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        void IPlayable.Stop() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You have pushed the stop button. The treck stopped playing");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        void IRecodable.Record() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You have pushed the record button. The treck is being recorded");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        void IRecodable.Pause() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You have pushed the pause button. The treck recording is paused");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        void IRecodable.Stop() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You have pushed the stop button. The treck stopped recording");
            Console.ForegroundColor= ConsoleColor.Gray;
        }
    }
}
