using System;
using System.Collections.Generic;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Inigo Montoya", 32);
            Student s = new Student("Grant Chirpus", 6, 2015, 4, "Java");

            //polymorphism allows us to use a more specific type as a more general
            Person p2 = new Student("Lady Witherell", 4, 2016, 2, "Java");

            Employee e = new Employee("Peter Guenther", 45, "DoL", 1000000);
            //but not the opposite
            //Student s2 = new Person("Kincaid", 1);

            //because I can treat subclasses (derived classes) as the more general
            //I can keep them in a collection of the superclass
            List<Person> people = new List<Person>();
            people.Add(p);
            people.Add(s);
            people.Add(p2);
            people.Add(e);

            //static variables belong to the class, not an instance
            Console.WriteLine("Total count of people: " + Person.Count);

            foreach (Person pe in people)
            {
                //if I need to use more specific properties/methods
                //I need to check if it's the derived class first
                if (pe is Employee)
                {
                    //I know it's the derived class Employee
                    //I still have to cast with proper OoOperations
                    ((Employee)pe).GiveRaise(.1);
                }
                Console.WriteLine(pe.ToString());
            }
        }
    }
}