using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //Değişken Türü
            //Değişken Adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //Dizideki değerleri yazdırma

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33,41,205,6578,10394};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)  //Liste içerisinden bir number al ve 2 'ye tam bölünebiliyorsa ekrana yazdır.
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Bir kelimeyi harflerine ayıran örnek.

            //string word = "Merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #region  Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("******C# Eğitim Kampı Sınav Uygulması********");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------");

            Console.Write("Sınıfınızda kaç öğrenci var:");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount]; //Öğrenci isimlerinin boyutunu öğrenci adetinden al.
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++) 
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value =double.Parse(Console.ReadLine());
                    totalExamResult+= value; //notları topla.

                }

                studentExamAvg[i]= totalExamResult / 3; //studentexamAvg 'ın i'ninci değeri totalExamResult dan gelen değerin 3 e bölümüne eşittir.
            }
            //Öğrencilerin ort.sonuçları ve geçip kalma durumunu görelim.
            for (int i = 0; i <studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti...");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı...");
                }
            }

           


            #endregion


            Console.Read();

        }
    }
}
