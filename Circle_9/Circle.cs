using Rectangle_6;

namespace Circle_9;

class Circle(Point center, double radius)
{
    public Point Center { get; set; } = center;
    public double Radius { get; set; } = radius;

    public string Info
    {
        get => $"Center: {Center}, Radius: {Radius}, Len: {GetLen()}, Square: {GetSquare()}";
    }
    public Circle(int x, int y, double radius) : this(new(x, y), radius)
    { }
    public double GetLen()
    {
        return 2 * Radius * Math.PI;
    }
    public double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
// 9. Объект «Окружность», содержащая автоматические свойства 
// координат центра окружности и радиуса, методы вычисляющие длину 
// окружности и площадь, а также свойство, выводящая информацию об 
// окружности в виде строки. 
