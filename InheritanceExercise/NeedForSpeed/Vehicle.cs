using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
		private int horsePower;

		public int HorsePower
		{
			get { return horsePower; }
			set { horsePower = value; }
		}
		private double fuel;

		public double Fuel
		{
			get { return fuel; }
			set { fuel = value; }
		}
		private double defaultFuelConsumption;

		public double DefaultFuelConsumption
		{
			get { return defaultFuelConsumption; }
			set { defaultFuelConsumption = 1.25; }
		}
		private double fuelConsumption;

		public virtual double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = DefaultFuelConsumption; }
		}
		public Vehicle(int horsePower, double fuel)
		{
			HorsePower = horsePower;
			Fuel = fuel;
		}
		public virtual void Drive(double kilometers)
		{
			fuel -= kilometers * defaultFuelConsumption;
		}
        public override string ToString()
        {
            return $"The {this.GetType().Name} with {horsePower} HP has {fuel}l of fuel left!";
        }
    }
}
