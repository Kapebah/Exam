using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Exam_task_1
{
    class Rectangle
    {
        /// <summary>
        /// Стороны прямоугольника
        /// </summary>
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        /// <summary>
        /// Конструкторы
        /// </summary>
        public Rectangle() { }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1; 
            Side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }
        /// <summary>
        /// Площадь
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator()
        {
            return Side1 * Side2;
        }
        /// <summary>
        /// Периметр
        /// </summary>
        /// <returns></returns>
        public double PerimeterCalculator()
        {
            return (Side1 + Side2) * 2;
        }
        /// <summary>
        /// Свойства площади и периметра
        /// </summary>
        public double Area { get; }
        public double Perimeter { get; }
        /// <summary>
        /// Ввод с клавиатуры
        /// </summary>
        /// <returns></returns>
        public static Rectangle Input()
        {
            Write("Введите первую сторону: ");
            double side1 = Convert.ToDouble(ReadLine());
            Write("Введите вторую сторону: ");
            double side2 = Convert.ToDouble(ReadLine());

            return new Rectangle(side1, side2);
        }
    }
}
