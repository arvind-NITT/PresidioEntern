namespace Question4

{
    internal class Program
    {

        static string TakeInput()
        {
            Console.WriteLine("Please Enter Your Name ");
            string myString = Console.ReadLine();
            int length = myString.Length;
            Console.WriteLine("Length is " + length);
            return myString;
        }
       
        static void Main(string[] args)
        {
            string Name = TakeInput();
           
        }
    }
}
