namespace LabFemOopArv
{
    internal class Elephant : Animal
    {
        public int Height { get; set; } = 0; // Unique property
        public void IsLong()
        {
            if (Height >= 3)
            {
                Console.WriteLine($"{Name} is long");
            }
            else
            {
                Console.WriteLine($"{Name} is not long");

            }
        } // Unique method
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Height: {Height}");

        } //adds "Height" to Printinfo
        public Elephant(
            string name,
            int age,
            string origin,
            int weight,
            string feed) //Sending values to the Animal constructor
: base(name, age, origin, weight, feed)
        {
        } 
        public override void makeSound()
        {
            Console.WriteLine($"{Name} make sound like trumpet");
        } // overrides defualt output with unique output for elephant class  
    }
}