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

            HashSet<Student> students = new HashSet<Student>
            {
                new Student() {Name = "Sally" , GradeLevel = 3},
                new Student() {Name = "Bob" , GradeLevel = 3},
                new Student() {Name = "Sally" , GradeLevel = 2},
                new Student() {Name = "Adam" , GradeLevel = 3},
                new Student() {Name = "Craig" , GradeLevel = 3},
                new Student() {Name = "Craig" , GradeLevel = 2}
            };

            Student joe = new Student() { Name = "Joe", GradeLevel = 2 };

            students.Add(joe);


            //Testing duplicate data
            Student duplicateJoe = new Student() { Name = "Joe", GradeLevel = 2 };

            students.Add(duplicateJoe);
            //it shows that they are still two distinct objects

            //two get two objects to return the same hashcode you have to override the GetHashCode method
            //this is done over in the Student class

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }


        }


    }
}
