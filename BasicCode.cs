﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramCode
{
    public class BasicCode
    {
        //Compute Average of numbers.
        //Generate 5 random numbers between 10 to 50  and compute the average of these numbers
        //. Print the numbers generated in one line and in next line print the average.
        public void AverageOfNumber()
        {
            int num1, num2, num3, num4, num5, avg;
            Random random = new Random();
           
             num1 = random.Next(10,50);
            Console.WriteLine("Number 1 :"+num1);
             num2 = random.Next(10, 50);
            Console.WriteLine("Number 1 :"+num2);
             num3 = random.Next(10, 50);
            Console.WriteLine("Number 1 :"+num3);
             num4 = random.Next(10, 50);
            Console.WriteLine("Number 1 :"+num4);
             num5 = random.Next(10, 50);
            Console.WriteLine("Number 1 :"+num5);

             avg = (num1+ num2+num3+ num4+num5)/5;
            Console.WriteLine("Average of Five random Number is :"+avg);
        }
    }
}
