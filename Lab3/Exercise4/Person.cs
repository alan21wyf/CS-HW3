using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Person
    {
        public Person()
        {
            SetAge(20);
        }

        public Person(int n)
        {
            SetAge(n);
        }
        public virtual int Age
        {
            set;get;
        }
        public virtual void SetAge(int n)
        {
            Age = n;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
