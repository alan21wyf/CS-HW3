using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Person
    {
        protected string name;
        protected House house;

        public Person(string name, int area)
        {
            this.name = name;
            this.house = new House(area);
        }

        public Person()
        {
            this.name = "Alan";
            this.house = new House(170);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public House House
        {
            get { return house; }
            set { house = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Door.ShowData();
        }
    }
}
