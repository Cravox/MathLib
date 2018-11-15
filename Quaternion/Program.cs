using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args) {
            var a = new Quaternion(1, 2, 3, 4);
            var b = new Quaternion(8, 7, 6 ,5);
            var c = new Quaternion(9, 11, 13, 10);
            
            var a1 = a + b + c;
            var a2 = c + b + a;
            var a3 = a*b/a;

            Console.WriteLine(a3.ToString());

            var v1 = new Vector3D(2, 2, 2);
            var v2 = new Vector3D(1, 2, 3);
            
            var v3 = Vector3D.Dot(v1, v2);
            Console.WriteLine(v3.ToString());
            
            var v4 = Vector3D.Cross(v1, v2);
            Console.WriteLine(v4.ToString());

            var m1 = new Matrix4X4();

            Console.WriteLine(m1.ToString());

            //Console.WriteLine("a)");
            //Console.WriteLine(a.ToString() + " + " + b.ToString() + " + " + c.ToString() + " = " + a1.ToString());
            //Console.WriteLine(c.ToString() + " + " + b.ToString() + " + " + a.ToString() + " = " + a1.ToString() + "\n");

            //Console.WriteLine("b)");
            //Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + (a * b).ToString());
            //Console.WriteLine(b.ToString() + " * " + a.ToString() + " = " + (b * a).ToString()+ "\n");

            //Console.WriteLine("c)");
            //Console.WriteLine("(" + a.ToString() + " * " + b.ToString() + ")" + " * " + c.ToString() + " = " + ((a + b) * c).ToString());
            //Console.WriteLine(a.ToString() + " * " + c.ToString() + " + " + b.ToString() + " * " + c.ToString() + " = " + (a * c + b * c).ToString()+ "\n");

            //Console.WriteLine("d)");
            //Console.WriteLine("(" + a.ToString() + " * " + b.ToString() + ")" + " * " + c.ToString() + " = " + ((a * b) * c).ToString());
            //Console.WriteLine(a.ToString() + " (" + b.ToString() + " * " + " * " + c.ToString() + ") = " + (a * (b * c)).ToString()+ "\n");

            //Console.WriteLine(q.ToString() + " - " + w.ToString() + " = " + s.ToString());
            //Console.WriteLine(q.ToString() + " * " + w.ToString() + " = " + m.ToString());

            Console.ReadLine();
        }
    }
}
