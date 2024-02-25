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
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than 0.");
                }
                else if (value > 15)
                {
                    throw new ArgumentException("Age cannot exceed 15 for children.");
                }
                age = value;
            }
        }
        public Child(string name, int age) :base(name, age)
        {

        }
    }
}
