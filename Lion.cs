namespace LabFemOopArv
{
    internal class Lion : Animal
    {
        public int Speed { get; set; } = 0;
        public void IsFast()
        {
            if (Speed >= 10)
            {
                Console.WriteLine($"{Name} is fast");
            }
            else
            {
                Console.WriteLine($"{Name} is not fast");

            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();


            Console.WriteLine($"Speed: {Speed}km/h");

        }
        public Lion(
            
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
            Console.WriteLine($"{Name} roars.");
        }
        


    }
}
