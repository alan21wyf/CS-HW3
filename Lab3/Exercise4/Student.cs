using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Student: Person
    {
        public Student()
        {
            SetAge(15);
        }

        public Student(int n)
        {
            SetAge(n);
        }

        public override int Age
        {
            set;get;
        }

        public override void SetAge(int n)
        {
            this.Age = n;
        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {this.Age} years old.");
        }

        public override void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
