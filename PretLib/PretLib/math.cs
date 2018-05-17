using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace PretLib
{
    public class Matrix
    {
        public uint nRow;
        public uint nColumn;
    }

    public static class Math 
    {
        public static Random ranGenerator;

        public static float NormalRandom(float u, float delta, int seed = 0)
        {
            return PretLib.Math.NorMalRandomPoint(u, delta, 0f, 0f, seed).X;
        }

        public static PointF NorMalRandomPoint(float u, float delta, float v, float gamma, int seed = 0)
        {
            if (ranGenerator == null)
            {
                PretLib.Math.ranGenerator = new Random(seed);
            }

            delta = System.Math.Abs(delta);
            gamma = System.Math.Abs(gamma);

            double x = PretLib.Math.ranGenerator.NextDouble();
            double y = PretLib.Math.ranGenerator.NextDouble();



            float z0 = (float)(System.Math.Sqrt(-2 * System.Math.Log(x)) * System.Math.Cos(2 * System.Math.PI * y));
            float z1 = (float)(System.Math.Sqrt(-2 * System.Math.Log(x)) * System.Math.Sin(2 * System.Math.PI * y));

            z0 = z0 * delta + u;
            z1 = z1 * gamma + v;

            return new PointF(z0, z1);
        }
    }
}
