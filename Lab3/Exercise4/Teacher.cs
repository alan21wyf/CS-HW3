using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Teacher: Person
    {
        private string subject;

        public Teacher()
        {
            SetAge(30);
        }

        public Teacher(int n)
        {
            SetAge(n);
        }

        public override int Age
        {
            set; get;
        }

        public override void SetAge(int n)
        {
            this.Age = n;
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }

        public override void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
