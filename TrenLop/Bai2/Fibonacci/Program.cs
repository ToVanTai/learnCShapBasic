using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNum;
            int n;
            do
            {
                Console.Write("Nhap N = ");
                n = Int32.Parse(Console.ReadLine());
            } while (n <= 2);
            listNum = new int[n];
            Add(listNum);
            Show(listNum);
        }
        public static void Add(int [] listNum)
        {
            listNum[0] = 0;
            listNum[1] = 1;
            for(int i = 2; i < listNum.Length; i++)
            {
                listNum[i] = listNum[i - 1] + listNum[i - 2];
            }
        }
        public static void Show(int [] listNum)
        {
            for(int i = 0; i < listNum.Length; i++)
            {
                Console.Write(listNum[i] + ", ");
            }
        }
    }
}
