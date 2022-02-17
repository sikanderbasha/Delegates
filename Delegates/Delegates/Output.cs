using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
     class Output
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication  = " + (a * b));
        }
    }
}
