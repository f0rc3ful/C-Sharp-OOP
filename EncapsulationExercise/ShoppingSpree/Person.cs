using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
		private string name;

		public string Name
		{
			get { return name; }
			set 
			{
					if (string.IsNullOrEmpty(value))
					{
						throw new ArgumentException($"Name cannot be empty");
					}
					name = value;
			}
		}
		private int money;

		public int Money
		{
			get { return money; }
			set 
			{
					if (value < 0)
					{
						throw new ArgumentException($"Money cannot be negative");
					}
			}
		}
		private List<Product> products;

		public List<Product> Products
		{
			set
			{
                this.products = new List<Products>();
            }
		}

	}
}
