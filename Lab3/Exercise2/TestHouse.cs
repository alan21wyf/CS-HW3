using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class TestHouse
    {
        static void Main()
        {
            bool debug = true;
            SmallApartment mySmallApartment = new SmallApartment();
            Person myPerson = new Person();

            myPerson.Name = "Alan";
            myPerson.House = mySmallApartment;
            myPerson.ShowData();

            if (debug)
            {
                Console.ReadLine();
            }
        }
    }
}
