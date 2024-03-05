using ClassBoxData;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        double height = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        Box box = new Box(length, width, height);
        if (!(height <= 0 || width <= 0 || length <= 0))
        {
            Console.WriteLine(box);
        }
    }
}