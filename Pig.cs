namespace LabFemOopArv
{
    internal class Pig : Animal
    {
        public override void PrintInfo()
        {
            base.PrintInfo();

            Console.WriteLine($"Smell: {Smell}");

        }
        public Pig(
            
            string name, 
            int age, 
            string origin, 
            int weight, 
            string feed)
: base(name, age, origin, weight, feed)
        {
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} squeals when frightened.");
        }
        public string Smell { get; set; } = "Unknown";
        public void SmellBad()
        {
            Console.WriteLine($"{Name} smells bad");
        }


    }

}
