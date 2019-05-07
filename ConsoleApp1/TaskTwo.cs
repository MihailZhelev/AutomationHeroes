using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskTwo
    {
        public void taskTwo()
        {
            string hello = "hello";
            string world = "world";
            object helloWorld = string.Concat(hello + " " + world);
            Console.WriteLine(helloWorld);

            string converted = (string)helloWorld;
            Console.WriteLine(converted);
        }
    }
}
