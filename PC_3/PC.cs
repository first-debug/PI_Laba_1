namespace PC_3
{
    public class PC
    {
        public string Model { get; set; }
        /// <summary>
        /// Частота в МГц
        /// </summary>
        public int CPUFrequency { get; set; }
        /// <summary>
        /// Объём оперативной памяти в Гб
        /// </summary>
        public int RAM { get; set; }
        /// <summary>
        /// Объём жёсткого диска в Гб
        /// </summary>
        public int DriveCapacity { get; set; }
        public virtual string Info
        {
            get => $"Model: {Model}, CPU frequency: {CPUFrequency}, RAM: {RAM}, " +
            $"Hard Dreive Capacity: {DriveCapacity}";
        }
        public PC(string model, int cpu_frequency, int ram, int drive_capacity)
        {
            Model = model;
            CPUFrequency = cpu_frequency;
            RAM = ram;
            DriveCapacity = drive_capacity;
        }
    }
}