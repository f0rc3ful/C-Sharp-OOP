using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
            Gender = "Male";
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
