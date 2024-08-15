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
            //Application
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
            Console.ReadKey();








        }
    }
}
