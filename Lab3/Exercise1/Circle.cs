using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Circle : Shape1
    {

        private double radius;

        public void GetRadius()
        {
            Console.Write("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public override float Area()
        {
            return (float)(Math.Pow(radius,2) * Math.PI);
        }

        public override float Circumference()
        {
            return (float)(Math.PI * 2 * radius);
        }
    }
}
