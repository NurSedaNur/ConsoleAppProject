using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sonuc = HelperMethods.KarakterDuzelt("ölçme ve değerlendirme");
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }

    class HelperMethods
    {
        public static string KarakterDuzelt(string str)
        {
            return
                str.Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ı", "i")
                .Replace("ğ", "g")
                .Replace("ç", "c")
                .Replace(" ", "-");
        }

    }

}
