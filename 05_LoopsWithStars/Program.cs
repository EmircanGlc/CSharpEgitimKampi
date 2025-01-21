using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 adet yıldız oluşturma.

            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion



            #region Alt alta 10 yıldız her satrda 10 adet yıldız.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*********");
            //}
            #endregion


            #region Dik üçgen
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("*");
                }
            }

            #endregion
            Console.Read();
            
        }
    }
}
