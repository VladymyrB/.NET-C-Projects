﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_2
{
    public static class Extension
    {
        public static List<Student> FindStudent(this List<Student> students, StudentPredicateDelegate studentPredicate)
        {

            var newStudents = new List<Student>();

            foreach (var student in students)
            {
                if (studentPredicate(student))
                {
                    newStudents.Add(student);
                }
            }

            return newStudents;
        }
    }
}
