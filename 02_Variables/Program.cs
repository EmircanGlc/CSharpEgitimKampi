using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            #region Double Değişkenler
            //Console.WriteLine("***Fiyat Listesi***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-----Elma Birim Fİyatı----- "+ applePrice + "TL");
            //Console.WriteLine("-----Portakal Birim Fİyatı-----"+ orangePrice+ "TL");
            //Console.WriteLine("-----Çilek Birim Fİyatı-----"+ strawberryPrice+ "TL");
            //Console.WriteLine("-----Patates Birim Fİyatı-----"+ potatoPrice+ "TL");
            //Console.WriteLine("-----Domates Birim Fİyatı-----"+ tomatoPrice+ "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 2.650;
            //potatoGram = 2.650;
            //tomatoGram = 2.650;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma-"+ "Birim Fiyat:"+ applePrice + "-Gramaj:"+ appleGram + "Toplam Tutar:" + appleTotalPrice + " TL" );
            //Console.WriteLine("Alınan Ürün: Portakal-"+ "Birim Fiyat:"+ orangePrice + "-Gramaj:"+ orangeGram + "Toplam Tutar:" + orangeTotalPrice + " TL" ); 
            //Console.WriteLine("Alınan Ürün: Çilek-"+ "Birim Fiyat:"+ strawberryPrice + "-Gramaj:"+ strawberryGram + "Toplam Tutar:" + strawberryTotalPrice + " TL" );
            //Console.WriteLine("Alınan Ürün: Patates-"+ "Birim Fiyat:"+ potatoPrice + "-Gramaj:"+ potatoGram + "Toplam Tutar:" + potatoTotalPrice + " TL" );
            //Console.WriteLine("Alınan Ürün: Domates-"+ "Birim Fiyat:"+ tomatoPrice + "-Gramaj:"+ tomatoGram + "Toplam Tutar:" + tomatoTotalPrice + " TL" );

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı:" + shoppingTotalPrice + " " + "TL");
            #endregion

            #region Char Değişkenler

            //ABCDEFG
            //DEF...
            //" '
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGirişleri String Değişkenler
            //Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();

            //string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("T.c Kimlik no:");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();




            //Console.WriteLine("--------");
            //Console.Write("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " /" + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);

            //Console.WriteLine();
            #endregion

            #region Klavyeden Tam sayı Girişleri ve Dönüşümler

            //ABC12D
            // int shoesPrice,computerPrice, chairPrice,tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount,tvCount;

            //Console.Write("Lütfen alıdığınız ayakkabı sayısını giriniz.");
            //shoesCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz.");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz.");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz.");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice+ tvCount*tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Ödemeniz Gereken Toplam Tutar: " + totalPrice + " TL");

            //double odenen, paraüstü;

            //odenen = 1200.50;

            //paraüstü = totalPrice - odenen;

            //Console.WriteLine("Paraüstü: " + paraüstü + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu  giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            //if (result >= 50)
            //{
            //    Console.WriteLine("Tebrikler.Dersten Geçtiniz...");
            //}
            //else
            //{
            //    Console.WriteLine("Ne yazık ki dersten kaldınız...");
            //}


            #endregion

            #region Klavyeden karakter girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion



            Console.Read();
        }
    }
}
