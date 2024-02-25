namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Lizard lizard = new Lizard("Lizzo");
            System.Console.WriteLine($"Lizard's name: {lizard.Name}");
            Bear beer = new Bear("beer");
            System.Console.WriteLine($"Bear's name: {beer.Name}");
        }
    }
}