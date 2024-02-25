using System;
namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Lizard lizard = new Lizard("Lizzo");
            Console.WriteLine($"Lizard's name: {lizard.Name}");
            Bear beer = new Bear("beer");
            Console.WriteLine($"Bear's name: {beer.Name}");
        }
    }
}