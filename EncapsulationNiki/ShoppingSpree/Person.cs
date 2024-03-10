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
					throw new ArgumentNullException("Name cannot be empty");
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
					throw new ArgumentException("Money cannot be negative");
				}
				money = value; 
			}
		}
		private List<Product> bag;
		public void AddProduct(Product product)
		{
			if (product.Cost > this.Money)
			{
				Console.WriteLine($"{nameof(Name)} can't afford {product.Name}");
			}
			bag.Add(product);
			this.Money -= product.Cost;
		}

		public Person(string name, int money)
		{
			this.Name = name;
			this.Money = money;
			this.bag = new List<Product>();
		}
	}
}
