namespace BasicProgramCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Program Code");
            Program program = new Program();
            program.DisplayFriendName();
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
    }
}