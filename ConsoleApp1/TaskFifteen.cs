using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskFifteen
    {
        public void taskFifteen()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The biggest number is: " + a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("The biggest number is: " + b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("The biggest number is: " + c);
            }
            else if (d > a && d > c && d > b && d > e)
            {
                Console.WriteLine("The biggest number is: " + d);
            }
            else if (e > a && e > c && e > d && e > b)
            {
                Console.WriteLine("The biggest number is: " + e);
            }
        }
    }
}
