﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2_NEW
{
    internal class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine($"{fileName} открыт");
        }

        public void Create()
        {
            Console.WriteLine($"{fileName} создан");
        }

        public void Change()
        {
            Console.WriteLine($"{fileName} отредактирован");
        }

        public virtual void Save()
        {

        }

    }
}
