using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Food : Product
    {
        private double grams;

        public double Grams
        {
            get { return grams; }
            set { grams = value; }
        }
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
    }
}
