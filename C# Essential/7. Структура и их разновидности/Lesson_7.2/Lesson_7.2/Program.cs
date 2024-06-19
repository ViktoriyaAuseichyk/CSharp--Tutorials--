using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Train[] trains = new Train[8];

            train.Random = new Random();

            for (int i = 0; i < trains.Length; i++)
            {
                train.TrainNumberFill();
                train.ArrivalTimeFill();
                train.ArrivalStationFill();

                trains[i] = train;
            }

            train.SortArray(trains);

            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].ShowTrain();
            }

            Console.ReadKey();
        }
    }
}
