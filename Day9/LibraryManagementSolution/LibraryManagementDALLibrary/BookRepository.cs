using LibraryManagementModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementDALLibrary
{
    public class BookRepository : IRepository<int, Book>
        {
            readonly Dictionary<int, Book> _Books;
    public BookRepository()
    {
        _Books = new Dictionary<int, Book>();
    }
    int GenerateId()
    {
        if (_Books.Count == 0)
            return 1;
        int id = _Books.Keys.Max();
        return ++id;
    }
    public Book Add(Book item)
    {
        if (_Books.ContainsValue(item))
        {
            return null;
        }
        _Books.Add(GenerateId(), item);
        return item;
    }

    public Book Delete(int key)
    {
        if (_Books.ContainsKey(key))
        {
            var department = _Books[key];
            _Books.Remove(key);
            return department;
        }
        return null;
    }

    public Book Get(int key)
    {
        return _Books.ContainsKey(key) ? _Books[key] : null;
    }

    public List<Book> GetAll()
    {
        if (_Books.Count == 0)
            return null;
        return _Books.Values.ToList();
    }

    public Book Update(Book item)
    {
        if (_Books.ContainsKey(item.Id))
        {
            _Books[item.Id] = item;
            return item;
        }
        return null;
    }
}
}
