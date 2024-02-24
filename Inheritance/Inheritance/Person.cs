using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		private string residence;

		public string Residence
		{
			get { return residence; }
			set { residence = value; }
		}
		private string nationality;

		public string Nationality
		{
			get { return nationality; }
			set { nationality = value; }
		}
		private int personalIDCode;

		public int PersonalIDCode
		{
			get { return personalIDCode; }
			set { personalIDCode = value; }
		}
		public Person() { }
		public Person(int personalIDcode)
		{
			PersonalIDCode = personalIDcode;
		}
		public Person(int personalIDcode, string residence) : this(personalIDcode) // constructor chaining
		{
			Residence = residence;	
		}

		public Person(int personalIDcode, string residence, string nationality, int age) : this(personalIDcode, residence)
		{
			Nationality = nationality;
			Age = age;
		}
        // further consntructor chaining
    }
}
