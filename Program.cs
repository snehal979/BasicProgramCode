namespace BasicProgramCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Program Code");
            Program program = new Program();
            //program.DisplayFriendName();
            program.TwoNumberCalculation();
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

    }
}