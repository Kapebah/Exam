using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_task_2
{
    class Title
    {
        public string Name { get; set; }
        public Title() { }
        public Title(string name) => Name = name;
        public void Show()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"{Name}");
            ResetColor();
        }
    }
}
