using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
		private double coffeeMilliliters;

		public double CoffeeMilliliters
		{
			get { return coffeeMilliliters; }
			set { coffeeMilliliters = value; }
		}
		private decimal coffeePrice;

		public decimal CoffeePrice
		{
			get { return coffeePrice; }
			set { coffeePrice = value; } // setting a decimal value requres an 'm' after the numerical value
		}
		private double caffeine;

		public double Caffeine
		{
			get { return caffeine; }
			set { caffeine = value; }
		}
		public Coffee(string name, decimal price, double milliliters, double caffeine) : base(name, 3.5m, 50)
        {
			Caffeine = caffeine;
		}
	}
}
