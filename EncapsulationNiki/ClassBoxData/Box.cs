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
			get 
			{ 
				return length; 
			}
			private set 
			{
					if (value <= 0)
					{
						throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
					}
					length = value;
			}
		}
		private double width;

		public double Width
		{
			get 
			{ 
				return width; 
			}
			private set 
			{
				if (value <= 0)
				{
					throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
				}
				width = value; 
			}
		}
		private double height;

		public double Height
		{
			get 
			{
				return height; 
			}
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
				}
				height = value; 
			}
		}


		public Box(double length, double width, double height)
		{
			try
			{
                this.Length = length;
            }
			catch (ArgumentException exception1)
			{
				Console.WriteLine(exception1.Message);
			}
			try
			{
				this.Width = width;
			}
			catch (ArgumentException exception2)
			{
				Console.WriteLine(exception2.Message);
			}
			try
			{
				this.Height = height;
			}
			catch (ArgumentException exception3)
			{
				Console.WriteLine(exception3.Message);
			}
        }
		public double SurfaceArea()
		{
			return 2 * (height * width + height * length + length * width);
		}
		public double LateralSurfaceArea()
		{
			return 2 * (length * height + width * height);
		}
		public double Volume()
		{
			return length * height * width;
		}
        public override string ToString()
        {
			return $"Surface Area - {SurfaceArea():F2}\nLateral Surface Area - {LateralSurfaceArea():F2}\nVolume - {Volume():F2}";
        }
    }
}
