namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car(90, 100);
            car.Drive(100);
            System.Console.WriteLine(car);

            RaceMotorcycle bike = new RaceMotorcycle(100, 100);
            bike.Drive(100);
            System.Console.WriteLine(bike);

            SportCar lambo = new SportCar(420, 100);
            lambo.Drive(100);
            System.Console.WriteLine(lambo);
        }
    }
}
