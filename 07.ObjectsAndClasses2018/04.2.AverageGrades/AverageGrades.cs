using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._2.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double[] grades = new double[line.Length-1];
                for (int j = 1; j < line.Length; j++)
                {
                    double grade = double.Parse(line[j]);
                    grades[j - 1] = grade;
                }
                string name = line[0];
                Student student = new Student(name,grades);
                if (student.Average >= 5.00)
                {
                    students.Add(student);
                }
            }
            students = students.OrderBy(x => x.Name)
               .ThenByDescending(x => x.Average)
                .ToList();

            foreach (var stud in students)
            {
                Console.WriteLine($"{stud.Name} -> {stud.Average:f2}");
            }
        }
    }
    class Student
    {
        public string  Name { get; set; }
        public double[] Grades { get; set; }

        public double Average {get{return Grades.Average();} }

        public Student (string name,double[] grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
    }
}
