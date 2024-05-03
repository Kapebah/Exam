using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;


namespace Exam_task_2
{
    class Author
    {
        public string FullName { get; set; }
        public Author() { }
        public Author(string fullName) => FullName = fullName;
        public void Show()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine($"Автор: {FullName}");
            ResetColor();
        }
    }
}
