using Data;

namespace MyApp
{
    internal class Program
    {
        public static bool IsHard(Book b) => b.HardCover ;
        //public static bool IsHard2(Book b)
        //{// if (b.HardCover==true)
        ////      return true;
        ////  return false;
        //    return b.HardCover == true;
        //}

        
        static void Main(string[] args)
        {
            //Shelf shelf = new Shelf();
            Shelf shelf = new ();

            shelf.Books.Add(new Book()
            {
                Title = "Yaldey shay",
                Author = "David",
                HardCover = true,
                Price = 75
            });
            try
            {
                shelf.AddBook(new Book("Noach bar moach", "Naama", false, -5));
                // לכאן לא ממשיכים
                //shelf.Books.Add();
                shelf.Books.Add(new Book("Bedarkey raboteinu", "Yaakov", true, 120));
                shelf.Books.Add(new Book("Maagal sagur", "Chana", false, 40));
                shelf.Books.Add(new Book("Avigail bat hachail", "Yael", true, 80));
                shelf.Books.Add(new Book("Avigail ", "Yael", true, 90));
            }
            catch (Exception ex)
            {
                // טיפול בשגיאה
               // return "status 404";
            }
            finally // בכל מקרה
            { 
            
            }
            // כתבי שאילתא בתחזיר את הספרים עם כריכה קשה שיקרים מ60 ש"ח
            var x= shelf.Books.FindAll(IsHard);
            //1
            var x2 = shelf.Books.FindAll(b => b.HardCover && b.Price>60 );
            Console.WriteLine("Hardcover books:");

            //2
            Console.WriteLine("Books by Yael:");
            foreach (var b in shelf.Books.FindAll(b => b.Author == "Yael"))
            Console.WriteLine(b.Title);
            //3
            var booksendsWithl = shelf.Search(b => b.Title.EndsWith("l"));
            Console.WriteLine("Books ends with 'l':");
            booksendsWithl.ForEach(Console.WriteLine);
            Console.ReadLine();
            //4
            Console.WriteLine("Books more then 50 ₪:");
            foreach (var b in shelf.Books.Where(b => b.Price > 50))
            Console.WriteLine(b);



            



            shelf.Search(IsHard);

            shelf.Books.Sort((b1,b2)=>(int)(b1.Price-b2.Price ));
            
            var hardcoverOver60 = shelf.Search(b => b.HardCover && b.Price > 60);
            Console.WriteLine("Hardcover books over 60 ₪:");
            hardcoverOver60.ForEach(Console.WriteLine);

            Console.WriteLine("Books by Chana:");
            foreach (var b in shelf.Books.Where(b => b.Author == "Chana"))
                Console.WriteLine(b);

            Console.WriteLine("Books under 50 ₪:");
            foreach (var b in shelf.Books.Where(b => b.Price < 50))
                Console.WriteLine(b);

            var booksStartingWithA = shelf.Search(b => b.Title.StartsWith("A"));
            Console.WriteLine("Books starting with 'A':");
            booksStartingWithA.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}
