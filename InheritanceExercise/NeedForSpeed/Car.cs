using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public override double FuelConsumption 
        { 
            get => base.FuelConsumption; 
            set => base.FuelConsumption = 3; 
        }
        public Car(int horsePower, int fuel) : base(horsePower, fuel)
        {

        }
    }
}
