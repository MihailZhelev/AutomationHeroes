using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskTen
    {
        public void taskTen()
        {
            string inputedNumber = Console.ReadLine();
            
            
            if(inputedNumber.Length != 4 || inputedNumber.StartsWith("0"))
            {
                Console.WriteLine("Not a valid number");
                return;
            }


            int newInput = int.Parse(inputedNumber);
            int number4 = newInput % 10;
            newInput = newInput / 10;

            int number3 = newInput % 10;
            newInput = newInput / 10;

            int number2 = newInput % 10;
            newInput = newInput / 10;

            int sum = newInput + number2 + number3 + number4;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", number4,number3,number2,newInput);
            Console.WriteLine("{0}{1}{2}{3}", number4, newInput, number2,number3);
            Console.WriteLine("{0}{1}{2}{3}", newInput, number3,number2,number4);
            













        }
    }
}
