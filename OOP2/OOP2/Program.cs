using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soru1 = new Soru(1, "Hangisi programlama dili degildir?", new string[4] { "python", "C#", "java", "html" }, "html");

            var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[4] { "python", "C#", "java", "html" }, "C#");

            var soru3 = new Soru(3, "Hangisi web programlama platformu degildir?", new string[4] { "Django", "Asp.Net", "Spring", "Python" }, "Python");

            //var sorular = new Soru[] { soru1, soru2, soru3 };

            //foreach (var soru in sorular)
            //{
            //    Console.WriteLine(soru.SoruMetni);
            //    foreach (var secenek in soru.Secenekler)
            //    {
            //        Console.WriteLine(secenek);
            //    }
            //    //kullanıcıdan cevap alalım
            //    Console.WriteLine("Cevap giriniz: ");
            //    var cevap= Console.ReadLine();
            //    soru.CevapKontrol(cevap);
            //    if (soru.CevapKontrol(cevap))
            //    {
            //        Console.WriteLine("tebrikler, bildiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı yanıt");
            //    }
            //}

            Console.WriteLine(soru1.SoruYazdır());
            Console.WriteLine(soru1.CevapKontrol("html"));

            Console.WriteLine(soru2.SoruYazdır());
            Console.WriteLine(soru2.CevapKontrol("html"));

            Console.WriteLine(soru3.SoruYazdır());
            Console.WriteLine(soru3.CevapKontrol("python"));

            Console.ReadKey();

            //protected, internal, protected internal , private protected
        }
    }

    class Soru
    {
        //constructor
        public Soru()
        {
            //Console.WriteLine("soru nesnesi oluşturuldu");
            this.SoruId=new Random().Next(11111,99999);
            Console.WriteLine("constructor1");
        }
        public Soru(int soruId)
        {
            this.SoruId = soruId;
            Console.WriteLine("constructor2");
        }
        public Soru(int soruId,string soruMetni, string[] secenekler,string cevap)
        {
            this.SoruId=soruId;
            this.SoruMetni=soruMetni;
            this.Secenekler=secenekler;
            this.Cevap=cevap;
        }

        //properties
        private int SoruId { get; set; }//sonradan degistirilmesini onlemek icin private olarak tanımlandı
        private string SoruMetni { get; set; }
        private string[] Secenekler { get; set; }
        private string Cevap { get; set; }

        //methods
        public bool CevapKontrol(string cevap)
        {
            return this.Cevap.ToLower()==cevap.ToLower();
        }
        public string SoruYazdır()
        {
            string soru = "";
            soru += this.SoruMetni+"\n";
            foreach(var secenek in this.Secenekler)
            {
                soru += secenek + "\n";
            }
            return soru;
        }
    }
}
