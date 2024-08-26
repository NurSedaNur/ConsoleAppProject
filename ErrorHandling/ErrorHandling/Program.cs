using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------------------HATA YÖNETİMİ--------------------------
            //Exception
            //System.FormatException
            //System.DivideByZeroException
            //System.NullReferenceException

            try
            {
                Console.WriteLine("1. sayi: ");
                int sayi1=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2. sayi: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());// TryParse
                var sonuc=sayi1/sayi2;
                Console.WriteLine(sonuc);
            }
            catch (FormatException)
            {
                Console.WriteLine("sayısal bilgileri düzgün giriniz");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("sayı 2 sıfır olmamalıdır");
            }
            catch (Exception ex)
            {
                Console.WriteLine("bir hata oluştu");
                Console.WriteLine(ex.Message);
            }*/
            //Exception handling


            /*------------------------HATA FIRLATMA--------------------------*/

            Console.WriteLine("parola: ");
            var parola=Console.ReadLine();

            try
            {
                parola_kontrol(parola);
                Console.WriteLine("parola gecerli");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
        static void parola_kontrol(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                throw new Exception("parola 6-10 arasında olmalıdır");
            }
            if (!password.Any(char.IsDigit))
            {
                throw new Exception("parola en az bir rakam içermelidir");
            }
            if (!password.Any(char.IsLetter))
            {
                throw new Exception("parola en az bir harf içermelidir");
            }
        }
    }
}
