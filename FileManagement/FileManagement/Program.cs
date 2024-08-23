using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------------DOSYA OKUMA------------------------------------
            //satır satır okuma
            StreamReader sr = File.OpenText("C://Users//sedan//Desktop//deneme.txt.txt");
            var s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }

            //butun içeirgi okur
            string sonuc = File.ReadAllText("C://Users//sedan//Desktop//deneme.txt.txt");
            Console.WriteLine(sonuc);

            //butun içerigi okuyup diziye atmak
            string[] sonuc2 = File.ReadAllLines("C://Users//sedan//Desktop//deneme.txt.txt");
            Console.WriteLine(sonuc2[0]);
            Console.WriteLine(sonuc2[2]);*/


            /*--------------------------DOSYAYA YAZMA VE OKUMA------------------------------------
            ////CreateText ile varolan dosya içerigi silinir yenileri kaydedilir.
            //using (StreamWriter sw = File.CreateText("C://Users//sedan//Desktop//deneme.txt.txt")) { //using kullanılmazsa sw.Close(); kullanılmalıdır.
            //    sw.WriteLine("Merhaba");
            //    sw.WriteLine("BTK");
            //    sw.WriteLine("Akademi");
            //};

            ////AppendText ile varolan dosya içerigine ek olarak yenileri kaydedilir.
            //using (StreamWriter sw = File.AppendText("C://Users//sedan//Desktop//deneme.txt.txt"))
            //{ //using kullanılmazsa sw.Close(); kullanılmalıdır.
            //    sw.WriteLine("Selam");
            //    sw.WriteLine("BTK");
            //    sw.WriteLine("Akademi");
            //};

            //WriteAllText dosya varsa içerigi siler ve verilen bilgileri yazar.
            File.WriteAllText("C://Users//sedan//Desktop//deneme.txt.txt","merhaba");

            //AppendAllText dosya varsa içerigine verilen bilgileri ekler.
            File.AppendAllText("C://Users//sedan//Desktop//deneme.txt.txt", " dünya");

            //satır satır okuma
            using (StreamReader sr = File.OpenText("C://Users//sedan//Desktop//deneme.txt.txt")) { 
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }*/


            /*--------------------------KLAORLERLE CALISMA------------------------------------
            //klasor oluşturma
            Directory.CreateDirectory("C://Users//sedan//Desktop//deneme");
            Directory.CreateDirectory("C://Users//sedan//Desktop//deneme/deneme2");
            //Directory.CreateDirectory("C://Users//sedan//Desktop//deneme/deneme3");

            //klasor silme
            if (Directory.Exists("C://Users//sedan//Desktop//deneme/deneme3"))
            {
                Directory.Delete("C://Users//sedan//Desktop//deneme/deneme3");
            }
            else
            {
                Console.WriteLine("silmek istediginiz klasor yok");
            }

            //klasor yolu alma
            string path = @"C://Users//sedan//Desktop//deneme/deneme3";//windows ta dosya yolu bu sekilde verilir
            string path2 = Directory.GetCurrentDirectory();//projenin oldugu klasoru verir
            Console.WriteLine(path2);*/


            /*--------------------------DOSYA VE KLAORLERLE CALISMA------------------------------------*/
            //string rootPath= Directory.GetCurrentDirectory();
            string rootPath = @"C://Users//sedan//source//repos//ConsoleAppProject//FileManagement//FileManagement";

            //string[] dirs= Directory.GetDirectories(rootPath,"*",SearchOption.TopDirectoryOnly);//klasorlere ulasmak icin
            //foreach (var dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            string source_path = "C:\\Users\\sedan\\Desktop\\deneme";//dosya yolu
            string dest_path = "C:\\Users\\sedan\\Desktop\\deneme\\deneme2\\";//ilk klasordekilerin kopyalanacagı klasor yolu
            string[] files = Directory.GetFiles(source_path, "*",SearchOption.AllDirectories);//"*.txt" yazılırsa txt dosyaları gelir
            foreach (string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine(Path.GetExtension(file));

                var info=new FileInfo(file);                
                Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} ");//dosyanın bllekte kapladıgı alan

                if (!Directory.Exists(dest_path))//klasor yoksa oluşturur
                {
                    Directory.CreateDirectory(dest_path);
                }

                string name=Path.GetRandomFileName()+Path.GetExtension(file);//kopyalanacak dosyaya random isim atanır
                File.Copy(file, $"{dest_path}{Path.GetFileName(name)}");//dosya dest_path'e kopyalanır
            }


            Console.ReadKey();

        }
    }
}
