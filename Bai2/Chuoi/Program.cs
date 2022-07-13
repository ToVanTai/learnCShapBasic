using System;
using System.Collections.Generic;
namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //cau 1
            Console.WriteLine("Cau 1");
            string myStr;
            Console.WriteLine("Enter = ");
            myStr = Console.ReadLine();
            Console.WriteLine("Show");
            for(int i = 0; i< myStr.Length; i++)
            {
                Console.WriteLine(myStr[i]);
            }
            //cau 2
            Console.WriteLine("Cau 2");
            for (int i = 0; i < myStr.Length; i++)
            {
                if(!myStr[i].Equals(' '))
                {
                    Console.WriteLine(myStr[i]);
                }
            }
            //cau 3
            Console.WriteLine("Cau 3");
            List<char> listId = new List<char>();
            bool isAdd = true;
            for(int i = 0; i< myStr.Length; i++)
            {
                if (listId.Count.Equals(0))
                {
                    listId.Add(myStr[i]);
                    Console.WriteLine("Add 1");
                }
                else
                {
                    for(int j = 0; j < listId.Count;j++)
                    {
                        if (listId[j].Equals(myStr[i]))
                        {
                            isAdd = false;
                            break;
                        }
                    }
                    if(isAdd == true)
                    {
                        listId.Add(myStr[i]);
                    }
                    isAdd = true;
                }
            }
            int count = 0;
            for(int i = 0; i< listId.Count; i++)
            {
                for(int j = 0; j < myStr.Length; j++)
                {
                    if (listId[i].Equals(myStr[j]))
                    {
                        count++;
                    }
                }
                Console.WriteLine("ky tu '{0}' : {1}", listId[i], count);
                count = 0;
            }
        }
    }
}
