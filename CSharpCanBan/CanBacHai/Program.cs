using System;

namespace CanBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount;
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("amount = {0:#,###.#0}",amount);//5->5,00 1000->1.000,00
            Console.WriteLine("amount = {0:0#%}", amount);// 1->100; 0.5->50
        }
    }
}
