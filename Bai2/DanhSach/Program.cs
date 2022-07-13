using System;
using System.Collections.Generic;
namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ThanhPho> ListTP = new List<ThanhPho>();
            ADDListTP(ListTP);
            ShowListTP(ListTP);
            SortListTP(ListTP);
            ShowListTP(ListTP);
            AddListTPV2(ListTP);
            ShowListTP(ListTP);
        }
        static void AddTP(List<ThanhPho> ListTP)
        {
            string name;
            Console.Write("Nhap ten thanh pho : ");
            name = Console.ReadLine();
            ThanhPho TP = new ThanhPho(name);
            ListTP.Add(TP);
        }
        static void ADDListTP(List<ThanhPho> ListTP)
        {
            for(int i=0; i < 5; i++)
            {
                AddTP(ListTP);
            }
        }
        static void ShowListTP(List<ThanhPho> ListTP)
        {
            foreach(ThanhPho TP in ListTP)
            {
                Console.Write(TP.Name + ", ");
            }
            Console.Write("\n");
        }
        static void SortListTP(List<ThanhPho> ListTP)
        {
            ListTP.Sort((ThanhPho TP1, ThanhPho TP2) =>
            {
                return string.Compare(TP1.Name, TP2.Name, StringComparison.OrdinalIgnoreCase);
            });
        }
        static void AddListTPV2(List<ThanhPho> ListTP)
        {
            int indexRemove = 0;
            foreach(ThanhPho TP in ListTP)
            {
                if(TP.Name.Equals("Ha Noi"))
                {
                    break;
                }
                else
                {
                    indexRemove++;
                }
            }
            ListTP.RemoveAt(indexRemove);
            ADDListTP(ListTP);
        }
    }
}
