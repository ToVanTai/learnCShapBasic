using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            do
            {
                do
                {
                    Console.Write("Nhap a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                } while (a <= 0);
                do
                {
                    Console.Write("Nhap b = ");
                    b = Convert.ToDouble(Console.ReadLine());
                } while (b <= 0);
                do
                {
                    Console.Write("Nhap c = ");
                    c = Convert.ToDouble(Console.ReadLine());
                } while (c <= 0);
            } while (c + b <= a || c + a <= b || b + c <= a);
            double P = (a + b + c) /2;
            double V = (a + b + c);
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine("Chu vi tam giac = " + V);
            Console.WriteLine("Dien tich tam giac = " + S);
        }
    }
}
