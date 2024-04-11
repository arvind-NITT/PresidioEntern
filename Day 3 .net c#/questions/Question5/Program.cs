namespace Question5

{
    internal class Program
    {

        static string TakeInput()
        {
           
            string myString = Console.ReadLine();
            return myString;
        }
        static bool check()
        {
            Console.WriteLine("Please enter Your Name ");
            string Name = TakeInput();
            Console.WriteLine("Please enter Your Password ");
            string Password = TakeInput();
            if (Name != "ABC" || Password != "123")
            {
                Console.WriteLine("Oops , Invalid Credentials !!!");
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int count = 0;
            while(count < 3)
            {
                if (check()==false)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Credentials Matched, You are Welcome");
                    break;
                }
            }
            if(count == 3)
            {
                Console.WriteLine("You exceeded the number of attempts");
            }
        }
    }
}

