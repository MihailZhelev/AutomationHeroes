using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskThirteen
    {
        public void taskThirteen()
        {
            Console.WriteLine("Type a score between 1 and 9");
            int score = int.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                Console.WriteLine(score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine(score * 1000);
            }
            else if (score == 0 || score > 9)
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}
