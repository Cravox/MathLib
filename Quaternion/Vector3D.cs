using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Vector3D
    {
        public double x, y, z;
        public double magnitude { get { return Math.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z)); } }

        public Vector3D(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D a, Vector3D b) {
            var x = a.x + b.x;
            var y = a.y + b.y;
            var z = a.z + b.z;

            return new Vector3D(x, y, z);
        }

        public static Vector3D operator -(Vector3D a, Vector3D b) {
            var x = a.x - b.x;
            var y = a.y - b.y;
            var z = a.z - b.z;

            return new Vector3D(x, y, z);
        }

        public static Vector3D operator *(double r, Vector3D a) {
            var x = r * a.x;
            var y = r * a.y;
            var z = r * a.z;

            return new Vector3D(x, y, z);
        }

        public static double Dot(Vector3D a, Vector3D b) {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }

        public static Vector3D Cross(Vector3D a, Vector3D b) {
            var x = (a.y * b.z) - (a.z * b.y);
            var y = (a.z * b.x) - (a.x * b.z);
            var z = (a.x * b.y) - (a.y * b.x);

            return new Vector3D(x, y, z);
        }

        public static bool operator ==(Vector3D a, Vector3D b) {
            if (a.x == b.x && a.y == b.y && a.z == b.z) {
                return true;
            } else {
                return false;
            }
        }

        public static bool operator !=(Vector3D a, Vector3D b) {
            if(a.x != b.x && a.y != b.y && a.z != b.z) {
                return true;
            } else {
                return false;
            }
        }

        public string ToString() {
            return "(" + this.x + ", " + this.y + ", " + this.z + ")";
        }
    }
}
