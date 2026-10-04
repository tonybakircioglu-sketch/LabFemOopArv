namespace LabFemOopArv
{
    internal class DwarfPig : Pig
    {
        public DwarfPig(
            string name,
            int age,
            string origin, 
            int weight, 
            string feed)
        : base(name, age, origin, weight, feed)
        {
        }
        public int BaconYield { get; set; } = 0;
        public void GoodBaconYield()
        {
            if (BaconYield >= 5)  
            {
                Console.WriteLine($"Send {Name} to the slaughterhouse!");
            }
            else
            {
                Console.WriteLine($"{Name} can stay!");
            }
        }
    }
}
