using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
                new Student() {Name = "Sally" , GradeLevel = 3},
                new Student() {Name = "Bob" , GradeLevel = 3},
                new Student() {Name = "Sally" , GradeLevel = 2},
                new Student() {Name = "Adam" , GradeLevel = 3},
                new Student() {Name = "Craig" , GradeLevel = 3},
                new Student() {Name = "Craig" , GradeLevel = 2}
            };

            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);

            schoolRoll.AddStudents(students);

            foreach(Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }


        }


    }
}
