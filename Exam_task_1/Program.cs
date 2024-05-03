using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mark1:
            try
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("Задание №1\n");
                ResetColor();

                List<Rectangle> rectangles = new List<Rectangle>();
                bool flag = true;
                int count_1 = 1;
                int count_2 = 1;

                while (flag)
                {
                    WriteLine("1 - Создать прямоугольник" +
                    "\n2 - Высчитать периметр" +
                    "\n3 - Высчитать площадь");
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            Clear();
                            rectangles.Add(Rectangle.Input());
                            WriteLine();
                            break;
                        case ConsoleKey.D2:
                            Clear();
                            foreach (var rect in rectangles)
                            {
                                WriteLine($"Прямоугольник №{count_1++}");
                                WriteLine(rect.Perimeter);
                                WriteLine();
                            }
                            count_1 = 1;
                            break;
                        case ConsoleKey.D3:
                            Clear();
                            foreach (var rect in rectangles)
                            {
                                WriteLine($"Прямоугольник №{count_2++}");
                                WriteLine(rect.Area);
                                WriteLine();
                            }
                            count_2 = 1;
                            break;

                    }
                }
                
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
