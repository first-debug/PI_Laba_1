using Rectangle_6;

namespace Triangle_7
{
    class Triangle(Point p1, Point p2, Point p3)
    {
        public Point Point1 { get; set; } = p1;
        public Point Point2 { get; set; } = p2;
        public Point Point3 { get; set; } = p3;
        public string Info
        {
            get => $"point 1: {Point1}, point 2: {Point2}, point 3: {Point3}, " +
                    $"square = {GetSquare()}, perimeter = {GetPerimeter()}";

        }
        public static double GetLineLen(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(p1.X - p2.X), 2) +
                Math.Pow(Math.Abs(p1.Y - p2.Y), 2));
        }
        public double GetPerimeter()
        {
            return GetLineLen(Point1, Point2) + GetLineLen(Point2, Point3) + GetLineLen(Point3, Point1);
        }
        public double GetSquare()
        {
            double p = GetPerimeter() / 2.0D;
            return Math.Sqrt(p * (p - GetLineLen(Point1, Point2)) * (p - GetLineLen(Point2, Point3)) *
                (p - GetLineLen(Point3, Point1)));
        }
    }
}