using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Aykut";
            musteri1.Soyad = "Öztürk";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Yaşar";
            musteri2.Soyad = "Kemal";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.WriteLine("----------------------------------------");

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("----------------------------------------");

            musteriManager.Guncelle(musteri1);
            musteriManager.Guncelle(musteri2);
            Console.WriteLine("----------------------------------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
