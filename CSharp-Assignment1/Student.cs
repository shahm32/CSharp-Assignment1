using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment1
{
    
    public class Student
    {
        public int Id { get; set; }
        public StudentType Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Student CreateStudent(string id, StudentType type, string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(id))
                id = "0";

            if (firstName == null)
                firstName = "Unknown";

            if (lastName == null)
                lastName = "";

            return new Student
            {
                Id = int.Parse(id),
                Type = type,
                FirstName = firstName,
                LastName = lastName
            };
        }

        public static void OutputStudent(Student student)
        {
            Console.WriteLine($"Student: {student.Id:D3} {student.FirstName} {student.LastName} ({student.Type})");
        }
    }

}
