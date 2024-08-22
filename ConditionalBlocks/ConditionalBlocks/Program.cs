using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------IF - ELSE - ELSE IF BLOCKS------------------
            string username = "seda nur";
            string password = "12345";

            var islogin= (username == "seda nur" && password == "12345") ;
            if (islogin)
            {
                Console.WriteLine("Merhaba BTK Akademi");
            }else {
                Console.WriteLine("Giriş Başarısız");
            }

            //ELSE IF
            if (username != "seda nur")
            {
                Console.WriteLine("USERNAME HATALI");
            }
            else if (password != "12345")
            {
                Console.WriteLine("PASSWORD HATALI");
            }
            else
            {
                Console.WriteLine("Merhaba BTK Akademi");
            }*/


            /*--------------IF - ELSE - ELSE UYGULAMALAR------------------
            // 1) kullanıcıya sunulan bir menü içinden secilecek olan 4 işlem tipine gore hesaplama yapınız
            //Console.WriteLine("seciniz: toplama / cikarma / carpma / bolme");
            //var secilen = Console.ReadLine();

            //Console.WriteLine("1. sayi: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. sayi: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (secilen == "toplama") { Console.WriteLine(sayi1 + sayi2); }
            //else if (secilen == "cikarma") { Console.WriteLine(sayi1 - sayi2); }
            //else if (secilen == "carpma") { Console.WriteLine(sayi1 * sayi2); }
            //else if (secilen == "bolme") { Console.WriteLine(sayi1 / sayi2); }
            //else { Console.WriteLine("yanlis secim"); }

            // 2) bir ogrencinin iki yazılı bir sozlu notunu alıp hesaplanan ortalamaya gore not aralıgına karıslık gelen not bilgisini yazınız
            //0 - 24 => 0
            //25 - 44 => 1
            //45 - 54 => 2
            //55 - 69 => 3
            //70 - 84 => 4
            //85 - 100 => 5

            //Console.WriteLine("1. yazılı notunuz: ");
            //var yazili1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. yazılı notunuz: ");
            //var yazili2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sozlu notunuz: ");
            //var sozlu = Convert.ToInt32(Console.ReadLine());
            //int ortalama = (yazili1 + yazili2 + sozlu) / 3;

            //if (ortalama >= 0 && ortalama <= 24)
            //{
            //    Console.WriteLine("notunuz : 0 ");
            //}
            //else if (ortalama >= 25 && ortalama <= 44)
            //{
            //    Console.WriteLine("notunuz : 1 ");
            //}
            //else if (ortalama >= 45 && ortalama <= 54)
            //{
            //    Console.WriteLine("notunuz : 2 ");
            //}
            //else if (ortalama >= 55 && ortalama <= 69)
            //{
            //    Console.WriteLine("notunuz : 3 ");
            //}
            //else if (ortalama >= 70 && ortalama <= 84)
            //{
            //    Console.WriteLine("notunuz : 4 ");
            //}
            //else if (ortalama >= 85 && ortalama <= 100)
            //{
            //    Console.WriteLine("notunuz : 5 ");
            //}
            //else
            //{
            //    Console.WriteLine("yanlis not girdiniz");
            //}


            // 3)girilen 3 sayinin en buyugunu buluunuz
            Console.WriteLine("sayi1: ");
            var sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi2: ");
            var sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi3: ");
            var sayi3 = Convert.ToInt32(Console.ReadLine());

            var enbuyuk = 0;
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                enbuyuk = sayi1;
            }else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                enbuyuk = sayi2;
            }
            else
            {
                enbuyuk = sayi3;
            }
            Console.WriteLine($"en buyuk sayi = {enbuyuk}");*/


            /*--------------------------SWITCH----------------------------------
            int gun=(int)DateTime.Now.DayOfWeek;//0:pazar, 1:ptesi, 2:salı, ... ,6:ctesi
            switch (gun)
            {
                case 0: Console.WriteLine("pazar");
                    break;
                case 1:
                    Console.WriteLine("pazartesi");
                    break;
                case 2:
                    Console.WriteLine("salı");
                    break;
                case 3:
                    Console.WriteLine("çarşamba");
                    break;
                case 4:
                    Console.WriteLine("perşembe");
                    break;
                case 5:
                    Console.WriteLine("cuma");
                    break;
                case 6:
                    Console.WriteLine("cumartesi");
                    break;

                default: 
                    Console.WriteLine("hatalı gun");
                    break ;
            }*/


            /*--------------------------TERNARY----------------------------------*/
            int sayi = -11;

            var sonuc = (sayi % 2 == 0) ?
                                 (sayi > 0) ? "pozitif cift sayi" : "negatif cift sayi" :
                                 (sayi > 0) ? "pozitif tek sayi" : "negatif tek sayi";

            Console.WriteLine(sonuc);


            Console.ReadKey();

            }
    }
}
