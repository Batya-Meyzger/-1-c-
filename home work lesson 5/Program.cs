using System.Linq;
using System.Text.RegularExpressions;

namespace home_work_lesson_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Leader = "David";
            Group<Student, string> group = new Group<Student, string>(Leader, "כיתה א", 5, 1, DateTime.Now);
            group.Add(new Student {Name="Moshe",age=5});
            group.Add(new Student {Name="Meir",age =6});
            group.Add(new Student {Name="Ytzchak",age=7});
            Student student1 = new Student();
            group.RemoveAt(0);
            
            int count=group.Count();
            Console.WriteLine(count +"num students in the group" );

            
            if (group.Contains(student1) ) 
            {
                Console.WriteLine($"החבר {student1} נמצא בקבוצה ✅");
            }
            
            {
                Console.WriteLine($"החבר {student1} לא נמצא בקבוצה ❌");
            }






        }
    }
}
