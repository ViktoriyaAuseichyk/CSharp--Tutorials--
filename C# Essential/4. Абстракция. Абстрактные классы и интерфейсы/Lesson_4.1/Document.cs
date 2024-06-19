using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    internal class Document
    {
        AbstractBaseClass title;
        AbstractBaseClass body;
        AbstractBaseClass footer;

        void InitilizeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }
        public Document(string title)
        {
            InitilizeDocument();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }
    }
}

