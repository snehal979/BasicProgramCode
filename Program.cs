namespace BasicProgramCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Program Code");

            Console.WriteLine("Basic Program");
            Program program = new Program();
            BasicCode basicCode = new BasicCode();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choice a number");
                Console.WriteLine("hint:1.Display My Frd List \n" +
                    "2:Two Number Sum And Differ Square Root \n 3:Display Place Name As Upper Or Lower Case \n " +
                    "4:Number Print As String \n 5:Print Full Name \n6:Average  \n7:Circle Area and perimeter \n 8:Next Day Calender \n 9:ExecutionTime " +
                    "\n 10:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.DisplayFriendName();
                        break;
                    case 2:
                        program.TwoNumberCalculation();
                        break;
                    case 3:
                        program.DisplayPlaceNameStyle();
                        break;
                    case 4:
                        program.NumberAsString();
                        break;
                    case 5:
                        Console.WriteLine("Enter FirstName");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName");
                        string lastName = Console.ReadLine();
                        string fullName = firstName+" "+lastName;
                        program.ArgumentVariable(fullName);
                        break;
                    case 6:
                        
                        basicCode.AverageOfNumber();
                        break;
                    case 7:
                        basicCode.CircleCalculation();
                        break;
                    case 8:
                        basicCode.DayCalender();
                        break;
                    case 9:
                        basicCode.ExecutionTimeCalculate();
                        break;
                    case 10:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.ReadLine();
            }
        }
        //Display Frd Name 
        public void DisplayFriendName()
        {
            string[] frdArray = { "Snehal", "Madhavi", "Mayur", "Anu", "Madhav" };
            Console.WriteLine("Display My Friend List");
            foreach (string frd in frdArray)
            {
                Console.WriteLine(frd);
            }
        }
        //Write a program which  prompts user to enter 2 numbers
        //(numbers can have decimal numbers). Program computes the square of sum of these two numbers and square
        //of difference between these 2 numbers . 

        public void TwoNumberCalculation()
        {
            Console.WriteLine("Enter the First Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the First Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sumOfNum, subOfNum;
            sumOfNum = num1+num2;
            subOfNum = num1-num2;
            Console.WriteLine("Square of sum of Two Number: "+Math.Pow(sumOfNum, 2));
            Console.WriteLine("Square of difference of Two Number: "+Math.Pow(subOfNum, 2));
        }
        //Write a program which takes input of a place name  where you would like
        //to visit most and displays that with place with  uppercase once and then
        //all lower case once
        public void DisplayPlaceNameStyle()
        {
            Console.WriteLine("Enter the Place Name");
            string placeName = Console.ReadLine();
            Console.WriteLine("Place Name in Upper Case : "+placeName.ToUpper());
            Console.WriteLine("Place Name in Lower Case : "+placeName.ToLower());
        }
        // Read a number from user as string and print 10 times of that number as string only
        public void NumberAsString()
        {
            Console.WriteLine("Enter the Number");
            string number = Console.ReadLine();
            Console.WriteLine("Print number");
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(number);
            }
        }
        // Write a program which takes a command line arguments of a person's full
        // name (First Name, Last Name, Middle name(s) if any) and prints how many parts
        // are there in the name. Also puts different parts of arguments in one variable and prints the same
        public void ArgumentVariable(string fullName)
        {
            string[] array = fullName.Split(" ");
            Console.WriteLine("parts of Full Name "+array.Length);

            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                result = result + array[i]+" ";
            }

            Console.WriteLine("Simple name :"+result);
        }
    }
}