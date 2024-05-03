namespace Exam_task_3
{
    class Point
    {
        /// <summary>
        /// Поля
        /// </summary>
        string name;
        int x, y;

        /// <summary>
        /// Свойства
        /// </summary>
        public string Name { get { return name; } }
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point() { }
        public Point (string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}
