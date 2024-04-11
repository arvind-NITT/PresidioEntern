namespace Question2

{
    internal class Program
    {
       
        static int TakeInput()
        {
            int num1;
            Console.WriteLine("Please enter the number ");
            while (int.TryParse(Console.ReadLine(), out num1) == false  )
            {
                Console.WriteLine("Please Enter a valid number");
            }
            return num1;
        }
        static void Calculate()
        {
            int num2=0, num1;
            num1 = TakeInput();
            while (num1 >= 0)
            {
                if(num2 < num1)
                {
                    num2= num1;
                }
                num1 = TakeInput();
            }
           
            Console.WriteLine("Greatest Among All Is ");
            Console.WriteLine(num2);
        }
        static void Main(string[] args)
        {
            
            Calculate();
        }
    }
}
