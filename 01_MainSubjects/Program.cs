using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            ////Console.Write("Merhaba Dünya");
            ////Console.WriteLine("Selam");
            //Console.WriteLine("****Yemek Kategorileri****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Baklavalar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            #endregion

            #region StringDeğişkenler
            //string
            //Değişken_türü değişken adı;

            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city="İstanbul";

            //Console.WriteLine("*** Rezervasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: "+ customerName + " "+customerSurname);
            //Console.WriteLine("İletişim: "+ customerPhone);
            //Console.WriteLine("Email: "+ customerEmail);
            //Console.WriteLine("Adres: "+ district + "/"+ city);






            #endregion

            #region Int Değişkenler
            //int
            int hamburgerPrice = 300;
            int cokePrice = 300;
            int waterPrice = 10;
            int friesPrice = 300;
            int pizzaPrice = 300;
            int lemonadePrice = 300;


            Console.WriteLine("****Restoran Menü Fiyatları****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("----Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("---- Kola:" + cokePrice + "TL");
            Console.WriteLine("----Su:" + waterPrice + "TL");
            Console.WriteLine("----Kızartma:" + friesPrice + "TL");
            Console.WriteLine("----Limonata:" + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("****Restoran Menü Fiyatları****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int lemonadeCount;
            int pizzaCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalLemonadePrice = 0;
            int totalPizzaPrice = 0;

            hamburgerCount = 3;
            cokeCount = 2;
            waterCount = 5;
            friesCount = 2;
            pizzaCount = 7;
            lemonadeCount = 2;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;



            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL" );
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + "TL" );
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + "TL " );
            Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + " TL" );
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + "TL " );
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL " );
            #endregion




            Console.Read();

        }
    }
}


//Yazdırma komutları
