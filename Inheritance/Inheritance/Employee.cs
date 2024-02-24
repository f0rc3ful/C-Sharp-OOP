using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person
    {
        private float workExperience;

        public float WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public Employee() { }
        public Employee(int personalIDCode, string residence) : base(personalIDCode)
        {
            Residence = residence;
        }

        public Employee(int personalIDCode, string residence, string role, float workExp) : this(personalIDCode, residence)
        {
            Role = role;
            WorkExperience = workExp;
        }
    }
}
