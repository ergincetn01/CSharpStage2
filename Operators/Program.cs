using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            int l = 45;
            int f = l + 74;
            double d = 12.6;
            int dd = (int)d;


            int h = 4 + dd;
            Console.WriteLine(f / 5);
            Console.WriteLine(h);
            Console.WriteLine(dd);
            Console.WriteLine(d);

            object m = f % 5;
            Console.WriteLine("f modulus 5: {0}", m);
            Console.ReadLine();

        }
    }
}
