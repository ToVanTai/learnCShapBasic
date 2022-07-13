using System;

namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameStudent;
            float diem;
            Console.Write("Nhap ho ten : ");
            nameStudent = Console.ReadLine();
            Console.Write("Nhap ho diem : ");
            diem = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ho ten la : " + nameStudent.ToUpper());
            Console.Write("Xep loai : ");
            if(diem >= 8)
            {
                Console.Write("Gioi");
            }else if(6.5 <= diem && diem < 8)
            {
                Console.Write("Kha");
            }else if(5 <= diem && diem <= 6.5)
            {
                Console.Write("Trung binh");
            }
            else
            {
                Console.Write("Yeu");
            }
        }
    }
}
