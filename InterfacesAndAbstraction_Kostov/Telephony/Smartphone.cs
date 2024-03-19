using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICaller
    {
        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
