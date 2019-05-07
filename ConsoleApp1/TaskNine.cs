using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskNine
    {
        public void taskNine()
        {
            Console.WriteLine("Type your weight");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on moon is:");
            Console.WriteLine(number * 0.17);
        }
    }
}
