using System;
using System.Collections.Generic;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> emps = new List<Person>();

            Student s = new Student();
            s.Name = "Jesse";
            s.Age = 15;
            s.GradeLevel = 8;

            Employee e = new Employee();
            e.Name = "Bob";
            e.Age = 50;
            e.ID = "234234jdfjsdf";

            emps.Add(s);
            emps.Add(e);
        }
    }
}
