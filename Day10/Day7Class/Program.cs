using Day7BLLibrary;
using Day7ClassModelLibrary;
using Day7DALLibrary;
using System.Collections;
using System.Globalization;

namespace Day7Class
{
    internal class Program
    {
        void UnderstaingList()
        {
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add("Hello");
            list.Add(23.4);
            list.Add(90.3f);
            double total = 0;
            list.Add(new Employee(101, "Ramu", new DateTime(), "Admin"));
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                total = Convert.ToDouble(list[i]);
            }
        }
        void UnderstandingGenericList()
        {
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(79);
            numbers.Add(55);
            double total = 0;
            //for (int i = 0;i < numbers.Count;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //    total += numbers[i];
            //}
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
                total += i;
            }
            Console.WriteLine($"Total is {total}");
        }

        void UnderstandingSet()
        {
            HashSet<string> names = new HashSet<string>()
    {
        "Ramu","Bimu"
    };
            names.Add("Somu");
            names.Add("Komu");
            names.Add("Timu");
            names.Add("Ramu");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        void UnderstandingDictionary()
        {
            Dictionary<int,string> Dict = new Dictionary<int,string>();
            Dict.Add(1, "arvind");
            Dict.Add(2, "sunil");
            foreach (var item in Dict)
            {
                Console.WriteLine(item);
            }
            Dict.Remove(2);
            foreach (var item in Dict)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingJaggedArray()
        {
            string[][] posts = new string[4][];
            for(int i = 0; i < posts.Length; i++)
            {
                Console.WriteLine("Enter How many column you want");
                int count = Convert.ToInt32(Console.ReadLine());
                for(int j = 0; j < count; j++)
                {
                    Console.WriteLine($" \n Please enter the post {j+1} value");
                    posts[i][j] = Console.ReadLine();
                }
            }
            Console.WriteLine("Posts \n");
            for (int i = 0; i < posts.Length; i++)
            {
                int count = posts[i].Length;
                for (int j = 0; j < count; j++)
                {
                    Console.WriteLine(posts[i][j] + " -- ");
                    Console.WriteLine("------------------------>");
                }
            }
        }

        int Divide(int num1, int num2)
        {
            try
            {
                int result = num1 / num2;
                return result;
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("You are trying to divide by zero. Its not worth");
            }
            finally
            {
                Console.WriteLine("Release the divide method resource");
            }
            Console.WriteLine("Your division did not go well");
            return 0;

        }

        void AddDepartment()
        {

                DepartmentBL departmentBL = new DepartmentBL(new DepartmentRepo());
            try
            {
                Console.WriteLine("Pleae enter the department name");
                string name = Console.ReadLine();
                Department department = new Department() { Name = name };
                int id = departmentBL.AddDepartment(department);
                Console.WriteLine("Congrats. We ahve created the department for you and the Id is " + id);
                Console.WriteLine("Pleae enter the department name");
                name = Console.ReadLine();
                department = new Department() { Name = name };
                id = departmentBL.AddDepartment(department);
                Console.WriteLine("Congrats. We ahve created the department for you and the Id is " + id);
            }
            catch (DuplicateDepartmentNameException ddne)
            {
                Console.WriteLine(ddne.Message);
            }
        }


        static void Main(string[] args)
        {
            new Program().AddDepartment();
        }

    }
}
