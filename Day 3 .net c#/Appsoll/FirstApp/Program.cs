namespace FirstApp
{
    internal class Program
    {  
         static int Add(int a, int b)
        {
            checked
            {
                int result = a+b;
                return result;
            }
            //return 0;
        }
        static int TakeInput()
        {
            int num1;
            Console.WriteLine("PleaSE  enter the number");
            while(int.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.WriteLine("Please Enter A Valid number");
            }
            return num1;
        }
        static void Calculate() {  
            int num2,num1;
            num1= TakeInput();
            num2 = TakeInput();
            Console.WriteLine("Sum is ");
            int sum=  Add(num1,num2);
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int num1,num2;
            //string name=null;
            //Console.WriteLine("Please enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine("Welcome " + name);
            //Console.WriteLine("Please enter first numbner");
            //num1 = Convert.ToInt32(name);
            //num1++;
            //Console.WriteLine($"the incremented value is {num1}");
            //float fnum1;
            Calculate();
        }
    }
}
