namespace BasicProgramCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Program Code");
            Program program = new Program();
            //program.DisplayFriendName();
            //program.TwoNumberCalculation();
            // program.DisplayPlaceNameStyle();
            program.NumberAsString();
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