using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation x = new Equation { k = -15.2342, b = 23.3430 };
            x.Root();
            Console.ReadKey();
        }
        struct Equation
        {
            public double k, b;
            public void Root()
            {
                Console.WriteLine("0=kx+b\nk={0}, b = {1}\nx1 = {2:f7}", k, b, -b / k);
            }
        }
    }
}
