using System;

namespace diziler
{
    class Program
    {
        static void Main(String[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "ayı", "maymun" };
            int[] dizi;
            dizi = new int[5];

            //Dizilerde Değer Atama
            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngüler dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplama

            System.Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int dizi_uzunluğu = int.Parse(Console.ReadLine());
            int[] sayi_dizisi = new int[dizi_uzunluğu];

            for (int i = 0; i < dizi_uzunluğu; i++)
            {
                System.Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayi_dizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayi_dizisi)
                toplam += sayi;

            System.Console.WriteLine("Ortalama : " + toplam/dizi_uzunluğu);
        }

    }
}
