using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public override double FuelConsumption 
        { 
            get => base.FuelConsumption; 
            set => base.FuelConsumption = 8; 
        }

        public RaceMotorcycle(int horsePower, int fuel) : base(horsePower, fuel)
        {

        }
    }
}
