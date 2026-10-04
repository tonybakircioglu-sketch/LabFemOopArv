namespace LabFemOopArv
{
    internal class WildPig : Pig
    {
        
        public WildPig(
            string name, 
            int age, 
            string origin, 
            int weight, 
            string feed)
        : base(name, age, origin, weight, feed)
        {
        }
        public int HamYield { get; set; } = 0;
        public void GoodHamYield()
        {
            if (HamYield >= 10)  
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
