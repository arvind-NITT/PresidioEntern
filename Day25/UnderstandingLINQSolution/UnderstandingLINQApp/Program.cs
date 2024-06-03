
using UnderstandingLINQApp.Model;

namespace UnderstandingLINQApp
{
    internal class Program
    {
        void PrintTheBooksPulisherwise()
        {
            pubsContext context = new pubsContext();
            var books = context.Titles
                        .GroupBy(t => t.PubId, t => t, (pid, title) => new { Key = pid, TitleCount = title.Count(), TitleNames = title.ToList() });

            foreach (var book in books)
            {
                Console.Write(book.Key);
                Console.WriteLine(" - " + book.TitleCount);
                Console.WriteLine("BookNames");
                foreach (var title in book.TitleNames)
                {
                    Console.WriteLine(title.Title1);
                }
            }
        }void PrintTheQuantityAndOrderId()
        {
            pubsContext context = new pubsContext();
            var books = context.Sales
                        .GroupBy(s => s.TitleId, s => s, (titleId, sales) => new {
                            TitleId = titleId,
                            Sales = sales.ToList()
                        });

            foreach (var book in books)
            {
                Console.Write(book.TitleId);
                //Console.WriteLine(" - " + book.TitleCount);
                foreach (var title in book.Sales)
                {
                    Console.WriteLine(title.Qty);
                }
            }
        }
        //void PrintTheBooksPulisherwise()
        //{
        //   pubsContext context = new pubsContext();
        //    var books = context.Titles
        //        .GroupBy(t => t.PubId)
        //        .Select(t => new
        //        {
        //            publisherid = t.Key,
        //            titlecount = t.Count(),
        //            titles = t.Select(t => new
        //            {
        //                BookName = t.Title1,
        //                BookPrice = t.Price
        //            })

        //        });
        //    foreach( var book in books )
        //    {
        //        Console.Write(book.publisherid);
        //        Console.WriteLine("  -  " + book.titlecount);
        //        foreach(var title in book.titles)
        //        {
        //            Console.WriteLine("\t" + title.BookName +
        //                " " + title.BookPrice);
        //        }
        //    }
        //}
        void PrintNumberOfBooksFromType(string type)
        {
            pubsContext context = new pubsContext();
            var bookCount = context.Titles.Where(t => t.Type == type).Count();
            Console.WriteLine($"There are {bookCount} in the type {type}");
        }
        void PrintAuthorNames()
        {
            pubsContext context = new pubsContext();
            var authors = context.Authors.ToList();
            foreach (var author in authors)
            {
                Console.WriteLine(author.AuFname + " " + author.AuLname);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            //program.PrintAuthorNames();
            //program.PrintNumberOfBooksFromType("mod_cook");
            //program.PrintTheBooksPulisherwise();
            program.PrintTheQuantityAndOrderId();
        }
    }
}
