using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Exam_task_3
{
    class Figure
    {
        List<Point> points;
        public Figure() { }
        public Figure(Point point1, Point point2, Point point3) => this.points = new List<Point>() { point1, point2, point3 };
        public Figure(Point point1, Point point2, Point point3, Point point4) => this.points = new List<Point>() { point1, point2, point3, point4 };
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5) => this.points = new List<Point>() { point1, point2, point3, point4, point5 };
        public double LengthSide(Point point_1, Point point_2)
        {
            return Math.Sqrt(Math.Pow(point_2.X - point_1.X, 2) - Math.Pow(point_2.Y - point_1.Y, 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for(int i = 0; i < points.Count - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[0], points.Last());
            return perimeter;
        }
    }
}
