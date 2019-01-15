using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10._2.StudentGroups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                if (input.Contains("=>"))
                {
                    string[] inputLine = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                    Town town = new Town();
                    town.Name = inputLine[0];
                    string[] count = inputLine[1].Split(" ");
                    town.SeatsCount = int.Parse(count[0]);
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    string[] inputLine = input.Split("|",StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student();
                    student.Name = inputLine[0];
                    student.Email = inputLine[1];
                    student.RegistrationDate = DateTime.ParseExact(inputLine[2].Trim(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    towns[towns.Count - 1].Students.Add(student);
                }
                input = Console.ReadLine();
            }
            List<Group> groups = DistributeStudentsIntoGroups(towns);
            Console.WriteLine($"Created {groups.Count} groups in {groups.Capacity} towns:");
            foreach (var group in groups)
            {
                Console.WriteLine("{0} => {1}",group.Town,string.Join(", ", group.Students));
            }
        }
        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            towns = towns.OrderBy(x => x.Name).ToList();
            foreach (var town in towns)
            {
                List<Student> students = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();
                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students
                        .Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount).ToList();
                    groups.Add(group);
                }
            }
            return groups;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
