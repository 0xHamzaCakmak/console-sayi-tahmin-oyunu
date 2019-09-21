using System;

namespace Sayı_tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random r = new Random();
            hafiza = r.Next(1, 1000);
            Console.WriteLine("Sayı Tahmin oyununa HoşGeldiniz...Başlamak İçin Enter a basınız");
            Console.ReadLine();
            Console.WriteLine("Sayı Tahmininizi Giriniz: ");
            while (tahmin != hafiza)
            {
                sayac++;
                
                tahmin= Convert.ToInt32(Console.ReadLine());
                if(tahmin > hafiza)
                {
                    Console.WriteLine("Daha Küçük Sayı Gir ");
                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha Büyük Sayı Gir ");
                }
            }
            Console.WriteLine("TEBRİKLERRRRR");
            Console.WriteLine();
            Console.WriteLine("{0}. Denemede Buldunuz ", sayac);
            Console.Read();
        }
    }
}
