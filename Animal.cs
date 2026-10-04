namespace LabFemOopArv
{
    internal class Animal
    {
        //Shared properties 
        public string Name { get; set; } = "unknown"; 
        public int Age { get; set; } = 0;
        public string Origin { get; set; } = "unknown";
        public int Weight { get; set; } = 0;
        public string Feed { get; set; } = "unknown";

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}.");
            Console.WriteLine($"Age: {Age} years old.");
            Console.WriteLine($"Origin: {Origin}.");
            Console.WriteLine($"Weight: {Weight}kg.");
            Console.WriteLine($"{Name} eats: {Feed}.");
        } //this method prints info about the animal

        public Animal(string name, int age, string origin, int weight, string feed)
        {

            Name = name;
            Age = age;
            Origin = origin;
            Weight = weight;
            Feed = feed;
        } //constructor that sets properties

        public void Danger()
        {
            Console.WriteLine($"{Name} is dangerous! Handle with caution.");
        } 
        public void Eating()
        {
            Console.WriteLine($"{Name} is eating.");
        } //methods with fixed output
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        public virtual void makeSound()
        {
            Console.WriteLine($"{Name} is silent.");
        } //this method can be overridden

    }
}
