using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla(string color)
            : base("S", color)
        {

        }
        public override void Start()
        {
            Console.WriteLine("Sss, sss...");
        }
        public override void Stop()
        {
            
        }
        public int Battery { get; set; }
        public override string ToString()
        {
            // TO DO
        }
    }
}
