namespace User_2
{
    public class User
    {
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
        public string FIO
        {
            get => $"{Lastname} {Name} {Surname}";
            
            set
            {
                try
                {
                    string[] ls = value.Split(' ');
                    Lastname = ls[0];
                    Name = ls[1];
                    Surname = ls[2];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public User(string lastName, string name, string surName)
        {
            Lastname = lastName;
            Name = name;
            Surname = surName;
        }
    }
}