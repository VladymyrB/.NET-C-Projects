using System;
using System.Collections.Generic;

namespace Lab11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student> 
            {
            new Student
            {
                Age = 12,
                FirstName = "Some",
                LastName = "Asome"
                
            },
             new Student
            {
                Age = 19,
                FirstName = "Saome",
                LastName = "Asome"

            },
              new Student
            {
                Age = 22,
                FirstName = "aSome",
                LastName = "Asome"

            },
               new Student
            {
                Age = 13,
                FirstName = "Some",
                LastName = "Asome"

            },
                new Student
            {
                Age = 12,
                FirstName = "Soasdme",
                LastName = "Asdasome"

            },
                 new Student
            {
                Age = 32,
                FirstName = "asfSome",
                LastName = "vdsAsome"

            },
            };

           students =  students.FindStudent(
               (student) => 
               { 
                   return Student.IsAdult(student); 
               } 
               );

           students = students.FindStudent(
               (student) => 
               {
                   return Student.IsLastNameBigger3(student);
               }
               );

           students = students.FindStudent(
               (student) =>
               {
                   return Student.IsNameStartA(student);
               }
               );

            foreach (var student in students)
            {
                Console.WriteLine(student.Age);
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
            }
        }
    }
}
