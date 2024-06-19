using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._2
{
    internal struct Train
    {
        double trainNumber;
        string arrivalTime;
        string arrivalStation;

        Random random;

        public Random Random 
        { 
            get
            {
                return random;
            }
            set
            {
                random = value; 
            } 
        }
        public void TrainNumberFill()
        {
           trainNumber = random.Next(100, 1000);
        }

        public void ArrivalTimeFill()
        {
            int hour = random.Next(1, 24);
            int second = random.Next(1, 60);
            arrivalTime = $"{hour} : {second}";

        }
        public string ArrivalStationFill()
        {
            int firstChar = random.Next(65, 90);
            int secondChar = random.Next(65, 90); 
            char firstCharResult = (Char)(firstChar);
            char secondCharResult = (Char)(secondChar);
            return arrivalStation = $"{firstCharResult}.{secondCharResult}";
        }

        public void ShowTrain()
        {
            Console.WriteLine($"Train Number: {trainNumber}, Arrival Time: {arrivalTime}, Arrival Station: {arrivalStation}");
        }

        public void SortArray(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
               for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].trainNumber < trains[j].trainNumber)
                    {
                        Train g = trains[i];
                        trains[i] = trains[j];
                        trains[j] = g;
                    }
                }
            }
            
        }
    }
}
