using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------COLLECTIONS-----------------------------------------
            //collections = arraylerin boyut ve veri tipine baglı olmadan çalışılmasıdır.

            //=>non-generic collections
            //  =>array list, =>int, string

            //=>generic collections
            //  =>int, string*/

            /*--------------------------ARRAY LIST----------------------------------------*/

            ArrayList liste=new ArrayList();
            liste.Add(10);
            liste.Add("10");
            liste.Add("ali");
            liste.Add(null);
            liste.Add(true);

            var liste2 = new ArrayList()
            {
                5,
                "ahmet",
                false,
                4.5,
                null
            };

            int[] sayilar={ 10, 20, 30 };

            liste.AddRange(sayilar);

            var eleman = (int)liste[0];
            var isim = liste[2].ToString();
            Console.WriteLine(isim);

            //insert : istenen konuma veri eklenmesi
            liste.Insert(1,"sadık");
            liste.InsertRange(2, liste2);

            //remove : buldugu ilk elemanı siler
            liste.Remove(null);

            //contains, indexof
            Console.WriteLine(liste.Contains(10));
            Console.WriteLine(liste.IndexOf(10));

            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
