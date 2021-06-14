using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle : Shape1
    {
        private float length;
        private float breadth;

        public void GetLB()
        {
            Console.Write("Enter Length: ");
            length = (float)(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Enter Breadth: ");
            breadth = (float)(Convert.ToDouble(Console.ReadLine()));
        }
        public override float Area()
        {
            return breadth * length;
        }

        public override float Circumference()
        {
            return 2 * (breadth + length);
        }
    }
}
