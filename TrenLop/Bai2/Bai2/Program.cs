using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            float cD = 0, cR = 0, cV = 0, dT = 0;
            Nhap(ref cD, ref cR);
            Tinh(cD,cR,ref cV, ref dT);
            HienThi(cD, cR, cV, dT);
        }
        public static void Nhap(ref float cD, ref float cR)
        {
            Console.Write("Nhap CD = ");
            cD = float.Parse(Console.ReadLine());
            Console.Write("Nhap CR = ");
            cR = float.Parse(Console.ReadLine());
        }
        public static void Tinh(float cD, float cR, ref float cV, ref float dT)
        {
            cV = (cD + cR) * 2;
            dT = cD * cR;
        }
        public static void HienThi(float cD, float cR,float cV,float dT)
        {
            Console.WriteLine("CD = " + cD);
            Console.WriteLine("CR = " + cR);
            Console.WriteLine("CV = " + cV);
            Console.WriteLine("DT = " + dT);
        }

    }
}
