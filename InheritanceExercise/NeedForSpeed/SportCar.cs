using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private double fuelConsumption;

        public override double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = 10; }
        }

        public SportCar(int horsePower, int fuel) : base(horsePower, fuel)
        {

        }
    }
}
