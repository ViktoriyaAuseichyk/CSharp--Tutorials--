using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._1
{
    internal class Dictionary
    {
        private string[] ru = new string[5];
        private string[] eng = new string[5];
        private string[] pl = new string[5];


        public Dictionary()
        {
            ru[0] = "книга"; eng[0] = "book"; pl[0] = "książka";
            ru[1] = "ручка"; eng[1] = "pen"; pl[1] = "długopis";
            ru[2] = "солнце"; eng[2] = "sun"; pl[2] = "słońce";
            ru[3] = "яблоко"; eng[3] = "apple"; pl[3] = "jabłko";
            ru[4] = "стол"; eng[4] = "table"; pl[4] = "stół";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < ru.Length; i++)
                    if (ru[i] == index)
                        return ru[i] + " - " + eng[i] + " - " + pl[i];
                    else if (eng[i] == index)
                        return eng[i] + " - " + pl[i] + " - " + ru[i];
                    else if (pl[i] == index)
                        return pl[i] + " - " + ru[i] + " - " + eng[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < ru.Length)
                    return ru[index] + " - " + eng[index] + " - " + pl[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
