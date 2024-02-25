using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        private int age;
        public override int Age
        {
            get { return base.Age; }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Age cannot exceed 15 for children.");
                }
                base.Age = value;
            }
        }
        public Child(string name, int age) :base(name, age)
        {

        }
    }
}
