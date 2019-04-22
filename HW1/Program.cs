using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = (12345) * 2;
            int myAge = 23;
            int ageAfter = myAge + 10;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Mihail Zhelev");
            Console.WriteLine(square);
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine("My age is " + myAge + ". After ten years I will be " + ageAfter + " years old");
            for (int i = 2; i <= 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(-i);
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
    }
}
