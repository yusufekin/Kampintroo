using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            girisEkrani();
        }

        static void girisEkrani()
        {
            string kayitSistemi =
@"[B]======================[KAYIT SİSTEMİ]=====================[-][o][x]
|                                                                    |
|                Kayıt Sistemine Hoşgeldiniz!                        |
|                                                                    |
|                   Müşteri Eklemek İçin       (1)                   |
|                   Müşteri Silmek İçin        (2)                   |
|              Müşterileri Görüntülemek İçin   (3)                   |
|                        Çıkış                 (4)                   |
|                                                                    |
|====================================================================|";

            Console.WriteLine(kayitSistemi);
            Console.WriteLine();

            int secim = girisKontrol();

            secimSonuc(secim);
        }
        static int girisKontrol()
        {
            char secim;

            do
            {
                Console.Write("Giriniz --> ");
                secim = Console.ReadKey().KeyChar;

                if (49 <= secim && secim <= 52)
                {
                    Console.WriteLine();
                    return Convert.ToInt32(secim.ToString());
                }
                else
                {
                    Console.WriteLine();
                }
            } while (true);
        }

        static void secimSonuc(int secim)
        {
            MusteriManager musteriManager = new MusteriManager();

            switch (secim)
            {
                case 1:
                    Console.WriteLine();
                    Musteri musteri = new Musteri();
                    musteriManager.MusteriEkle(musteri);
                    cikisKontrol();
                    break;
                case 2:
                    Console.WriteLine();
                    musteriManager.MusteriSil();
                    cikisKontrol();
                    break;
                case 3:
                    Console.WriteLine();
                    musteriManager.MusteriListele();
                    cikisKontrol();
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                default:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
            }
        }

        static void cikisKontrol()
        {
            Console.WriteLine();
            Console.Write("Giris Ekranı için (1)\nÇıkış için (2)\n\ngiriniz --> ");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Console.WriteLine();
                girisEkrani();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Çıkış yapılıyor...");
            }
        }
    }
}
