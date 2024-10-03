using Point_1;

namespace BreakLine_10
{
    public class Line
    {
        public Point Start {  get; set; }
        public Point End {  get; set; }
        public Line(Point start, Point end) 
        {
            Start = start;
            End = end;  
        }
        public Line(Line oldLine)
        {
            Start = oldLine.Start; 
            End = oldLine.End;
        }
        public static double GetLen(Point p1, Point p2)
        {
            double difX = (p2.X - p1.X);
            double difY = (p2.Y - p1.Y);
            double lenghtXY = Math.Sqrt(difX * difX + difY * difY);
            double difZ = (p2.Z - p1.Z);
            return Math.Sqrt(lenghtXY * lenghtXY + difZ * difZ);
        }
        public double GetLenght()
        {
            double difX = (End.X - Start.X);
            double difY = (End.Y - Start.Y);
            double lenghtXY = Math.Sqrt(difX * difX + difY * difY);
            double difZ = (End.Z - Start.Z);
            return Math.Sqrt(lenghtXY * lenghtXY + difZ * difZ);
        }
        public double GetAngle()
        {
            return Math.Atan(Math.Abs(Start.Y - End.Y) / Math.Abs(Start.X + End.X));
        }
        public override string ToString()
        {
            return $"\tStart: {Start}\n\tEnd: {End}\n\tLenght: {GetLenght()}\n\tAngle: {GetAngle()}";
        } 
    }
}
