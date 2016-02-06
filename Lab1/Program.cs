using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///цикл аркылы шыгару
            int cnt = 0; // Kolvo
            int n = int.Parse(Console.ReadLine()); // переводим строку в число
            for(int i=1; i<= n; ++i)
            {
                if (n % i == 0)
                {
                    cnt++; // егер сан i га калдыксыз болинсе онда ++
                }
            }
            if (cnt > 2)
            {
                Console.WriteLine("This is not a prime number: " + n);
            }
            else
                Console.WriteLine("This is a prime number: " + n);
        }
    }
}