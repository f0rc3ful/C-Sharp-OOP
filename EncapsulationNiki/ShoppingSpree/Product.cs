using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Product
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
		private int cost;

		public int Cost
		{
			get { return cost; }
			set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}
				cost = value; 
			}
		}
		public Product(string name, int cost)
		{
			this.Name = name;
			this.Cost = cost;
		}
	}
}
