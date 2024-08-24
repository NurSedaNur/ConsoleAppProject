using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class=>object(ogr1,ogr2)
            Ogrenci ogr1 = new Ogrenci() { OgrenciNo = "100", AdSoyad = "Ada Bilgi", Sube = "6/A" };

            Ogrenci ogr2 = new Ogrenci() { OgrenciNo = "200", AdSoyad = "Yigit Bilgi" , Sube = "7/A" };

            Ogrenci ogr3 = new Ogrenci() { OgrenciNo = "300", AdSoyad = "Çınar Turan", Sube = "1/A" };
            
            Ogrenci[] ogrenciler=new Ogrenci[3] {ogr1, ogr2, ogr3};
            
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci.bilgileriYazdir());
            }
            Console.ReadKey();
        }
    }
    class Ogrenci
    {
        //property=>string,int
        public string OgrenciNo { get; set; }
        public string AdSoyad { get; set; }
        public string Sube { get; set; }

        //method=>bilgileriYazdir()
        public string bilgileriYazdir()
        {
            string sonuc=($"{this.OgrenciNo} numaralı ogrencinin adı: {this.AdSoyad} ve subesi: {this.Sube}");
            return sonuc;
        }
    }
}
//OOP=>Program,Main
//System=>Console
//System.IO=>File,Directory,Path
