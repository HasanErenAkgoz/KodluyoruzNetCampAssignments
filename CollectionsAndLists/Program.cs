using System;
using System.Collections.Generic;
namespace CollectionsAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // using System.Collections.Generic;
            // T=> object türündedir.

            List<int> sayıListesi = new List<int>();
            sayıListesi.Add(23);
            sayıListesi.Add(4);
            sayıListesi.Add(5);
            sayıListesi.Add(22);
            sayıListesi.Add(92);
            sayıListesi.Add(34);

            List<String> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Siyah");
            renkListesi.Add("Sarı");
            renkListesi.Add("Beyaz");

            System.Console.WriteLine("Renk listesi içinde bulunan eleman sayısı: " + renkListesi.Count); //Liste İçerisinde bulunan eleman sayısı

            foreach (var item in sayıListesi)
            {
                System.Console.WriteLine(item); // Sayı listesinin elemanını yazdırıyoruz.
            }

            sayıListesi.ForEach(sayı => System.Console.WriteLine(sayı));
            System.Console.WriteLine("*******************************");
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));

            // Listeden Eleman Çıkarma
            sayıListesi.Remove(4); 
            renkListesi.Remove("Yeşil");

            sayıListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            if(sayıListesi.Contains(10)){
                System.Console.WriteLine("10 liste içerisinde bulundu");
            }
            //Eleman ile indexe erişme

           System.Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

           //Diziyi Listeye Çevirme

           string[] hayvanlar={"Köpek","Kedi","Balık","Kuş","Ayı","Yılan","Dinazor"};
           List<string> hayvanListesi=new List<string>(hayvanlar);

           //Listeyi Temizleme
           hayvanListesi.Clear();

            List<kullanıcılar> kullanıcıListesi=new List<kullanıcılar>();
            kullanıcılar kullanıcılar=new kullanıcılar();
            kullanıcılar.Name="Hasan Eren";
            kullanıcılar.Surname="Akgöz";
            kullanıcılar.Age=20;

             

        }
    }
    public class kullanıcılar{
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


    }
}
