using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack : Stack<string>
    {

        public bool IsEmpty() => Count == 0;
        public void AddRange(IEnumerable<string> input)
        {
            foreach (string element in input)
            {
                Push(element);
            }
        }
    }
}
