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
            Console.WriteLine("4. Delete Book by ID");
            Console.WriteLine("5. Search Books by Author Name");
            Console.WriteLine("6. Update Book Title");
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
                    case 4:
                        DeleteBook();
                        break;
                    case 5:
                        FindBookByAuthorName();
                        break;
                    case 6:
                        UpdateBooktitle();
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
                Console.WriteLine("Congrats. We have created the Book for you \n");
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
                Console.WriteLine("Deleted Book is ");
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
                Console.WriteLine("Here is your book");
                Console.WriteLine(book);
            }
            catch (BookNotFoundException ddne)
            {
                Console.WriteLine(ddne.Message);
            }

        }
        void FindBookByAuthorName()
        {
            Console.WriteLine("Enter the Author's name:");
            string authorName = Console.ReadLine();

            try
            {
                List<Book> books = BookBL.GetBooksByAuthorName(authorName);
                Console.WriteLine("Here are the books by " + authorName + ":");

                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        void UpdateBooktitle()
        {
            try
            {


                Console.WriteLine("Enter the current title of the book:");
                string currentName = Console.ReadLine()?? string.Empty;

                Console.WriteLine("Enter the new title of the book:");
                string newName = Console.ReadLine() ?? string.Empty;

                Book updatedBook = BookBL.UpdateBookTitle(currentName, newName);

                if (updatedBook != null)
                {
                    Console.WriteLine("Book title updated successfully!");
                    Console.WriteLine("Updated book details:");
                    Console.WriteLine(updatedBook);
                }
                else
                {
                    Console.WriteLine("Book with the current title '" + currentName + "' not found.");
                }
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program(); // Create a single instance of Program

            program.Library();
            //program.PrintBooks(); // Print all books
            //program.DeleteBook();
        }

    }
}
