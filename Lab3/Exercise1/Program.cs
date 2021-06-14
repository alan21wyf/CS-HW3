using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle cir = new Circle();

            rec.GetLB();
            Calculate(rec);

            cir.GetRadius();
            Calculate(cir);
        }

        public static void Calculate(Shape1 S)
        {
            Console.WriteLine("Area : {0}", Math.Round(S.Area(),1));
            Console.WriteLine("Circumference : {0}", Math.Round(S.Circumference(),1));
            Console.WriteLine();
        }
    }
}
