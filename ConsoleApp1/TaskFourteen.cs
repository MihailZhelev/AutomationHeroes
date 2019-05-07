using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskFourteen
    {
        public void taskFourteen()
        {
            Console.WriteLine("Type playing card sign");
            string sign = Console.ReadLine();

            if (sign == "2" || sign == "3" || sign == "4" || sign == "5" || sign == "6" ||
                sign == "7" || sign == "8" || sign == "9" || sign == "10" ||
                sign == "J" || sign == "Q" || sign == "K" || sign == "A")
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
