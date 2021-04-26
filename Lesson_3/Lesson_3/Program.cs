using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace Lesson_3
{
    class Program
    {
        private static int size = 500;
        static Random random = new Random();

        static PointClass pointClass;
        static PointStruct<float> pointStructFloat;
        static PointStruct<double> pointStructDouble;

        static PointClass[] ArrayPointClass = new PointClass[size];
        static PointStruct<float>[] ArrayPointStructFl = new PointStruct<float>[size];
        static PointStruct<double>[] ArrayPointStructDbl = new PointStruct<double>[size];

        public static void CreatArray()
        {
            for (int i = 0; i < ArrayPointClass.Length; i++)
            {
                pointClass = new PointClass
                {
                    X = random.Next(0, size),
                    Y = random.Next(0, size)
                };
                ArrayPointClass[i] = pointClass;
            }

            for (int i = 0; i < ArrayPointStructFl.Length; i++)
            {
                pointStructFloat = new PointStruct<float>
                {
                    X = (float)random.NextDouble() * size,
                    Y = (float)random.NextDouble() * size
                };
                ArrayPointStructFl[i] = pointStructFloat;
            }

            for (int i = 0; i < ArrayPointStructDbl.Length; i++)
            {
                pointStructDouble = new PointStruct<double>
                {
                    X = random.NextDouble() * size,
                    Y = random.NextDouble() * size
                };
                ArrayPointStructDbl[i] = pointStructDouble;
            }
        }
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
