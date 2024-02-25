﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
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
				age = value;
			}
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}
