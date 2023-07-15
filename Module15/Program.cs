using System;
using System.Collections.Generic;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new Classroom[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            string allStudents = GetAllStudents(classes);

            Console.WriteLine("Все студенты в текстовом формате: ");
            Console.WriteLine(allStudents);
        }

        private static string GetAllStudents(Classroom[] classes)
        {
            return string.Join(" ", classes.SelectMany(c => c.Students));
        }
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}