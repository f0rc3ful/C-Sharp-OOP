using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList
    {
		private List<string> CustomList;

		public List<string> CustomList
		{
			get { return CustomList; }
			set { CustomList = value; }
		}
		public string RandomString()
		{
			Random random = new Random();
			int randomIndex = random.Next(CustomList.Count - 1);
			string output = CustomList[randomIndex];
			CustomList.RemoveAt(randomIndex);
			return output;
		}

	}
}
