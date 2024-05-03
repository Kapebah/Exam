using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Exam_task_2
{
    class Book
    {
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }
        public Book() { }
        public Book(Title title, Author author, Content content) 
        {
            Title = title;
            Author = author;
            Content = content;
        }
        public void Show() 
        { 
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
}
