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
            get { return 3; }
            set { }
        }
        public Car(int horsePower, int fuel) : base(horsePower, fuel)
        {

        }
    }
}
