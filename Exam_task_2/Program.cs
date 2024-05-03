using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mark1:
            try
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("Задание №2\n");
                ResetColor();

                Write("Введите название книги: ");
                string name = ReadLine();
                Title title1 = new Title(name);
                Write("Введите полное имя автора: ");
                string fullName = ReadLine();
                Author author = new Author(fullName);
                Write("Введите жанр: ");
                string genre = ReadLine();
                Content content = new Content(genre);
                WriteLine();

                Book book = new Book(title1, author, content);
                book.Show();
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
