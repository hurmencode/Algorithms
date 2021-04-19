using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Fibonacci
    {
        static int FibonacciRec(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonacciRec(n - 1) + FibonacciRec(n - 2);
            }
        }

        static int FibonacciCycle(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }

        public class TestCase
        {
            public int X { get; set; }
            public int Expected { get; set; }
            public Exception ExceptionExpected { get; set; }
        }

        static void FibTest (TestCase testCase)
        {
            try
            {
                var actual = FibonacciRec(testCase.X);
                var actualCycle = FibonacciCycle(testCase.X);
                if (actual == testCase.Expected || actualCycle == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExceptionExpected != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }

        static void Main(string[] args)
        {
            // правильный вариант
            var testCase = new TestCase()
            {
                X = 10,
                Expected = 55,
                ExceptionExpected = null
            };

            var testCase1 = new TestCase()
            {
                X = 10,
                Expected = 66,
                ExceptionExpected = null
            };
            FibTest(testCase);
            FibTest(testCase1);
        }
    }
}
