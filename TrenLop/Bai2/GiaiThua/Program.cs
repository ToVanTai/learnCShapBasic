using System;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int gt = 1;
            int N;
            do
            {
                Console.Write("Nhap N = ");
                N = Int32.Parse(Console.ReadLine());
            } while (N < 0);
            for(int i = 1; i <= N; i++)
            {
                gt *= i;
            }
            Console.WriteLine("GT {0} = {1}",N,gt);
        }
    }
}
