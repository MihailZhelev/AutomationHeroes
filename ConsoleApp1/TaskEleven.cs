using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskEleven
    {
        public void taskEleven()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(x * x + y * y);

            if (distance > 2)
            {
                Console.WriteLine(false);
            }
            else if(distance <= 2)
            {
                Console.WriteLine(true);
            }
        }
    }
}
