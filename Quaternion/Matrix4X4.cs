using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Matrix4X4
    {
        public double[,] matrix = new double[4, 4];

        public double this[int i, int i2]
        {
            get { return matrix[i, i2]; }
            set { matrix[i, i2] = value; }
        }

        public Matrix4X4(double[,] matrix) {
            this.matrix = matrix;
        }

        public Matrix4X4() {
            this.matrix = new double[4, 4];
        }

        public static Matrix4X4 operator +(Matrix4X4 a, Matrix4X4 b) {
            var ret = new Matrix4X4();
            for (int i = 0; i < 4; i++) {
                for (int i2 = 0; i2 < 4; i++) {
                    ret[i, i2] = a[i, i2] + b[i, i2];
                }
            }

            return ret;
        }

        public static Matrix4X4 operator -(Matrix4X4 a, Matrix4X4 b) {
            var ret = new Matrix4X4();
            for (int i = 0; i < 4; i++) {
                for (int i2 = 0; i2 < 4; i2++) {
                    ret[i, i2] = a[i, i2] - b[i, i2];
                }
            }

            return ret;
        }

        public static Matrix4X4 operator *(Matrix4X4 a, Matrix4X4 b) {
            var ret = new Matrix4X4();
            for(int i = 0; i < 4; i++) {
                for (int i2 = 0; i2 < 4; i2++) {
                    var erg = 0d;
                    for(int i3 = 0; i3 < 4; i3++) {
                        erg += a[i, i3] * b[i3, i2];
                    }

                    ret[i, i2] = erg;
                }
            }

            return ret;
        }

        override public string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.matrix[0, 0] + "\t" + this.matrix[1, 0] + "\t" + this.matrix[2, 0] + "\t" + this.matrix[3, 0]);
            sb.AppendLine(this.matrix[0, 1] + "\t" + this.matrix[1, 1] + "\t" + this.matrix[2, 1] + "\t" + this.matrix[3, 1]);
            sb.AppendLine(this.matrix[0, 2] + "\t" + this.matrix[1, 2] + "\t" + this.matrix[2, 2] + "\t" + this.matrix[3, 2]);
            sb.AppendLine(this.matrix[0, 3] + "\t" + this.matrix[1, 3] + "\t" + this.matrix[2, 3] + "\t" + this.matrix[3, 3]);
            var output = sb.ToString();
            return output;
        }
    }
}