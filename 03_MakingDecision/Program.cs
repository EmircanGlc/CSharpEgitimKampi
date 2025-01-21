using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler doğrulanamadı.Tekrar deneyiniz...");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata";


            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average>0 & average < 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average>50 & average <=70)
            //{
            //    result = "Sonuç ortalama";
            //}
            //if (average>70 & average <=84)
            //{
            //    result = "Sonuç  iyi";
            //}
            //if (average>84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);
            //Console.Read();



            //string city;
            //Console.WriteLine("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city =="ankara" | city == "bursa" | city ==" trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}



            //Console.WriteLine("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}







            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz : ");
            //int number2 =int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.Sayının 2.sayıya bölümünden kalan : " + result);






            #endregion

            #region switch case

            //Console.Write("Lütfen Ay girişi yapınız: ");
            //int monthnumber = int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;  
            //    case 3:Console.Write("Mart"); break;  
            //    case 4:Console.Write("Nisan"); break;  
            //    case 5:Console.Write("Mayıs"); break;  
            //    case 6:Console.Write("Haziran"); break;  
            //    case 7:Console.Write("Temmuz"); break;  
            //    case 8:Console.Write("Ağustos"); break;  
            //    case 9:Console.Write("Eylül"); break;  
            //    case 10:Console.Write("Ekim"); break;  
            //    case 11:Console.Write("Kasım"); break;  
            //    case 12:Console.Write("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;

            //}



            #endregion


            #region Switch Case Hesap Makinesi
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);                
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //     case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    default: Console.WriteLine("Hata: Lütfen işlem operatörlerinden birini giriniz.");break;
            //}




            #endregion
           

            Console.Read();

        }
    }
}
