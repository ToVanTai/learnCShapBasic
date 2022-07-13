using System;

namespace PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] listNum;
            int N;
            do
            {
                Console.Write("Nhap N = ");
                N = Int32.Parse(Console.ReadLine());
            } while (N <= 0);
            listNum = new int[N];
            AddListNum(listNum,N);
            ShowListNum(listNum);
            ShowListNumNT(listNum);
        }
        public static void AddListNum(int [] listNum, int N)
        {
            for(int i = 0; i<listNum.Length; i++)
            {
                int addNum;
                Console.Write("Nhap listNum[{0}] = ",i);
                addNum = Int32.Parse(Console.ReadLine());
                listNum[i] = addNum;

            }
        }
        public static void ShowListNum(int[] listNum)
        {
            for (int i = 0; i < listNum.Length; i++)
            {
                Console.Write(listNum[i] + ", ");
            }
        }
        public static bool IsNT(int num)
        {

                for (int j = 2; j <= num/2; j++)
                {
                    if (num % j == 0)
                    {
                        return false;
                    }
                }
            return true;
            
        }
        public static void ShowListNumNT(int[] listNum)
        {
            Console.Write("\nCac so nguyen to : ");
            for(int i = 0; i < listNum.Length; i++)
            {
                if (IsNT(listNum[i]))
                {
                    Console.Write(listNum[i] + ", ");
                }
            }
        }
    }
}
