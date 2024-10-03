using Point_1;
namespace BreakLine_10;

class BreakLine
{
    public List<Point> points = [];
    public long CountPoints
    {
        get { return points.Count; }
    }
    public long CountLines
    {
        get { return CountPoints != 0 ? CountPoints - 1 : 0; }
    }
    public BreakLine()
    { }
    public BreakLine(List<Point> points)
    { this.points = new(points); }  
    public void Add(Point point)
    {
        points.Add(point);
    }
    public void Add(Point[] points)
    {
        foreach (Point p in points)
            this.points.Add(p);
    }
    public void ShowLines()
    {
        for (int i = 1; i < points.Count; i++)
             Console.WriteLine($"Line {i}: {new Line(points[i - 1], points[i])}\n");
    } 
    /// <summary>
    /// Возвращает длину ломанной
    /// </summary>
    public double GetLenght()
    {
        double res = 0;
        for (int i = 1; i < points.Count; i++)
            res += Line.GetLen(points[i - 1], points[i]);
        return res;
    }
    public static void Main(string[] args)
    {
        Line line = new(new Point(0, 0, 0), new Point(1, 1, 1));
        Console.WriteLine(line.GetAngle());
    }
}


