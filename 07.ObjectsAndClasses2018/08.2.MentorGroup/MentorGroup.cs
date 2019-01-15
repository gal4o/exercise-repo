using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08._2.MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> students = 
                new SortedDictionary<string, Student>();
            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                string[] comentor = input.Split(' ');
                string name = comentor[0];
                string[] datesString = comentor[1].Split(',');
                List<DateTime> dates = new List<DateTime>();
                for (int i = 0; i < datesString.Length; i++)
                {
                    DateTime date = DateTime.ParseExact
                        (datesString[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dates.Add( date);
                }
                dates.Sort();
                Student somone = new Student()
                { Name = name, Attendance = dates };
                students.Add(name, somone);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            Dictionary<string, List<string>> studentsComments =
                new Dictionary<string, List<string>>();
            while (input!="end of comments")
            {
                List<string> comments = new List<string>();
                string[] comentor = input.Split('-');
                string name = comentor[0];
                string comment = comentor[1];
                comments.Add(comment);
                if (students.ContainsKey(name))
                {
                    if (studentsComments.ContainsKey(name))
                    {
                        studentsComments[name].AddRange(comments);
                    }
                    else
                    studentsComments.Add(name,comments);
                }
                input = Console.ReadLine();
            }
            foreach (var stud in students)
            {
                Console.WriteLine(stud.Key);
                Console.WriteLine("Comments:");
                foreach (var item in studentsComments)
                {
                    if (item.Key == stud.Key)
                    {
                        Console.WriteLine
    ("- {0}", string.Join("\n-", item.Value));
                    }
                }

                Console.WriteLine("Dates attended:");
                foreach (var item in stud.Value.Attendance)
                {
                    Console.WriteLine($"-- {item.Day:d2}/{item.Month:d2}/{item.Year}");
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }
    }
}
