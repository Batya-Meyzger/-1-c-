using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Shelf
    {

        public int NumOfItems { get; set; }
        public List<Book> Books { get;  } = new List<Book>();

        public Shelf( List<Book> books)
        {
           
            Books = books;
            NumOfItems = 10;
        }

        public Shelf()
        {

        }
        public bool AddBook(Book b)
        {
            if (Books.Count < NumOfItems)
            {
                Books.Add(b);
                return true;
            }
            return false;  
        }

        public List<Book> Search2(Predicate<Book> func)
        {
            List<Book> result = new List<Book>();
            foreach (Book b in Books) 
                if (func(b))
                    result.Add(b);
            return result ;
        }
        public List<Book> Search3(Func<Book,bool> func)
        {
            List<Book> result = new List<Book>();
            foreach (Book b in Books)
                if (func(b))
                    result.Add(b);
            return result;
        }



        public List<Book> Search(Func<Book, bool> predicate)
        {
            List<Book> result = new List<Book>();
            foreach (var book in Books)
            {
                if (predicate(book))
                    result.Add(book);
            }
            return result;
        }
    }
}
