namespace Rectangle_6
{
    public class Point(int x, int y)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;

        public Point(Point point) : this(point.X, point.Y)
        { }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}