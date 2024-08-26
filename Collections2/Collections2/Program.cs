using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generic list
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(20);

            List<string> isimler = new List<string>() { "ali", "ahmet", "ayse",null};

            List<Product>urunler=new List<Product>();
            urunler.Add(new Product() { Id = 1, Title = "iphone 14", Price = 40000 });
            urunler.Add(new Product() { Id = 2, Title = "iphone 15", Price = 50000 });
            urunler.Add(new Product() { Id = 3, Title = "iphone 16", Price = 60000 });

            urunler.Insert(urunler.Count, new Product() { Id = 4, Title = "iphone 17", Price = 70000 });
            urunler.RemoveAt(2);
            urunler.Remove(urunler[0]);

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Title+" "+urun.Price);
            }

            Console.ReadKey();
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
