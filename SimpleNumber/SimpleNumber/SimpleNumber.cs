using System;

namespace Lesson_1
{
    class SimpleNumber
    {
        static void Main(string[] args)
        {
            simple(1);
            simple(3);
            simple(6);
        }

        static void simple(int number)
        {
            int d = 0;
            int i = 2;

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
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
            
        }

       
    }

}
