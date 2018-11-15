using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Vector2D
    {
        public double x, y;
        public double magnitude { get { return Math.Sqrt((this.x * this.x) + (this.y * this.y)); } }

        public Vector2D(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public static Vector2D operator +(Vector2D a, Vector2D b) {
            var x = a.x + b.x;
            var y = a.y + b.y;

            return new Vector2D(x, y);
        }

        public static Vector2D operator -(Vector2D a, Vector2D b) {
            var x = a.x - b.x;
            var y = a.y - b.y;

            return new Vector2D(x, y);
        }

        public static Vector2D operator *(double r, Vector2D a) {
            var x = r * a.x;
            var y = r * a.y;

            return new Vector2D(x, y);
        }

        public double Dot(Vector2D a, Vector2D b) {
            return (a.x * b.x) + (a.y * b.y);
        }

        public static bool operator ==(Vector2D a, Vector2D b) {
            if (a.x == b.x && a.y == b.y) {
                return true;
            } else {
                return false;
            }
        }

        public static bool operator !=(Vector2D a, Vector2D b) {
            if (a.x != b.x && a.y != b.y) {
                return true;
            } else {
                return false;
            }
        }
    }
}
