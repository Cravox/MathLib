using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaternions
{
    class Program
    {
        static void Main(string[] args) {
            var q = new Quaternion(1, 2, 3, 4);
            var w = new Quaternion(5, 6, 7, 8);

            var h = q + w;
            var m = q * w;
            
            Console.WriteLine(q.ToString() + " + " + w.ToString() + " = " + h.ToString());
            Console.WriteLine(q.ToString() + " * " + w.ToString() + " = " + m.ToString());

            Console.ReadLine();
        }
    }
}
