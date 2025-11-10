using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_lesson_5
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string Name { get; set; }
        public int grade { get; set; }
        public int age { get; set; }
        public Student()
        {
        }
        public Student(string name, int grade, int age)
        {
            this.Name = name;
            this.grade = grade;
            this.age = age;
        }
        public object Clone()
        {
            return new Student
            {
                Name = this.Name,
                age = this.age
            };
        }
        public int CompareTo(Student other)
        {
            return this.grade - other.grade;
        }
    }
}
