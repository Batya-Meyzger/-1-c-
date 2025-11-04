using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;

public class Book
{
    private decimal price;

    public string? Title { get; set; }
    public string Author { get; set; } = "";
    public bool HardCover { get; set; }
    public decimal Price
    {
        get => price;
        set
        {
            if (value > 0)
                price = value;
            else
                //price = 10;  // כאן צריך להיות לכידת שגיאות
              //  Console.WriteLine("ערך שגוי");
            // לשלוח מידע על שגיאה ולטפל בה במקום שנבחר
            // ליצור אוביקט שיכיל מידע על השגיאה
                 throw new Exception("מחיר לא תקין");
            Console.WriteLine(  "במקרה של אלס לא יקרה");
        } 
    }

    public Book(string title, string author, bool hardCover, decimal price)
    {
        Title = title;
        Author = author;
        HardCover = hardCover;
        Price = price;
    }

    public Book()
    {

    }
   
    public override string ToString() =>
             $"{Title} by {Author}, {(HardCover ? "Hardcover" : "Softcover")}, Price: {Price} ₪";
    

  






}
