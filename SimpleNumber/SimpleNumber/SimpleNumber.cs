using System;

namespace Lesson_1
{
    class SimpleNumber
    {
        static void Main(string[] args)
        {
            var testCase = new TestCase()
            {
                X = 1,
                Expected = true,
                ExceptionExpected = null
            };

            var testCase1 = new TestCase()
            {
                X = 10,
                Expected = true,
                ExceptionExpected = null
            };

            SimpleTest(testCase);
            SimpleTest(testCase1);
        }

        static bool simple(int number)
        {
            int d = 0;
            int i = 2;
            bool result = true;

            while (i < number)
            {
                if ((number % i) == 0)
                {
                    d++;
                }

                i++;
            }

            if (d == 0)
            {
                return result;
            }
            else
            {
                return result = false;
            }
            
        }

        public class TestCase
        {
            public int X { get; set; }
            public bool Expected { get; set; }
            public Exception ExceptionExpected { get; set; }
        }

        static void SimpleTest(TestCase testCase)
        {
            try
            {
                var actual = simple(testCase.X);
                if (actual == testCase.Expected)
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
    }

}
