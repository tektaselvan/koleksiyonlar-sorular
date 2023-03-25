using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_soru_bir
{
    class Program
    {
        public static bool asalmi(int sayi)
        {
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }

        static void Main(string[] args)
        {
            bool SayiMi(string text)
            {
                foreach (char chr in text)
                {
                    if (!Char.IsNumber(chr)) return false;
                }
                return true;
            }
            int toplam = 0, ortalama = 0;
            ArrayList asalSayilar = new ArrayList();
            ArrayList ciftSayilar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} Sayıyı Girin : ");

                if (SayiMi(i.ToString()) == false)
                {
                    int s = Convert.ToInt32(Console.ReadLine());
                    toplam += s;
                    if (asalmi(s))
                    {
                        asalSayilar.Add(s);
                    }
                    else
                    {
                        ciftSayilar.Add(s);
                    }

                }
                else
                {
                    Console.WriteLine("sajdkslls");
                }

            }
            ortalama = toplam / 10;
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("ASAL SAYILAR");
            foreach (int sayi in asalSayilar)
            {
                Console.Write(sayi + "    ");
            }
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            foreach (int sayi in ciftSayilar)
            {
                Console.Write(sayi + "    ");
            }


            Console.WriteLine("***** Asal Sayılar sıralama *****");
            //Sıralama
            Console.WriteLine("***** Sort *****");
            asalSayilar.Sort();

            foreach (var item in asalSayilar)
                Console.WriteLine(item);

            //Reverse
            Console.WriteLine("***** Reverse *****");
            asalSayilar.Reverse();

            foreach (var item in asalSayilar)
                Console.WriteLine(item);

            Console.WriteLine("***** Asal Olmayan Sayılar sıralama *****");
            //Sıralama
            Console.WriteLine("***** Sort *****");
            ciftSayilar.Sort();

            foreach (var item in ciftSayilar)
                Console.WriteLine(item);

            //Reverse
            Console.WriteLine("***** Reverse *****");
            asalSayilar.Reverse();

            foreach (var item in ciftSayilar)
                Console.WriteLine(item);

            Console.ReadLine();

        }
    }
}
