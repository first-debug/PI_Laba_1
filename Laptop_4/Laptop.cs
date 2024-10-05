namespace Laptop_4
{
    public class Laptop : PC_3.PC
    {
        /// <summary>
        /// Масса в Кг
        /// </summary>
        public int Weight { get; set; }
        public override string Info
        {
            get => base.Info + ", Weight: " + Weight;
        }
        public Laptop(string model, int cpu_frequency, int ram, int drive_capacity, int weight) :
            base(model, cpu_frequency, ram, drive_capacity)
        {
            Weight = weight;
        }
    }
}