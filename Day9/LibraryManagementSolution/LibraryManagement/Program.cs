using LibraryManagementModelLibrary;
using LibraryManagementBLLibrary;
namespace LibraryManagement
{
    public class Program
    {
         BookBl BookBL = new();
        void PrintMenu()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Print Book");
            Console.WriteLine("3. Search Book by ID");
            Console.WriteLine("0. Exit");
        }
        void Library()
        {
            int choice = 0;
            do
            {
                PrintMenu();
                Console.WriteLine("Please select an option");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye.....");
                        break;
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        PrintBooks();
                        break;
                    case 3:
                        SearchBookById();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            } while (choice != 0);
        }
        void AddBook()
        {

            try
            {
                Console.WriteLine("Pleae enter the Book Title");
                string title = Console.ReadLine();
                Console.WriteLine("Pleae enter the Author name");
                string author = Console.ReadLine();
                Console.WriteLine("Pleae enter the Book Description");
                string description = Console.ReadLine();
                Book Book = new Book() { Title = title, Author = author , Description = description };
                int id = BookBL.AddBook(Book);
                Console.WriteLine("Congrats. We have created the Book for you and the Id is " + id);
                  }
            catch (BookAlreadyExistException ddne)
            {
                Console.WriteLine(ddne.Message);
            }
        }

        void DeleteBook()
        {
            //BookBl BookBL = new BookBl();

            try
            {
                Console.WriteLine("Pleae enter the Book Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Book book = BookBL.DeleteBookById(id);
                Console.WriteLine(book);

            }
            catch (BookNotFoundException ddne)
            {
                Console.WriteLine(ddne.Message);
            }
           


        }

        void PrintBooks()
        {

            //BookBl BookBL = new BookBl();

            try
            {

                List<Book> books = BookBL.GetAllBooks(); // Assuming GetAllBooks() returns List<Book>

                foreach (Book book in books)
                {
                    Console.WriteLine(book.ToString()); // Assuming Book class has a proper ToString() implementation
                }

            }
            catch (BookNotFoundException ddne)
            {
                Console.WriteLine(ddne.Message);
            }


        }
        void SearchBookById()
        {
           

            try
            {

                Console.WriteLine("Enter the Book Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Book book = BookBL.GetBookById(id);

                Console.WriteLine(book);
            }
            catch (BookNotFoundException ddne)
            {
                Console.WriteLine(ddne.Message);
            }

        }
        static void Main(string[] args)
        {
            Program program = new Program(); // Create a single instance of Program

            program.Library(); // Add a book
            //program.PrintBooks(); // Print all books
            //program.DeleteBook();
        }

    }
}
