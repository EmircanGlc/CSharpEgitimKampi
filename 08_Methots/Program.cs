using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methots
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer--->Listele,Ekle,Sil,Güncelle
            //Void ise geriye değer döndürmez.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}


            //Sum();
            //Console.Read();


            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surName);
            //}


            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül","Kaya");

            #endregion


            #region Geriye değer döndürmeyen int parametreli metotlar


            //void Sum(int number1, int number2,int number3) 
            //{

            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(4, 5, 6);




            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Emircan Güleç";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kılıç";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String  Parametreli Metotlar

            string CountryCard(string countryName,string capital,string flagColor) 
            {
                string cardInfo ="Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi:  " + flagColor;
                return cardInfo;
            }

            string x, y, z;
            Console.Write("Ülke Adını Giriniz: ");
            x = Console.ReadLine();

            Console.Write("Başkenti Giriniz: ");
            y = Console.ReadLine();

            Console.Write("Bayrak Rengini Giriniz: ");
            z = Console.ReadLine();

            if (x == "Türkiye")
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Şanlı ve Yüce Türk Bayrağına ve Şehitlerine Selam Olsun...");
                Console.WriteLine("******************************");
            }

            Console.WriteLine();
            Console.WriteLine();
            
           
            Console.WriteLine(CountryCard(x,y,z));
            

            

            #endregion
            Console.Read();
        }
    }
}
