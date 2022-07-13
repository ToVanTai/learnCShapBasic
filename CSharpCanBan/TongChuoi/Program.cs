using System;

namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong N ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            double S1=0, S2=0;
            for(int i = 1; i <= n; i++)
            {
                S1 += i;
                S2 += ((double)1 / i);
            }
            Console.WriteLine("Tong a = " + S1);
            Console.WriteLine("Tong b = " + S2);
        }
    }
}
