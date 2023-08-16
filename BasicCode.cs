using System;
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

            num1 = random.Next(10, 50);
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
        //Compute perimeter and area of a circle.
        //Take diameter of circle as user input,
        //Compute and print out perimeter and area of circle.
        public void CircleCalculation()
        {
            const double PI_VALUE = 3.14;
            //C=2πr perimeter
            //A=πr*r Area

            Console.WriteLine("Enter the diameter of circle");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double area, perimeter;
            perimeter = PI_VALUE* diameter;

            double radius = diameter/2;
            area = PI_VALUE*Math.Pow(radius, 2);
            Console.WriteLine("Perimeter of circle is {0} and area of circle is {1}", perimeter, area);

        }
        //Develop  a program to get next day of a given date. 
        //        Expected Output:
        //Input a year: 2020                                                     
        //Input a month[1-12]: 08                                                
        //Input a day[1-31]: 23                                                  
        //The next date is [yyyy-mm-dd] 2020-8-24 
        public void DayCalender()
        {
            int totalday, totalmonth = 12;
            //Console.Write("Input a year: ");
            int year = 2020;

            //Console.Write("Input a month [01-12]: ");
            int month = 08;

            //Console.Write("Input a day [1-31]: ");
            int day = 23;


            int nextYear = year;
            int nextMonth = month;
            int nextDay = day + 1;
            if (year % 4 == 0)
            {
                // Console.WriteLine("leap year");
                if (month == 02)
                {
                    totalday = 29;
                }
                else if (month == 01 ||month == 03|| month == 05 || month == 07||month == 08||month==10||month==12)
                {
                    totalday = 31;
                }
                else
                {
                    totalday=30;
                }
            }
            else
            {
                // Console.WriteLine("leap year");
                if (month == 02)
                {
                    totalday = 28;
                }
                else if (month == 01 ||month == 03|| month == 05 || month == 07||month == 08||month==10||month==12)
                {
                    totalday = 31;
                }
                else
                {
                    totalday=30;
                }
            }
            if (totalday < nextDay)
            {
                nextMonth++;
                nextDay = 1;
            }
            if (totalmonth < nextMonth)
            {
                nextYear++;
                nextMonth =1;
            }
            Console.WriteLine(nextYear+" "+nextMonth+" "+nextDay);


            // By using Datetime class
            //DateTime inputDate = new DateTime(year, month, day);
            //DateTime nextDay1 = inputDate.AddDays(1);

            //Console.WriteLine("Net day is :"+nextDay);

        }
        //Write a program which will find the execution time if the program.
        public void ExecutionTimeCalculate()
        {
            DateTime dateTime = DateTime.Now;
            //Variable for Start
            int starthour = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            // Start the program
            Console.WriteLine("Start the Program Yes or no");
            string startInput = Console.ReadLine().ToLower();
            if (startInput.Equals("yes"))
            {
                Console.WriteLine("Program Starting ..........");
                Console.WriteLine("End the program yes or no");
                //End the Program
                string endInput = Console.ReadLine().ToLower();
                if (endInput.Equals("yes"))
                {
                    DateTime dateTime1 = DateTime.Now;
                    int endhour = dateTime1.Hour;
                    int endMin = dateTime1.Minute;
                    int endSec = dateTime1.Second;
                    int endMilliSec = dateTime1.Millisecond;
                    //Calculate the elapsed time between start and end 
                    Console.WriteLine("Total Time is Requried the Run Program " +"\n hour :"+(endhour-starthour)+"\nMin :"
                       +(endMin-startMin)+"\n Second : "+(endSec-startSec)+"\n MilliSecond :"+(endMilliSec-startMilliSec));

                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        //"Write a program which will find all such numbers which are divisible by 7
        //but are not a multiple of 5, between 2000 and 3200 (both included).
        //The numbers obtained should be printed in a comma-separated sequence on a single line.

        public void NumberCalculation()
        {
          
            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                {
                    Console.Write(i+","); //single line.
                }
            }
        }
    }
}
