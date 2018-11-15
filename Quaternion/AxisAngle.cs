using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class AxisAngle
    {
        public static Matrix4X4 GetRotationMatrix(double angle, Vector3D vector) {
            var matrix = new double[4, 4];
            var cosa = Math.Cos(angle);
            var sina = Math.Sin(angle);

            matrix[0, 0] = (1-cosa) * Math.Pow(vector.x, 2) + cosa;
            matrix[1, 0] = (1-cosa) * (vector.x * vector.y) - vector.z*sina;
            matrix[2, 0] = (1-cosa) * (vector.x * vector.z) + vector.y*sina;
            matrix[3, 0] = 0;

            matrix[0, 1] = (1-cosa) * (vector.x * vector.y) + vector.z * sina;
            matrix[1, 1] = (1-cosa) * Math.Pow(vector.y, 2) + cosa;
            matrix[2, 1] = (1-cosa) * (vector.y * vector.z) - (vector.x * sina);
            matrix[3, 1] = 0;

            matrix[0, 2] = (1-cosa) * (vector.x * vector.z) - (vector.y * sina);
            matrix[1, 2] = (1-cosa) * (vector.y * vector.z) + (vector.x * sina);
            matrix[2, 2] = (1-cosa) * Math.Pow(vector.z, 2) + cosa;
            matrix[3, 2] = 0;

            matrix[0, 3] = 0;
            matrix[1, 3] = 0;
            matrix[2, 3] = 0;
            matrix[3, 3] = 1;

            return new Matrix4X4(matrix);
        }
    }
}
