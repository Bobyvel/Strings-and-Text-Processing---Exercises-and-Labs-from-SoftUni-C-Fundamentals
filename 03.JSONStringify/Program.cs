using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.JSONStringify
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var input = Console.ReadLine();

            while (input != "stringify")
            {
                var tolkens = input.Split(new string[] {":", "->", " ", ","}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var currentStudent = new Student();
                currentStudent.Name = tolkens[0];
                currentStudent.Age = int.Parse(tolkens[1]);
                currentStudent.Grades = tolkens.Skip(2).Select(int.Parse).ToList();
                
                students.Add(currentStudent);

                input = Console.ReadLine();
            }

            
            var result = new StringBuilder();
            result.Append("[");
            foreach (var student in students)
            {
                result.Append("{name:" + "\"" + student.Name + "\",age:" + student.Age + ",grades:[" + string.Join(", ", student.Grades) + "]},");
               
            }

            result.Remove(result.Length - 1, 1);
            result.Append("]");

            Console.WriteLine(result);
        }

        public class Student
        {
            public string Name { get; set; } 
            public int Age { get; set; } 
            public List<int> Grades { get; set; } 
        }
    }
}
