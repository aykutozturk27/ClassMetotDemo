using System;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelenen müşteri adı: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen müşteri adı: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Güncellenen müşteri adı: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen müşteri adı: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
