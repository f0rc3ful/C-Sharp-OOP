namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar lambo = new SportCar(420, 100);
            lambo.Drive(500);
            System.Console.WriteLine(lambo);
        }
    }
}
