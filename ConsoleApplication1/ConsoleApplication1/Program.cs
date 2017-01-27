using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 235;
            var tmp = (1.618e-17) * (Math.Pow(x, 5)) - (4.64e-13) * (Math.Pow(x, 4)) + (0.000000004858) * (Math.Pow(x, 3)) - (0.00002263) * (Math.Pow(x, 2)) + (0.05) * (x) + 3.687;

            Console.WriteLine(tmp + x);
            Console.ReadKey();
        }
    }
}
