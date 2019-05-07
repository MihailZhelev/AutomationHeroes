using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskFour
    {
        public void taskFour()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine("After the exchange");
            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a = " + a + " b = " + b);
        }
    }
}
