using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_12._1
{
    public class Presenter
    {
        private Model model;
        private View view;

        //public Presenter(View view)
        public Presenter()
        {
            model = new Model();   
            //this.view = view;
            View.TextAdd += View_TextAdd; 
        }

        void View_TextAdd(string str)
        {
            Console.WriteLine(model.Logic(str));
        }
    }
}