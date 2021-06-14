using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class SmallApartment: House
    {
        protected new int area;
        protected new Door door;

        public SmallApartment(int a = 50) : base(50)
        {
            this.area = a;
        }



        public override void ShowData()
        {
            Console.WriteLine("I am an apartment, my area is " + area + " m2.");
        }
    }
}
