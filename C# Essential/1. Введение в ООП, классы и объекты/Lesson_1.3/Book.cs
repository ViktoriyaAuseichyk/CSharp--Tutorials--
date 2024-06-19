using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._3
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;
        private int color;

        public Book(Title title, Author author, Content content, int color)
        {
            this.title = title;
            this.author = author;
            this.content = content;
            this.color = color;
        }

        public Book(string title, string author, string content, int color)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
            this.color = color;
        }

        public void Show()
        {
            title.Show(color);
            author.Show(color);
            content.Show(color);
        }
    }
}
