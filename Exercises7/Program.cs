using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan sayinin sıfır olma durumunu if-else ile olusturun

            int sayi;

            Console.WriteLine("Lutfen bir asyi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 0)
            {
                Console.WriteLine(" Girmis oldugunuz sayi sıfır (0) ");
            }
            else if (sayi > 0)
            {
                Console.WriteLine("Girmis oldugunuz sayi pozitif ");
            }
            else
            {
                Console.WriteLine("Girmis oldugunuz sayi negatif");
            }

            Console.Read();
        }
    }
}
