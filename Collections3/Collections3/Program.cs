using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            // Key-Value => plaka-şehir

            Dictionary<int,string> plakalar=new Dictionary<int,string>();
            plakalar.Add(41, "kocaeli");
            plakalar.Add(34, "istanbul");
            plakalar.Add(59, "tekirdağ");

            Dictionary<int,string> sayilar=new Dictionary<int, string>()
            {
                {1,"bir" },
                {2,"iki" },
                {3,"üç" }
            };

            Console.WriteLine(plakalar[41]);
            if (plakalar.ContainsKey(61))
            {
                Console.WriteLine(plakalar[61]);
            }

            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka.Key+" "+plaka.Value);
            }

            //update
            sayilar[1] = "one";
            sayilar.Remove(2);
            //sayilar.Clear(); //bütün elemanları siler
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi.Key + " " + sayi.Value);
            }

            Console.ReadKey();
        }
    }
}
