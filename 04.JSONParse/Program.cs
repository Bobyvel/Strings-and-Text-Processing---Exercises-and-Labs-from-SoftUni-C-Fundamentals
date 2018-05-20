using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.JSONParse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var students = new List<Student>();
            var pattern = @"""(?<name>\w+)"",age:(?<age>\d+),grades:\[(?<grades>[0-9, ]*)\]";
            
            var match = Regex.Matches(input, pattern);
            
            foreach (Match m in match)
            {
               var student = new Student();
               student.Name = m.Groups["name"].ToString();
               student.Age = int.Parse(m.Groups["age"].ToString());
               student.Grades = m.Groups["grades"].ToString().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(g => int.Parse(g)).ToList();
               students.Add(student);
            }
            
            foreach (var st in students)
            {
                if (st.Grades.Count < 1)
                {
                    Console.WriteLine($"{st.Name} : {st.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{st.Name} : {st.Age} -> {string.Join(", ", st.Grades)}");
                }
                
            }

            
        }

        public class Student
        {
            public string Name { get; set; } 
            public int Age { get; set; } 
            public List<int> Grades { get; set; } 
        }
    }
}
