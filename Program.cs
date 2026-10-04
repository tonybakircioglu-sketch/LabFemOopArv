using System.Runtime.InteropServices;

namespace LabFemOopArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant("Mr Trump", 5, "Afrika", 440, "green food");
            elephant.Height = 340;

            Lion lion = new Lion("Leo", 2, "Afrika", 120, "Meat");
            lion.Speed = 30;

            Pig pig = new Pig("Nöff", 1, "America", 150, "Oats");
            pig.Smell = "Smells normal";

            DwarfPig dwarfPig = new DwarfPig("Nöff jr", 1, "China", 40, "Oats");
            dwarfPig.BaconYield = 3;

            WildPig wildPig = new WildPig("Nöffe", 2, "Sweden", 100, "Oats");
            wildPig.HamYield = 5;

            Console.WriteLine( "\nElephant info:");
            elephant.PrintInfo();
            elephant.makeSound();
            elephant.Danger();

            Console.WriteLine("\nLion info:");
            lion.PrintInfo();
            lion.IsFast();
            lion.makeSound();
            lion.Danger();
           

            Console.WriteLine("\nPig info:");
            pig.PrintInfo();
            pig.makeSound();
            pig.Eating();
            pig.SmellBad();

            Console.WriteLine("\nDwarfPig info:");
            dwarfPig.PrintInfo();
            dwarfPig.makeSound();
            dwarfPig.Eating();
            dwarfPig.Sleep();
            dwarfPig.GoodBaconYield();

            Console.WriteLine("\nWildPig info:");
            wildPig.PrintInfo();
            wildPig.makeSound();
            wildPig.Eating();
            wildPig.GoodHamYield();
        }
    }
}
