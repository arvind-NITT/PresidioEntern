namespace Question1
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            checked
            {
                int result = a + b;
                return result;
            }
        }
        static int Subtract(int a, int b)
        {
            checked
            {
                int result = a - b;
                return result;
            }
        }
        static int Multiply(int a, int b)
        {
            checked
            {
                int result = a * b;
                return result;
            }
        }
        static int Divide(int a, int b)
        {
            checked
            {
                if (b == 0) {
                    Console.WriteLine("Attempted to divide by zero ");
                    return 0;
                }
                int result = a / b;
                return result;
            }
        }
        static int TakeInput()
        {
            int num1;
            Console.WriteLine("Please  enter the number");
            while (int.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.WriteLine("Please enter a valid number");
            }
            return num1;
        }
        static void CalculateForAdd()
        {
            Console.WriteLine("For Sum");
            int num2, num1;
            num1 = TakeInput();
            num2 = TakeInput();
            Console.WriteLine("Sum is ");
            int sum = Add(num1, num2);
            Console.WriteLine(sum);
        }
        static void CalculateForSubtract()
        {
            Console.WriteLine("For Subtraction");
            int num2, num1;
            num1 = TakeInput();
            num2 = TakeInput();
            Console.WriteLine("Subtraction is ");
            int sum = Subtract(num1, num2);
            Console.WriteLine(sum);
        }
        static void CalculateForMultiply()
        {
            Console.WriteLine("For Multiplication");
            int num2, num1;
            num1 = TakeInput();
            num2 = TakeInput();
            Console.WriteLine("Multiplication is ");
            int sum = Multiply(num1, num2);
            Console.WriteLine(sum);
        }
        static void CalculateForDivide()
        {
            Console.WriteLine("For Division");
            int num2, num1;
            num1 = TakeInput();
            num2 = TakeInput();
            Console.WriteLine("Division is ");
            int sum = Divide(num1, num2);
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        { 
            CalculateForAdd();
            CalculateForSubtract();
            CalculateForMultiply();
            CalculateForDivide();
        }
    }
}
