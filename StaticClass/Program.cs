using System;

namespace StaticClass
{
   class Ogrenci
{
    public static int OgrenciSayisi = 0;
    public string Isim;
    public string Soyisim;
    public Ogrenci()
    {
        OgrenciSayisi++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Static sınıf üyesine erişim
        Console.WriteLine("Öğrenci sayısı: {0}",Ogrenci.OgrenciSayisi);

        //Static olmayan sinif üyesine erişim
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim = "Deniz";
        ogrenci1.Soyisim = "Arda";
        
        Ogrenci ogrenci2 = new Ogrenci();
        ogrenci2.Isim = "Ayşe";
        ogrenci2.Soyisim = "Yılmaz";

        Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.OgrenciSayisi);
    }
}
}
