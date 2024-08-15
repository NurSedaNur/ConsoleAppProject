using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*Example_1:Bir öğrencinin aşağıdaki bilgileri için gerekli alanları oluşturunuz.
             öğrenci adı, öğrenci soyadı, öğrenci ad ve soyadı, öğrenci numarası, öğrenci cinsiyeti, öğrenci tc kimlik, öğrenci doğum yılı, öğrenci adres bilgisi, öğrenci yaşı

             Example_2:aşağıdaki ürünlerin toplam bilgisini hesaplayınız.
             ürün 1=50Tl
             ürün 2= 60.5TL
             ürün 3=356.45TL*/


            //Example_1
            var studentName = "Ali ";
            var studentSurname = "Turan";
            var studentNameSurname= studentName+studentSurname;
            var studentNumber = 123;
            var studentGender = "male";
            var studentTc = "1111111";
            var studentBirthyear = 2005;
            var studentAge=2024-studentBirthyear;
            var studentAddress = "Kocaeli/izmit";

            Console.WriteLine(studentName);
            Console.WriteLine(studentSurname);
            Console.WriteLine(studentNameSurname);
            Console.WriteLine(studentNumber);
            Console.WriteLine(studentGender);
            Console.WriteLine(studentTc);
            Console.WriteLine(studentBirthyear);
            Console.WriteLine(studentAge);
            Console.WriteLine(studentAddress);
            //Console.ReadKey();

            //Example_2
            var productOnePrice = 50;
            var productTwoPrice = 60.5;
            var productTreePrice = 356.45;

            Console.WriteLine("Toplam: " + (productOnePrice + productTwoPrice + productTreePrice));
            Console.ReadKey();


        }
    }
}
