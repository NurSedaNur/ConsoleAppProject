using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-------------DİZİ TANIMLAMA---------------------------------
            var kursAdi = ".net 7 ile c# programlama dersleri".Split(' ');
            Console.WriteLine(kursAdi[0]);

            string[] isimler = new string[5];
            isimler[0] = "ahmet";
            isimler[1] = "ali";
            isimler[2] = "ayse";
            isimler[3] = "fatma";
            isimler[4] = "esra";
            Console.WriteLine(isimler[4]);

            //int[] numaralar=new int[5];
            //numaralar[0] = 100;
            //numaralar[1] = 200;
            //numaralar[2] = 300;
            //numaralar[3] = 400;
            //numaralar[4] = 500;
            int[] numaralar = {100,200,300,400,500};

            Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");
            Console.WriteLine($"{numaralar[1]} numaralı öğrencinin adı {isimler[1]}");
            Console.WriteLine($"{numaralar[2]} numaralı öğrencinin adı {isimler[2]}");
            Console.WriteLine($"{numaralar[3]} numaralı öğrencinin adı {isimler[3]}");
            Console.WriteLine($"{numaralar[4]} numaralı öğrencinin adı {isimler[4]}");*/


            /*----------------DİZİ METOTLARI-----------------------------------------

            string[] sehirler = { "rize", "kocaeli", "ankara" };
            int[] plakalar = { 53, 41, 06 };

            //sehirler[0] = "istanbul";
            sehirler.SetValue("istanbul", 0);
            Console.WriteLine(sehirler.GetValue(0));
            Console.WriteLine(sehirler.Length);
            Console.WriteLine(Array.IndexOf(sehirler,"kocaeli"));

            Array.Sort(sehirler);
            Array.Sort(plakalar);
            Array.Reverse(plakalar);
            Console.WriteLine(sehirler.GetValue(0));
            Console.WriteLine(plakalar.GetValue(0));
            Console.WriteLine(string.Join(", ", plakalar));

            Array.Clear(sehirler,0,2);
            Array.Clear(plakalar, 0, 1);*/


            /*---------------ARRAY SLICING------------------------
            string[] sehirler = { "zonguldak", "rize", "kocaeli", "istanbul", "ankara" };
            
            //var sehirlers = sehirler[0..3];
            //Console.WriteLine(sehirlers);*/


            /*---------------ARRAY UYGULAMA------------------------
            //ogrenciler ve notlar adında 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız degerlerle doldurunuz(3ogrenci)

            //ogrenciler dizisi kac elemanlıdır?yazdırınız;
            //ilk 2 ogrencinin ad ve not bilgisini yazıdırınız.
            //tüm ogrencilerin not ortalaması nedir?


            string[] ogrenciler = new string[3];
            int[] notlar = new int[3];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine($"{i+1}.Ogrenci adı: ");
                ogrenciler[i]=Console.ReadLine();

                Console.WriteLine($"{i + 1}.Ogrenci numarası: ");
                notlar[i] = Convert.ToInt32( Console.ReadLine());
                //Console.WriteLine(ogrenciler[i] + notlar[i]);
            }

            Console.WriteLine($"ogrenciler eleman sayısı : {ogrenciler.Length}");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(ogrenciler[i] + notlar[i]);

            }
            var top = 0;
            foreach (int not in notlar)
            {
                top += not;

            }
            Console.WriteLine($"ortalama: {top / notlar.Length}");*/


            /*---------------ÇOK BOYUTLU DİZİLER------------------------
            //ali=50,60,70
            //ahmet = 60,80,90
            //canan = 50,70,30
            //her ogrencinin not ortalamasını hesaplayınız.

            string[] ogrenciler = { "ali", "ahmet", "canan" };
            int[,] notlar = new int[3, 3];
            notlar[0, 0] = 50;
            notlar[0, 1] = 60;
            notlar[0, 2] = 70;

            notlar[1, 0] = 60;
            notlar[1, 1] = 80;
            notlar[1, 2] = 90;

            notlar[2, 0] = 50;
            notlar[2, 1] = 70;
            notlar[2, 2] = 30;

            var ortalama1 = (notlar[0, 0] + notlar[0, 1] + notlar[0, 2]) / 3;
            var ortalama2 = (notlar[1, 0] + notlar[1, 1] + notlar[1, 2]) / 3;
            var ortalama3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2]) / 3;

            Console.WriteLine($"{ogrenciler[0]} ın not ortalaması: {ortalama1}");
            Console.WriteLine($"{ogrenciler[1]} ın not ortalaması: {ortalama2}");
            Console.WriteLine($"{ogrenciler[2]} ın not ortalaması: {ortalama3}");*/


            /*---------------REFERANS TİPLER------------------------*/
            int x = 10;
            int y = x;

            Console.WriteLine(x);//10
            Console.WriteLine(y);//10

            x = 20;

            Console.WriteLine(x);//20
            Console.WriteLine(y);//10---- sadece deger verilir ondan x degisiminden etkilenmez.


            int[] a = { 10, 20};
            int[] b =a;

            Console.WriteLine(a[0]);//10
            Console.WriteLine(b[0]);//10

            a[0] = 30;

            Console.WriteLine(a[0]);//30
            Console.WriteLine(b[0]);//30---- dizinin konum adresi verilir ve iki dizi de aynı diziye ulaşır, bu nedenle a da yapılan değişiklikten b etkilenir.


            Console.ReadKey();

        }
    }
}
