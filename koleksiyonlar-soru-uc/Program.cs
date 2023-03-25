using System;

namespace koleksiyonlar_soru_uc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle Giriniz: ");
            string cumle = Console.ReadLine().ToLower();
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int toplam = 0;
            foreach (char karakter in cumle)
            {
                foreach (char sesli in sesliler)
                {
                    if (karakter == sesli)
                    {
                        Console.WriteLine(sesli);
                        toplam++;
                    }
                }
            }
            Console.WriteLine("Cümlede {0} Tane Sesli Harf Vardır", toplam);
        }
    }
}
