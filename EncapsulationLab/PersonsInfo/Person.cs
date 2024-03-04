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
		public Person(string first, string last, int age)
		{
			FirstName = first;
			LastName = last;
			Age = age;
		}
        public override string ToString()
        {
            return $"{firstName} {lastName} is {age} years old.";
        }
    }
}
