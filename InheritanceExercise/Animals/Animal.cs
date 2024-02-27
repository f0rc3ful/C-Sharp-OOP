using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
		private string name;

		public string Name
		{
			get { return name; }
			set 
			{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid input!");
                }
                name = value; 
			}
		}

		private int age;
		public int Age
		{
			get { return age; }
			set 
			{
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid input!");
                }
                age = value; 
			}
		}

        private string gender;
        public string Gender
        {
            get { return gender; }
            set 
			{
				if (string.IsNullOrEmpty(value))
				{ 
					throw new ArgumentNullException("Invalid input!");
				}
				gender = value; 
			}
        }
		public Animal(string name, int age, string gender)
		{
			Name = name;
			Age = age;
			Gender = gender;
		}
    }
}
