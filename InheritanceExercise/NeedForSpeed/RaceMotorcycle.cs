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
            get { return 8; }
            set { }
        }
        public RaceMotorcycle(int horsePower, int fuel) : base(horsePower, fuel)
        {

        }
    }
}
