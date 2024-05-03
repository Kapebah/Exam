using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Exam_task_2
{
    class Content
    {
        public string Genre { get; set; }
        public Content() { }
        public Content(string genre) => Genre = genre;
        public void Show()
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine($"{Genre}");
            ResetColor();
        }
    }
}
