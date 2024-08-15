using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            C# Veri Tipleri
            Value Types: 
                tam sayı: byte,short,int,long
                ondalıklı sayılar: float,double,decimal
                diğer veri tipleri: char,boolean,struct
            Reference Types:
                String,Class,Array,Interface      
             */
            int sayi = 55;
            float kdvOrani = 59.55f;
            double dbl = 5.12;
            decimal dcm = 5.05m;
            char gender = 'M';
            string str = "Samsung S24";
            bool bl = true;


            //DATA TYPE CONVERSION
            Console.Write("sayi1: ");
            int sayi1 =Convert.ToInt32(Console.ReadLine());

            Console.Write("sayi2: ");
            int sayi2 =Convert.ToInt32(Console.ReadLine());

            int toplam=(sayi1 + sayi2);
            Console.WriteLine(toplam);
            //Console.ReadKey();

            //implicit(bilinçsiz) casting
            //explicit(bilinçli) casting
            long a = 10;
            int b = (int)a;//hata vermez cunku long int ten daha buyuk. explicit(bilinçli) casting

            double f = 10.5;
            int i = (int)f;
            float h = (float)f;

            int x = 10;
            string z=Convert.ToString(x);//x.ToString(x);

            //Nullable types
            int? maas= default;
            bool? isActive= null;
            Console.WriteLine(maas.HasValue);
            Console.WriteLine(maas.GetValueOrDefault());
            Console.WriteLine(isActive.GetValueOrDefault());
            Console.ReadKey();
        }
    }
}
