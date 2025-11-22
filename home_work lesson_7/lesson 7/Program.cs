using System.Collections.Generic;
using System.Text.Json;

namespace lesson_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert filename");
            string filename = Console.ReadLine();
            Console.WriteLine("insert file path");
            string path = Console.ReadLine();
            Console.WriteLine("insert file type");
            string filetype = Console.ReadLine();
            Console.WriteLine("insert file target");
            string filetarget = Console.ReadLine();
            Console.WriteLine("insert target file type");
            string targetfiletype = Console.ReadLine();

            string json = File.ReadAllText(path);
            List<Person> Persons = JsonSerializer.Deserialize<List<Person>>(json);

            foreach (var Person in Persons)
            {
                Console.WriteLine($"{Person.Id} - {Person.Name} - {Person.Age}");
            }

            string jsonString = JsonSerializer.Serialize(Persons);

         
            File.WriteAllText(targetfiletype, jsonString);








        }
    }
    }

