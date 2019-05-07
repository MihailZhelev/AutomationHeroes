using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskSeventeen
    {
        public void taskSeventeen()
        {
            Console.WriteLine("Enter time in format: hh:mm AM/PM");
            string enteredTime = Console.ReadLine();
            DateTime time;
            DateTime.TryParseExact(enteredTime, "hh:mm tt", time);
            
            
            
        }
    }
}
