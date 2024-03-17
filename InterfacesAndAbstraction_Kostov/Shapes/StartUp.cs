using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();

        }
    }
    public interface IDrawable
    {
        public void Draw()
        { 
        
        }
    }
    public class Circle : IDrawable
    {
        public void Draw()
        {
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;
            for (double y = this.radius; y >= -this.radius; --y)
            {
                for (double x = -this.radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine();
            }

        }
        private int radius;

        public int Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }
    }
    public class Rectangle : IDrawable
    {
        private int width;

        public int Width
        {
            get { return width; }
            private set { width = value; }
        }
        private int height;

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i < this.height - 1; ++i)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.WriteLine(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
