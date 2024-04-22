using LibraryManagementModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBLLibrary
{
    public interface IBookServices
    {
        int AddBook(Book Book);
        Book GetBookById(int id);
        List<Book> GetAllBooks();
        List<Book> GetBooksByAuthorName(string type);
        Book UpdateBookName(string BookOldName, string BookNewName);
        string GetBookTitle(int id);
        Book DeleteBookById(int id);

    }
}
