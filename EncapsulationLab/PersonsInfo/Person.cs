using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
		private string firstName;

		public string FirstName
		{
			get { return this.firstName; }
			private set 
			{
				if (value.Length < 3)
				{
					throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
				}
			}
		}
		private string lastName;

		public string LastName
		{
			get { return this.lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
		private int age;

		public int Age
		{
			get { return this.age; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
		private decimal salary;

		public decimal Salary
		{
			get { return this.salary; }
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
            }
        }

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Salary = salary;
		}
		public void IncreaseSalary(decimal percentage)
		{
			if (this.Age > 30)
			{
				this.Salary += this.Salary * percentage / 100; // employees over 30 years of age receive a full increase, younger employees receive 1/2 increase
			}
			else
			{
                this.Salary += this.Salary * percentage / 200; 
            }
		}
        public override string ToString()
        {
            return $"{firstName} {lastName} receives {salary:F2} leva.";
        }
    }
}
