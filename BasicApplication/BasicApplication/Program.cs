using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi giriniz:");
            var sayi = Convert.ToInt32(Console.ReadLine());

            string[] dizi = { "a", "b", "c", "d" };
            for (int i = 0; i < sayi; i++)
            {
                var sayıMod = i % 4;
                Console.WriteLine(dizi[sayıMod]);

            }
            Console.ReadKey();


        }
    }
}
