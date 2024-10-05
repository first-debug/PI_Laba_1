namespace Rectangle_6
{
    class Rectangre(Point leftUpPoint, Point rightDownPoint)
    {
        public Point Start { get; set; } = leftUpPoint;
        public Point End { get; set; } = rightDownPoint;
        public int Width { get; } = leftUpPoint.X - rightDownPoint.X;
        public int Height { get; } = leftUpPoint.Y - rightDownPoint.Y;
        public string Info
        {
            get => $"Left up point: {Start}, right down point: {End}, " +
                $"square = {GetSquare()}, perimeter = {GetPerimeter()}";
        }
        public Rectangre(int leftUpX, int leftUpY, int rightDownX, int rightDownY) :
         this(new(leftUpX, leftUpY), new(rightDownX, rightDownY))
        { }
        public int GetSquare()
        {
            return Width * Height;
        }
        public int GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}