﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    class Person
    {
        private string name;
        private int id;
        private int age;

        //static variable/class variable
        //there's only one--it belongs to Person
        private static int count = 0;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; } //once constructed, id can't be changed
        public int Age { get => age; set => age = value; }
        public int Count { get => count; }

        public Person(string name, int age)
        {
            this.name = name;
            this.id = count;
            count++; //incrementing for the next

            Console.WriteLine($"ID {this.id} assigned; count is now {count}");
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} ({id})";
        }
    }
}