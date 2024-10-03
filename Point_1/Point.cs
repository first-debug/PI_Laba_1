namespace Point_1;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Point(Point pt)
    {
        X = pt.X;
        Y = pt.Y;
        Z = pt.Z;
    }
    public void MoveBy(double dx, double dy, double dz)
    {
        X += dx;
        Y += dy;
        Z += dz;
    }
    public override string ToString()
    {
        return $"{X}, {Y}";
    }
    public static void Main(string[] args)
    { }
}
