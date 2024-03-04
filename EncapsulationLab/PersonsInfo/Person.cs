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
			get { return firstName; }
			set { firstName = value; }
		}
		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		private decimal salary;

		public decimal Salary
		{
			get { return salary; }
			set { salary = value; }
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
			if (this.Age < 30)
			{
				this.Salary += Salary * percentage / 100;
			}
			else
			{
                this.Salary += Salary * percentage / 200; // employees younger than 30 receive half the raise
            }
		}
        public override string ToString()
        {
            return $"{firstName} {lastName} receives {salary:F2} leva.";
        }
    }
}
