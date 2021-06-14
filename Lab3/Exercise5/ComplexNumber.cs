using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        public ComplexNumber(double real, double img)
        {
            this.Real = real;
            this.Imaginary = img;
        }

        public double Real
        {
            get;
            set;
        }

        public double Imaginary
        {
            get;
            set;
        }

        public void SetImaginary(double img)
        {
            Imaginary = img;
        }

        public void SetReal(double real)
        {
            Real = real;
        }

        public override string ToString()
        {
            return $"({Real}, {Imaginary})";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
        }

        public void Add(ComplexNumber cn)
        {
            double r = cn.Real;
            double i = cn.Imaginary;
            SetReal((Real + r));
            SetImaginary((Imaginary+i));
        }
    }
}
