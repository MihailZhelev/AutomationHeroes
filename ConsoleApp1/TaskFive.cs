using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class TaskFive
    {
        public void taskFive()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your gender(m or f): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your ID: ");
            int ID = int.Parse(Console.ReadLine()); 
            Console.Write("Please enter your employee number: ");
            int eNumber = int.Parse(Console.ReadLine());

            Console.WriteLine( );
            Console.WriteLine("--------Employee personal information--------------");
            Console.WriteLine();
            Console.WriteLine("Employee full name: {0} {1}", firstName, lastName);
            Console.WriteLine("Employee age: {0}", age);
            Console.WriteLine("Employee gender: {0}", gender);
            Console.WriteLine("Employee ID: {0}", ID);
            if(eNumber >= 27560000 && eNumber <= 27569999)
            {
                Console.WriteLine("Employee number: {0}", eNumber);
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }
        }
    }
}
