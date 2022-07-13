using System;
using System.Linq;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int [] listNum;
            int numFind;
            int findIndex;
            do
            {
                Console.Write("Nhap so luong phan tu N = ");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N <= 0);
            listNum = new int[N];
            for(int i = 0; i < N; i++)
            {
                Console.Write("Nhap listNum[{0}] = ", i);
                listNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang vua nhap la ");
            for(int i=0; i< listNum.Length; i++)
            {
                Console.Write(listNum[i] + " ");
            }
            Console.WriteLine("\nNhap phan tu can tim = ");
            numFind = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < listNum.Length; i++)
            {
                if (listNum[i].Equals(numFind))
                {
                    Console.Write("Vi tri tim thay la : ");
                    Console.Write(i);
                    break;
                }
            }
            Console.WriteLine("\nPhan tu lon nhat la : {0}", listNum.Max());
            Console.WriteLine("Phan tu nho nhat la : {0}", listNum.Min());
        }
    }
}
