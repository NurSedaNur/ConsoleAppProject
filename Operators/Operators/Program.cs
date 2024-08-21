using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*----------------ARİTMETİK OPERATÖRLER-----------------------------
            var a = 10;
            var b = 3;
            var c = 2;

            //var sonuc = a + b;
            //var sonuc = a - b;
            //var sonuc = a * b;
            //var sonuc = a / b;
            //var sonuc =(float)a + (float)b;
            //var sonuc = a % b;
            //var sonuc = (a + b)*c;
            //var sonuc = ++a;
            var sonuc = a++;

            Console.WriteLine(sonuc);*/

            /*--------------ARİTMETİK OPERATÖR UYGULAMALARI------------------
            //a=10,b=5,c=20 ise c-a farkının b katı kaçtır?
            //int? a=50; int b=20; ise a+b değerini hesaplayınız.(eger a null ise sonuc nedir?)
            //a=10,b=20 ise a=b--;atamasından sonra a ve b degerleri nedir?
            //klavyeden girilen bir sayının tek /çift kontrolünü yapınız.


            //int a = 10; 
            //int b = 5;
            //int c = 20;
            //Console.WriteLine($"c-a farkının b katı: {(c-a)*b}");


            //int? a = null; //a null olursa toplama işlemi sonucu sonuc null olur.
            //int b = 20;
            //Console.WriteLine($"a+b değerini hesaplayınız.(eger a null ise sonuc nedir?): {(a??0)+b}");//a null ise 0 degeri atanır


            //int a = 10;
            //int b = 20;
            //a = b--;
            //Console.WriteLine($"a=b--;atamasından sonra a: {a} ve b: {b}");  


            Console.WriteLine("bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine() ?? "0");
            if (sayi % 2 == 0)
            {
                Console.WriteLine("çift");
            }
            else
            {
                Console.WriteLine("tek");
            }*/


            /*--------------------ATAMA OPERATÖRLERİ-----------------------------
            var a = 5;
            var b = 10;

            a += b; //a = a + b;
            a -= b; //a = a - b;
            a *= b; //a = a * b;
            a /= b; //a = a / b;
            a %= b; //a = a % b;
            Console.WriteLine(a);

            //Math
            double sonuc;
            sonuc =Math.Pow(2,3);//üs alma
            sonuc=Math.Sqrt(25);//karekok
            sonuc=Math.Abs(-5);//mutlak deger
            sonuc = Math.Round(4.5);//yuvarlama
            sonuc = Math.Ceiling(4.5);//hep yukarı yuvarlar
            sonuc = Math.Floor(4.5);//hep asagı yuvarlar
            sonuc = Math.Max(10,50);//max degeri bulur
            sonuc = Math.Min(10, 50);//min degeri bulur

            Console.WriteLine(sonuc);*/

            /*--------------------KARŞILAŞTIRMA OPERATÖRLERİ-----------------------------
            // (?:) parantez içindeki operatör a>b? "a buyuk" : "b buyuk"

            int a=5,b=5,c=10,d=3;
            string username = "sedanur";
            string password = "1234";

            var sonuc = (a == b);//true
            sonuc = (username == "sedanur");//true
            sonuc = (password == "12345");//false
            sonuc=(a!=b);//false
            sonuc=(a>c);//false
            sonuc = (a >= b);//true
            
            var sonuc2 = (a < b) ? "a kucuk" : (a==b)? "esit":"b kucuk" ;

            Console.WriteLine(sonuc2);*/


            /*--------------------KARŞILAŞTIRMA OPERATÖRLERİ UYGULAMA-----------------------------
            //klavyeden girilen yaş bilgisine gore oy kullanabilme durumunu inceleyiniz.
            //girilen bir sayının işaretini kontrol ediniz.
            //girilen bir sayının tek/çift olma durumunu kontrol ediniz.


            //Console.WriteLine("bir sayı giriniz: ");
            //var sayi =Convert.ToInt32(Console.ReadLine());
            //var sonuc = (sayi < 18 ? "oy kullanamaz" : "oy kullanabilir");
            //Console.WriteLine(sonuc);


            //Console.WriteLine("bir sayı giriniz: ");
            //var sayi =Convert.ToInt32(Console.ReadLine());
            //var sonuc = (sayi < 0 ? "negatif" : sayi > 0 ? "pozitif": "sayı 0'dır");
            //Console.WriteLine(sonuc);


            Console.WriteLine("bir sayı giriniz: ");
            var sayi = Convert.ToInt32(Console.ReadLine());
            var sonuc = (sayi%2 ==0 ? "cift" : "tek");
            Console.WriteLine(sonuc);*/


            /*----------------------MANTIKSAL OPERATÖRLER-----------------------------------------

            var a = true;
            var b = true;
            var c = false;
            var d = false;

            //1 - ve - &&
            var sonuc = a && b;
            sonuc= b && c;
            Console.WriteLine(sonuc);

            //2 - veya - ||
            sonuc = b || c;
            sonuc = a || b;
            sonuc = c || d;
            Console.WriteLine(sonuc);

            //3 - degil - !
            sonuc = !a;
            Console.WriteLine(sonuc); */


            /*----------------------MANTIKSAL OPERATÖRLER UYGULAMA-----------------------------------------
            //yası 18den buyuk ya da veli izni varsa bir işte calısabilir durumunu kontrol ediniz
            //ders notu 50-100 arasındaysa gecti degilse kaldı bilgisini yazdırınız
            //ders ortalamsı en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilmesini kontrol ediniz
            //işe girmek için en az on lisans ya da lisans mezunu olma durumunu kontrol ediniz,sigara kullanılmamalı 
            //uygulamaya giriş kontrolunu username ve parola için yapın


            //var yas = 20;
            //var izin=true;
            //Console.WriteLine((yas>18)||(izin) ? "calısabilir" : "calısamaz" );

            //var dersNotu = 80;
            //Console.WriteLine((dersNotu >= 50) && (dersNotu <= 100) ? "gecti" : "kaldı");

            //var dersOrt = 80;
            //var zayıfVarMi = false;
            //Console.WriteLine((dersOrt >= 70) && (zayıfVarMi == false) ? "teşekkür belgesi alabilir" : "teşekkür belgesi alamaz");

            //var okuma = "lisans";
            //var sigaraKullanıyorMu = false;
            //var mezun = ((okuma == "lisans") || (okuma == "ön lisans") ? true : false );
            //Console.WriteLine((mezun== true) && (sigaraKullanıyorMu==false) ? "girebilir" : "giremez");

            var username = "seda";
            var sifre = "1234";
            Console.WriteLine((username == "seda") && (sifre == "1234") ? "giriş başarılı" : "giriş başarısız");*/


            /*-----------------------------RANDOM---------------------------------------*/

            var rnd=new Random();

            var sayi=rnd.Next();//pozitif sayı üretir   
            sayi = rnd.Next(100);//max deger verilir
            sayi = rnd.Next(-50,-5);//aralık verilir
            Console.WriteLine(sayi);


            Console.ReadKey();


        }
    }
}
