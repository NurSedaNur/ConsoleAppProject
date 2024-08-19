using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------BİR--------------------------------          
            //---Strings: Karakter dizileri - referance =>null
            
            char cinsiyet = 'E';
            string cinsiyet2 = "E";

            Console.Write("Ad: ");
            string ad = Console.ReadLine();

            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            Console.Write("Yaş: ");
            string yas = Console.ReadLine();

            //string concat
            //string mesaj = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır";

            //string interpolation
            string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";

            Console.WriteLine(mesaj);
            Console.ReadKey();*/


            /*-----------------İKİ-------------------------------------------------
            //---String method

            string mesaj = "Ahmet turan isimli kişi 20 yaşındadır.";

            //int sonuc=mesaj.Length;
            //var sonuc=mesaj.ToLower();
            //var sonuc = mesaj.ToUpper();
            //var sonuc = mesaj.Trim();
            //var sonuc = mesaj.Split(' ')[4];
            //var sonuc = mesaj.StartsWith("A");
            //var sonuc = mesaj.EndsWith(".");
            //var sonuc = mesaj.Contains("Ahmet");
            //var sonuc = mesaj.IndexOf("turan");
            var sonuc = mesaj.Substring(10);


            Console.WriteLine(sonuc);
            Console.ReadKey();*/


            /*------------ÜÇ--------------------------------
            //---String Uygulamaları

            string kursAdi = ".NET 7 ile C# Programlama Dili";

            //1 - Kaç karaktere sahiptir?
            //2 - Hepsini küçük harf yapınız.
            //3 - '.' ile mi başlamaktadır?
            //4 - C# bilgisi hangi konumdaır?
            //5 - String C# bilgisini içeriyor mu?
            //6 - 'Dili' kelimesi yerine 'Dersleri' yazınız.

            var uzunluk= kursAdi.Length;
            var kucukHarf = kursAdi.ToLower();
            var baslangic = kursAdi.StartsWith(".");
            var nerde = kursAdi.IndexOf("C#");
            var varMi=kursAdi.Contains("C#");
            var degistir = kursAdi.Replace("Dili", "Dersleri");

            Console.WriteLine($"{uzunluk} +{kucukHarf} +{baslangic} +{nerde} +{varMi} +{degistir}");
            Console.ReadKey();  */


            /*------------DÖRT--------------------------------*/
            //---Datetime

            DateTime simdi= DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.Year);
            Console.WriteLine(simdi.Month);
            Console.WriteLine(simdi.Day);
            Console.WriteLine(simdi.DayOfWeek);
            Console.WriteLine(simdi.DayOfYear);
            Console.WriteLine(simdi.Hour);
            Console.WriteLine(simdi.Minute);
            Console.WriteLine(simdi.Second);


            DateTime dt = new DateTime(2023, 08, 19, 23, 16, 40);
            Console.WriteLine(dt.Year);

            DateTime dt2= dt.AddYears(1);
            Console.WriteLine(dt2.Year);

            DateTime dt3=dt.AddHours(5);
            Console.WriteLine(dt3.Hour);

            var fark = simdi - dt;
            Console.WriteLine(fark.TotalDays);
            Console.WriteLine(fark.TotalHours);

            Console.ReadKey();



        }
    }
}
