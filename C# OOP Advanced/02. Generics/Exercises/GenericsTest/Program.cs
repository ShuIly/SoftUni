using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "c", "b", "a", "d"
            };

            list = GenericClass.GetOrderedCollection(list).ToList();
        }
    }
}
