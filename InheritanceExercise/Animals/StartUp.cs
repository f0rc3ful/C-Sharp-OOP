using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        { 
            string animalType;
            while ((animalType = Console.ReadLine()) != "Beast")
            { 
                string[] animalInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (animalType == "Dog")
                    {
                        var dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                        Console.WriteLine(dog.GetType().Name);
                        Console.WriteLine(dog);
                        Console.WriteLine(dog.ProduceSound());
                    }
                    else if (animalType == "Frog")
                    {
                        var frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                        Console.WriteLine(frog.GetType().Name);
                        Console.WriteLine(frog);
                        Console.WriteLine(frog.ProduceSound());
                    }
                    else if (animalType == "Cat")
                    {
                        var cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                        Console.WriteLine(cat.GetType().Name);
                        Console.WriteLine(cat);
                        Console.WriteLine(cat.ProduceSound());
                    }
                    else if (animalType == "Kitten")
                    {
                        var kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));
                        Console.WriteLine(kitten.GetType().Name);
                        Console.WriteLine(kitten);
                        Console.WriteLine(kitten.ProduceSound());
                    }
                    else if (animalType == "Tomcat")
                    {
                        var tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));
                        Console.WriteLine(tomcat.GetType().Name);
                        Console.WriteLine(tomcat);
                        Console.WriteLine(tomcat.ProduceSound());
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

        }
        
        
    }
}
