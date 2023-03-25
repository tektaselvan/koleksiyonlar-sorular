using System;
using System.Collections;

namespace koleksiyonlar_soru_iki
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] sayiDizisi = new int[20];
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayiDizisi);
            Console.WriteLine("***** En Küçük 3 Sayı");
            Console.WriteLine(sayiDizisi[0]);
            Console.WriteLine(sayiDizisi[1]);
            Console.WriteLine(sayiDizisi[2]);

            Console.WriteLine("***** En Büyük 3 Sayı");
            Console.WriteLine(sayiDizisi[19]);
            Console.WriteLine(sayiDizisi[18]);
            Console.WriteLine(sayiDizisi[17]);

            int ort1, ort2;
            ort1 = (sayiDizisi[0] + sayiDizisi[1] + sayiDizisi[2]) / 2;
            ort2 = (sayiDizisi[19] + sayiDizisi[18] + sayiDizisi[17]) / 2;

            Console.WriteLine("***** Birinci Grup  Ortalaması *****");
            Console.WriteLine(ort1);
            Console.WriteLine("***** İkinci Grup  Ortalaması *****");
            Console.WriteLine(ort2);
            Console.WriteLine("***** İki Grubun Ortalaması *****");
            Console.WriteLine(ort1 + ort2);
        }
    }
}

