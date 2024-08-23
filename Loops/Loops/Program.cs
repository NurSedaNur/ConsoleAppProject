using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------FOR DONGUSU---------------------
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/


            /*--------------------FOR DONGUSU UYGULAMALARI------------------------------------
            //// 1)1-100 ARASINDAKİ SAYILARIN TOPLAMINI BULUNUZ.
            //var toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //// 2)klavyeden girilen baslangıc ve bitis degerleri arasındaki tum sayıların toplamını hesaplayınız.
            //Console.WriteLine("baslangıc degeri: ");
            //var baslangicDegeri=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("bitis degeri: ");
            //var bitisDegeri = Convert.ToInt32(Console.ReadLine());
            //var toplam = 0;
            //for (var i = baslangicDegeri; i < bitisDegeri; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //// 3){"ali","ahmet","can","yelda","seda"} dizisindeki tüm elemanları ekrana yazdırın.
            //string[] isimler = { "ali", "ahmet", "can", "yelda", "seda" };
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine($"dizinin {i+1}. elemanı: {isimler[i]} ");
            //}

            //// 4){1,3,4,34,41,56,89} dizisindeki sayılardan hangileri 3ün katıdır?
            int[] sayilar = { 1, 3, 4, 34, 41, 56, 89, 90 };
            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 3 == 0)
                {
                    Console.WriteLine($"dizideki {i}. eleman {sayilar[i]} 3'ün katıdır.");
                }
            }*/


            /*--------------------------------WHILE DONGUSU------------------------------
            //var i = 0;
            //while (i<5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //string[] isimler = { "ali", "ahmet", "canan" };
            //var i = 0;
            //while (i < isimler.Length)
            //{
            //    Console.WriteLine(isimler[i]);
            //    i++;
            //}


            var secim = "e";
            var toplam = 0;
            var sayac = 1;
            while (secim == "e")
            {
                Console.WriteLine($"{sayac}. sayi: ");
                toplam += Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("devam etmek istiyor musunuz e/h?");
                secim = Console.ReadLine();
                sayac++;
            }
            Console.WriteLine($"{sayac-1} sayinin toplami: {toplam}");*/


            /*--------------------------------BREAK & CONTINUE------------------------------
            //string isim = "seda nur";
            //for (int i = 0; i < isim.Length; i++)
            //{
            //    if (isim[i]=='d')
            //        continue;//break dersek donguden cıkar.
            //    Console.WriteLine(isim[i]);
            //}
            //Console.WriteLine("dongü bitti.");

            int x = 0;
            while (x < 5)
            {
                x++;//alt tarafta yazıldıgında continue de x arttılmadıgından sonsuz donguye girer
                if(x == 3)
                    continue;
                Console.WriteLine(x);
            }*/


            /*--------------------------------WHILE DONGUSU UYGULAMA------------------------------
            //sayı tahmin
            //1-100 arasında rastgele tutulan bir sayıyı buldurmaya calısın.
            //tanımlanan hak bittiginde oyun bitmeli
            var rnd =new Random();
            int tutulan=rnd.Next(1,10);
            int hak = 3;
            Console.WriteLine(tutulan);
            while (hak > 0)
            {
                Console.WriteLine("sayi tahmin ediniz: ");
                var sayi = Convert.ToInt32(Console.ReadLine());
                hak--;
                if (sayi == tutulan)
                {
                    Console.WriteLine("tebrikler,bildiniz.");
                    break;
                }
                else
                {
                    if (hak == 0)
                    {
                        Console.WriteLine("oyun bitti, bilemediniz.");
                        break;
                    }
                    if (sayi > tutulan)
                    {
                        Console.WriteLine("asagı");
                    }
                    else
                    {
                        Console.WriteLine("yukarı");
                    }

                }
            }
            Console.WriteLine("tutulan sayi: "+ tutulan);*/


            /*--------------------------------DO WHILE DONGUSU------------------------------
            //int i = 0;
            //do{
            //    Console.WriteLine(i);
            //    i++;
            //}while (i < 10);

            Console.WriteLine("adet");
            int adet=Convert.ToInt32(Console.ReadLine());
            string[] urunler = new string[adet];
            int i = 0;
            do
            {
                Console.WriteLine("ürün adı: ");
                urunler[i] = Console.ReadLine()?? "";
                i++;
            }while (adet!=i);

            Console.WriteLine("urunler listeleniyor...");
            for(var a = 0; a < adet; a++)
            {
                Console.WriteLine(urunler[a]);
            }*/


            /*--------------------------------FOREACH DONGUSU------------------------------*/
            string isim = "seda";
            
            //for(var i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine(isim[i]);
            //}

            foreach(var harf in isim)
            {
                Console.WriteLine(harf);
            }

            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            foreach (var sayi in sayilar)
            {
                if(sayi==4)
                    break;
                Console.WriteLine(sayi);
            }



            Console.ReadKey();

        }
    }
}