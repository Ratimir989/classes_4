using System;

namespace classes_4
{
    class Point
    {
        private int x;
        private int y;
        private string pointName;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string PointName
        {
            get { return pointName; }
        }

        public Point() { }

        public Point(int x, int y, string c)
        {
            this.x = x;
            this.y = y;
            this.pointName = c;
        }
    }
    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;

        public Figure() { }

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }

        public void PerimeterCalculator()
        {
            if (E != null)
            {
                Console.WriteLine("Perimeter of pentagon = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A) + LengthSide(D, E) + LengthSide(E, A)));
            }
            else if (D != null)
            {
                Console.WriteLine("Perimeter of quadrilateral = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A)));
            }
            else
                Console.WriteLine("Perimeter of triangle = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "point1");
            Point B = new Point(1, 0, "point2");
            Point C = new Point(1, 1, "point3");
            Point D = new Point(0, 1, "point4");

            Figure figure = new Figure(A, B, C, D);

            figure.PerimeterCalculator();

            Console.ReadLine();
        }
    }
}
