using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
		private RandomList customList;

		public RandomList CustomList
		{
			get { return customList; }
			set { customList = value; }
		}
		private Random random = new Random();
        public string RandomString()
		{			
			return this[random.Next(0, this.Count)];
		}

	}
}
