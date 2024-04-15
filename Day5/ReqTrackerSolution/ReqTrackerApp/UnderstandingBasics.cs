using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqTrackerApp
{
    internal class UnderstandingBasics
    {
        void UnderstandingSequenceStatments()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hi");
            int num1, num2;
            num1 = 100;
            num2 = 20;
            int num3 = num1 / num2;
            Console.WriteLine($"The result of {num1} divided by {num2} is {num3}");
        }
        void UnderstandingSelectionWithIf()
        {
            string strName = "Ramu";
            if (strName == "Ramu")
            {
                Console.WriteLine("Welcome Ramu. you are authorized");
                Console.WriteLine("Bingo!!");
            }
            else if (strName == "Somu")
                Console.WriteLine("You are Somu not Ramu. ONly Basic access");
            else
                Console.WriteLine("I don't know who you are. Get out...");

        }
        static void Main(string[] args)
        {
            UnderstandingBasics program = new UnderstandingBasics();
            //program.UnderstandingSequenceStatments();
            program.UnderstandingSelectionWithIf();

        }
    }
}
