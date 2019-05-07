using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskSeven
    {
        public void taskSeven()
        {
            double firstNum = int.Parse(Console.ReadLine());
            double secondNum = int.Parse(Console.ReadLine());
            double eps = 0.000001;

            double result = Math.Abs(firstNum - secondNum);

            if (result > eps)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
