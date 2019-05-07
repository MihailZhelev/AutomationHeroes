using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskEight
    {
        public void taskEight()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the number odd");
            if (!(number % 2 == 0))
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
