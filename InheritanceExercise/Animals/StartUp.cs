using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        { 
            string input;
            while ((input = Console.ReadLine()) != "Beast")
            { 
                string type = Console.ReadLine();
                string[] animalInfo = Console.ReadLine().Split(' ');
                CreateAnimal(type, animalInfo);
            }

        }
        public static void CreateAnimal(string type, string[] animalInfo)
        {
            if (type == "Dog")
            {
                new Dog();
            }
        }
        public static void PrintAnimalOutput()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}
