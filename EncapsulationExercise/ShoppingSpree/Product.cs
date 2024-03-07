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
			set { name = value; }
		}
		private int cost;

		public int Cost
		{
			get { return cost; }
			set 
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException($"Money cannot be negative");
                    }
                    cost = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
		}

	}
}
