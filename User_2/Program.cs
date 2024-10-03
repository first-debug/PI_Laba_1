using User_2;

class Program
{
    public static void Main(string[] args)
    {
        User user = new("Dimova", "Anastasi", "Dmitrievna");
        Console.WriteLine(user.FIO);
        user.FIO = "Lipop Moopo Auaau";
        Console.WriteLine(user.FIO);
    }
}