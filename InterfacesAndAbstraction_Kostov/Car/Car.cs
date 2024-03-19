using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public abstract class Car
    {
        public string Model { get; protected set; }
        public string Color { get; protected set; }
        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public virtual void Start()
        {
            Console.WriteLine("Vroom vroom");
        }
        public abstract void Stop();
    }
}
