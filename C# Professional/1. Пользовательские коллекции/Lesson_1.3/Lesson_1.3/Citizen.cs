using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._3
{
    internal class Citizen
    {
        public string type;

        public int ID
        {
            get; set;
        }

    }

    internal class Student : Citizen
    {
        public Student()
        {
            type = "Student";
        }
    }

    internal class Pensioner : Citizen
    {
        public Pensioner()
        {
            type = "Pensioner";
        }
    }

    internal class Worker : Citizen
    {
        public Worker()
        {
            type = "Worker";
        }
    }

    internal class Citizen_Queue
    {
        Citizen[] citizens;
        int count;
        public Citizen_Queue()
        {
            count = 0;
        }

        public void GrowQueue()
        {
            if (citizens == null)
            {
                citizens = new Citizen[2];
            }
            else if (citizens.Length == count)
            {
                Citizen[] tempArr = new Citizen[citizens.Length + 1];
                for (int i = 0; i < citizens.Length; i++)
                {
                    tempArr[i] = citizens[i];
                }
                citizens = tempArr;
            }
            else
            {
                ;
            }
        }

        public void AddCitizen(Citizen citizen)
        {
            GrowQueue();

            for (int l = 0; l < citizens.Length; l++)
            {
                if (citizens[l] == citizen)
                {
                    Console.WriteLine("There is such a citizen already in the queue...");
                }
                else
                {
                    ;
                }
            }

            if (citizen.type.Contains("Pensioner"))
            {
                for (int i = 0; i < citizens.Length; i++)
                {
                    if (citizens[i].type != citizen.type)
                    {

                        Citizen[] tempArr = new Citizen[citizens.Length + 1];
                        for (int j = 0, k = i; k < citizens.Length; j++, k++)
                        {
                            tempArr[j] = citizens[k];
                        }

                        citizens[i] = citizen;

                        for (int j = 0, k = ++i; k < citizens.Length; j++, k++)
                        {
                            citizens[k] = tempArr[j];
                        }
                        break;
                    }
                    else
                    {
                        ;
                    }
                }
            }
            else if (citizen.type.Contains("Student"))
            {
                citizens[count] = citizen;
            }
            else if (citizen.type.Contains("Worker"))
            {
                citizens[count] = citizen;
            }

            count++;
        }

        public IEnumerable<Citizen> ReturnLast()
        {
            yield return citizens[count - 1];
        }

        public bool Contains(Citizen citizen)
        {
            for (int i = 0; i < citizens.Length; i++)
            {
                if (citizens[i] == citizen)
                {
                    return true;
                }
                else
                {
                    ;
                }

            }
            return false;
        }

        public void RemoveCitizen()
        {
            for (int i = 0; i < citizens.Length; i++)
            {
                citizens[i] = citizens[i++];       
            }
            citizens[citizens.Length - 1] = null;
            count--;
        }
        public void Clear()
        {
            citizens = new Citizen[0];
            count = 0;
        }

        public IEnumerable<Citizen> GetCitizen_Queue()
        {
            for (int i = 0; i < citizens.Length; i++)
            { 
                yield return citizens[i];
            }
        }

        public void GetCount()
        {
            Console.WriteLine("Count: {0}", count);
        }
    }
}
