namespace UnderstandingBasicsAgain
{
    internal class Program
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
        void UnderstandingSwitchCase()
        {
            Console.WriteLine("Please enter the day number");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Are you a noob");
                    break;
            }
            //Console.WriteLine("Please enter a number for day");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Weekend");
            //        break;
            //    default:
            //        Console.WriteLine("You dont know the numberof days in a week???");
            //        break;
            //}
        }
        void UnderstandingArray()
        {
            int[] numbers = { 222, 677, 900, 777, 666, 686,89 ,6789};
            int ans = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 100 || numbers[i]>999) continue;
                int first = numbers[i]%10;
                int second= (numbers[i]/10)%10;
                int third =  numbers[i]/100;
                //Console.WriteLine(first);
                //Console.WriteLine(second);
                //Console.WriteLine(third);
                if (first == second && second == third)
                {
                    ans++;
                }

            }
            Console.WriteLine(ans);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.UnderstandingSequenceStatments();
            //program.UnderstandingSelectionWithIf();
            //program.UnderstandingSwitchCase();
            program.UnderstandingArray();
        }
    }
}
