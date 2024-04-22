using LibraryManagementDALLibrary;
using LibraryManagementModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBLLibrary
{
    public class BookBl : IBookServices
    {
        readonly IRepository<int, Book> _BookRepository;
        public BookBl()
        {
            _BookRepository = new BookRepository();
        }
        public int AddBook(Book Book)
        {
            var result = _BookRepository.Add(Book);
            //Console.WriteLine(result);
            if (result != null)
            {
                return result.Id;
            }
            throw new BookAlreadyExistException();
        }

        public Book DeleteBookById(int id)
        {
            Book Book = _BookRepository.Delete(id);
            if (Book != null)
            { return Book; }
            throw new BookNotFoundException();
        }

        public List<Book> GetAllBooks()
        {
            return _BookRepository.GetAll();
        }

        public Book GetBookById(int id)
        {
            Book book = _BookRepository.Get(id);

            if (book != null)
            {
                return book;
            }
            throw new BookNotFoundException();
        }

        public List<Book> GetBooksByAuthorName(string Author)
        {
            List<Book> Books = _BookRepository.GetAll();
            List<Book> result = new List<Book>(); // Initialize result list

            foreach (Book book in Books)
            {
                if (book.Author == Author)
                {
                    result.Add(book);
                }
            }

            if (result.Count == 0)
            {
                throw new BookNotFoundException();
            }

            return result;
        }

        public string GetBookTitle(int id)
        {
            Book Book = _BookRepository.Get(id);
            if (Book != null)
            {
                return Book.Title;
            }
            throw new BookNotFoundException();
        }

        //public Book UpdateBookName(string BookOldName, string BookNewName)
        //{
        //    throw new NotImplementedException();
        //}

        public Book UpdateBookTitle(string BookOldName, string BookNewName)
        {
            List<Book> Books = _BookRepository.GetAll();
            foreach (Book book in Books)
            {
                if (book.Title == BookOldName)
                {
                    book.Title = BookNewName;
                    return book;
                }
            }
            throw new BookNotFoundException();
        }
    }
}
