using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
		private const double coffeeMilliliters = 50;

		private const decimal coffeePrice = 3.5m;

		private double caffeine;

		public double Caffeine
		{
			get { return caffeine; }
			set { caffeine = value; }
		}
		public Coffee(string name, decimal price, double milliliters, double caffeine) : base(name, coffeePrice, coffeeMilliliters)
        {
			Caffeine = caffeine;
		}
	}
}
