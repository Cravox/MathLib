using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaternions
{
    class Quaternion
    {
        private double x, y, z, w;

        public Quaternion(double x, double y, double z, double w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static Quaternion operator+(Quaternion a, Quaternion b) {
            double x = a.x + b.x;
            double y = a.y + b.y;
            double z = a.z + b.z;
            double w = a.w + b.w;

            return new Quaternion(x, y, z, w);
        }

        public static Quaternion operator !(Quaternion a) {
            return new Quaternion(-a.x, -a.y, -a.z, -a.w);
        }

        public static Quaternion operator-(Quaternion a, Quaternion b) {
            return a + !b;
        }

        public static Quaternion operator*(Quaternion a, Quaternion b) {
            double x = (a.x* b.x) - (a.y* b.y) - (a.z* b.z) - (a.w* b.w);
            double y = (a.x* b.y) + (a.y* b.x) + (a.z* b.w) - (a.w* b.z);
            double z = (a.x* b.z) - (a.y* b.w) + (a.z* b.x) + (a.w* b.y);
            double w = (a.x* b.w) + (a.y* b.z) - (a.z* b.y) + (a.w* b.x);

            return new Quaternion(x, y, z, w);
        }

        public static Quaternion operator /(Quaternion a, Quaternion b) {
            double nenner = b.x*b.x + b.y*b.y + b.z*b.z + b.w*b.w;
            double x = ((a.x* b.x) + (a.y*b.y) + (a.z* b.z) + (a.w* b.w))/nenner;
            double y = (-(a.x* b.y) + (a.y*b.x) + (a.z* b.w) - (a.w* b.z))/nenner;
            double z = (-(a.x* b.z) - (a.y*b.w) + (a.z* b.x) + (a.w* b.y))/nenner;
            double w = (-(a.x* b.w) + (a.y*b.z) - (a.z* b.y) + (a.w* b.x))/nenner;

            return new Quaternion(x, y, z, w);
        }

        public string ToString() {
            return "("+ this.x + ", " + this.y + "i, " + this.z + "j, " + this.w + "k)";
        }
    }
}