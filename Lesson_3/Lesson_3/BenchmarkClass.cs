using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    public class BenchmarkClass
    {
        public static float[] DistClass (PointClass[] pointClass , PointClass[] pointClass1)
        {
            float[] result = new float[1000];
            for (int i = 0; i < pointClass.Length; i++)
            {
                for (int j = pointClass1.Length; j <= 0; j--)
                {
                    float x = pointClass[i].X - pointClass1[j].X;
                    float y = pointClass[i].Y - pointClass1[j].Y;
                    result[j] = MathF.Sqrt((x * x) + (y * y));
                }
            }
            return result; 
        }

        public static float[] DistStructFl (PointStruct<float>[] pointStruct, PointStruct<float>[] pointStruct1)
        {
            float[] result = new float[1000];
            for (int i = 0; i < pointStruct.Length; i++)
            {
                for (int j = pointStruct1.Length; j <= 0; j--)
                {
                    float x = pointStruct[i].X - pointStruct1[j].X;
                    float y = pointStruct[i].Y - pointStruct1[j].Y;
                    result[j] = MathF.Sqrt((x * x) + (y * y));
                }
            }
            return result;
        }

        public static double[] DistStructDl(PointStruct<double>[] pointStruct, PointStruct<double>[] pointStruct1)
        {
            double[] result = new double[1000];
            for (int i = 0; i < pointStruct.Length; i++)
            {
                for (int j = pointStruct1.Length; j <= 0; j--)
                {
                    double x = pointStruct[i].X - pointStruct1[j].X;
                    double y = pointStruct[i].Y - pointStruct1[j].Y;
                    result[j] = MathF.Sqrt((float)((x * x) + (y * y)));
                }
            }
            return result;
        }

        public static float[] DistStructFlNoSqrt(PointStruct<float>[] pointStruct, PointStruct<float>[] pointStruct1)
        {
            float[] result = new float[1000];
            for (int i = 0; i < pointStruct.Length; i++)
            {
                for (int j = pointStruct1.Length; j <= 0; j--)
                {
                    float x = pointStruct[i].X - pointStruct1[j].X;
                    float y = pointStruct[i].Y - pointStruct1[j].Y;
                    result[j] = (x * x) + (y * y);
                }
            }
            return result;
        }
    }
}
