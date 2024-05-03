using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Exam_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mark1:
            try
            {
                Figure figure1 = new Figure(new Point("A", 2, 4), new Point("B", 3, 5), new Point("C", 4, 6));
                WriteLine(figure1.PerimeterCalculator());
                Figure figure2 = new Figure(new Point("A", 2, 4), new Point("B", 3, 5), new Point("C", 4, 6), new Point("D", 5, 7));
                WriteLine(figure2.PerimeterCalculator());
                Figure figure3 = new Figure(new Point("A", 2, 4), new Point("B", 3, 5), new Point("C", 4, 6), new Point ("D", 5, 7), new Point("E", 6, 8));
                WriteLine(figure3.PerimeterCalculator());
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");

                WriteLine("\nНажмите Enter для продолжения. . .");
                if (ReadKey(true).Key == ConsoleKey.Enter)
                {
                    goto mark1;
                }
            }
            ReadKey();
        }
    }
}
