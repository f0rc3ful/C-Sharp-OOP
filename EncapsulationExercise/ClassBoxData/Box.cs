using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
		private double length;

		public double Length
		{
			get { return length; }
		}
		private double width;

		public double Width
		{
			get { return width; }
		}
		private double height;

		public double Height
		{
			get { return height; }
		}
		public Box(double length, double width, double height)
		{
			try
			{
				if (length <= 0)
				{
					throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
				}
				else if (height <= 0)
				{
					throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
				}
				else if (width <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.length = length;
                this.width = width;
                this.height = height;
            }
			catch (ArgumentException exception)
			{
				Console.WriteLine(exception.Message);
			}
		}
		public double SurfaceArea()
		{
			return 2 * (height * width + height * length + width * length);
		}
        public double LateralSurfaceArea()
        {
            return 2 * (height * width + height * length);
        }
		public double Volume()
		{
			return height * width * length;
		}
        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea():F2}\nLateral Surface Area - {LateralSurfaceArea():F2}\nVolume - {Volume():F2}";
        }
    }
}
