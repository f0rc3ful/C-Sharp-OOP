using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        { 
            RandomList list = new RandomList();
            list.Add("Jason");
            list.Add("Cindy");
            list.Add("Melissa");
            Console.WriteLine(list.RandomString());
        }
    }
}
