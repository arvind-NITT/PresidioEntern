using System.Data;
using System.Xml.Linq;

namespace LibraryManagementModelLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Book()
        {
            Id = 0;
            Title = string.Empty;
            Description = string.Empty;
            Author = string.Empty;
        }
        public Book(int id, string title, string description, string author)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
        }

        public virtual void BuildBookFromConsole()
        {
            Console.WriteLine("Please enter the Title");
            Title = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("Please enter the Description");
            Description = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("Please enter the Author Name");
            Author = Console.ReadLine() ?? String.Empty;
        }


        public override string ToString()
        {
            return " --------------------------- \n"
                + "\n Book Title : " + Title
                + "\n Description : " + Description
                + "\n Author : " + Author
                + "\n ------------------------------ \n";
        }

    }
}
