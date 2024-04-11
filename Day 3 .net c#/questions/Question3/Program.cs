namespace Question3

{
    internal class Program
    {

        static int TakeInput()
        {
            int num1;
            Console.WriteLine("Please enter the number ");
            while (int.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.WriteLine("Please Enter a valid number");
            }
            return num1;
        }
        static void Calculate()
        {
            int num2 = 0, num1;
            num1 = TakeInput();
            int count = 0;
            while (num1 >= 0)
            {
                if (num1%7==0)
                {
                    num2 += num1;
                    count++;
                }
                num1 = TakeInput();
            }


            Console.WriteLine("Average of All Is ");
            if (count != 0)
                Console.WriteLine((float)num2 / count);
            else Console.WriteLine("0");
        }
        static void Main(string[] args)
        {
            Calculate();
        }
    }
}
