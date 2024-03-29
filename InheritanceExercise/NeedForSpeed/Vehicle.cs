﻿using System;
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
			set { defaultFuelConsumption = value; }
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
			DefaultFuelConsumption = 1.25;
		}
		public virtual void Drive(double kilometers)
		{
			fuel -= (kilometers / 100) * FuelConsumption;
		}
    }
}
