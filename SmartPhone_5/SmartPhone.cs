namespace SmartPhone_5
{
    public class SmartPhone : Laptop_4.Laptop
    {

        public string OS { get; set; }
        public override string Info
        {
            get => base.Info + ", OS: " + OS;
        }

        public SmartPhone(string model, int cpu_frequency, int ram, int drive_capacity, int weight, string os) :
            base(model, cpu_frequency, ram, drive_capacity, weight)
        {
            OS = os;
        }
    }
}