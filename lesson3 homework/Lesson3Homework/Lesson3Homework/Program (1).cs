using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Lesson3Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shelf shelf = new Shelf();
            shelf.Books.Add(new Book("Yaldey shay", "David", true, 75));
            shelf.Books.Add(new Book("Noach bar moach", "Naama", false, 50));
            shelf.Books.Add(new Book("Bedarkey raboteinu", "Yaakov", true, 120));
            shelf.Books.Add(new Book("Maagal sagur", "Chana", false, 40));
            shelf.Books.Add(new Book("Avigail bat hachail", "Yael", true, 80));

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
