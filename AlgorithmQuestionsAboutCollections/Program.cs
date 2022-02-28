using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcOdev
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Ödev Projesine Hoşgeldiniz...");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Ödev Listesi: ");
        Console.WriteLine("1. Ödev : 1 ");
        Console.WriteLine("2. Ödev : 2 ");
        Console.WriteLine("3. Ödev : 3 ");
        Console.WriteLine("Çıkmak için : X ");
        while (true)
        {
            Console.Write("Seçiminizi giriniz: ");
            string secim = Console.ReadLine();
            switch (secim.ToUpper())
            {
                case "1":
                    Console.WriteLine("Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.) 1-) Negatif ve numeric olmayan girişleri engelleyin. 2-) Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın. 3-)Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.");
                    AsalorNot();
                    break;
                case "2":
                    Console.WriteLine("Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)");
                    EnBuyukEnKucuk();
                    break;
                case "3":
                    Console.WriteLine("Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.");
                    SesliSessiz();
                    break;
                case "X":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
        static void AsalorNot()
        {
            int sayac = 1;
            List<int> AsalOlan = new List<int>();
                List<int> AsalOlmayan = new List<int>();
            do
            {       
                int sayi = SayiAl("Sayı giriniz: ");
                sayac++;
                if(sayi < 0)
                {
                    sayac--;
                    Console.WriteLine("Negatif girdiniz.Tekrar deneyin.");
                }
                int kontrol = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol=1;
                    }  
                }
                if (kontrol ==1)
                    {
                        AsalOlmayan.Add(sayi);
                    } else AsalOlan.Add(sayi);
            } while (sayac < 21);
            AsalOlan.Sort();
            AsalOlmayan.Sort();
            AsalOlan.Reverse();
            AsalOlmayan.Reverse();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Asal olan sayılar büyükten küçüğe:");
            foreach (var item in AsalOlan)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine("Asal olmayan sayılar büyükten küçüğe:");
            foreach (var item in AsalOlmayan)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine("Asal olan eleman sayısı: " + AsalOlan.Count);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Asal olmayan eleman sayısı: " + AsalOlmayan.Count);
            int asalToplam = 0;
            foreach (var item in AsalOlan)
            {
                asalToplam+= item;
            }
            int asalOlmayanToplam =0;
            foreach (var item in AsalOlan)
            {
                asalOlmayanToplam+= item;
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Asal olan sayıların ortalaması: " + (asalToplam/AsalOlan.Count));
            Console.WriteLine("Asal olmayanan sayıların ortalaması: " + (asalOlmayanToplam/AsalOlmayan.Count));
        }
        static int SayiAl(string mesaj)
        {
            int result;
            while (true)
            {
                Console.Write(mesaj);
                if (!int.TryParse(Console.ReadLine(), out result) || result < 0)
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                else
                    break;
            }
            return result;
        }
        static void EnBuyukEnKucuk()
        {
            List<int> Karisik = new List<int>();
            int sayac = 0;
            do
            {
                int sayi = SayiAl("Sayı giriniz: ");
                Karisik.Add(sayi);
                sayac++;
            } while (sayac < 20);
            Karisik.Sort();
            List<int> IlkUc = new List<int>(){Karisik[0],Karisik[1],Karisik[2]};
            List<int> SonUc = new List<int>(){Karisik[19],Karisik[18],Karisik[17]};
            int IlkUcToplam = 0;
            foreach (var item in IlkUc)
            {
                IlkUcToplam+= item;
            }
            int SonUcToplam = 0;
            foreach (var item in SonUc)
            {
                SonUcToplam+= item;
            }
            double IlkUcOrt = IlkUcToplam / IlkUc.Count();
            double SonUcOrt = SonUcToplam / SonUc.Count();
            double toplam = IlkUcOrt + SonUcOrt;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("İlk üç sayı: " + Karisik[0]+"-"+Karisik[1]+"-"+Karisik[2]);
            Console.WriteLine("Son üç sayı: " + Karisik[17]+"-"+Karisik[18]+"-"+Karisik[19]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("İlk üç sayının ortalaması: " + IlkUcOrt);
            Console.WriteLine("Son üç sayının ortalaması: " + SonUcOrt);
            Console.WriteLine("Bu sayıların ortalama toplamları: " + toplam);
            Console.WriteLine("---------------------------------------");

        }
        static void SesliSessiz()
        {
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            char[] sesliHarfler = new char[cumle.Length-1];
            int sayac2 = 0;
            do
            {
                foreach (char x in cumle)
                {
                    if (x == 'a' || x == 'e' || x == 'ı' || x == 'i' || x == 'o' || x == 'ö' || x == 'u' || x == 'ü')
                    {
                        sesliHarfler[sayac2] = x;
                        sayac2++;
                    } 
                        else
                        {
                            sayac2++;
                        }           
                }
            } while (sayac2 < cumle.Length);
            Console.WriteLine("------------------------------");
            Array.Sort(sesliHarfler);
            Console.WriteLine("Sesli harfleriniz: ");
            foreach (char item in sesliHarfler)
            {        
                    Console.Write(item + "-"); 
            }
        }
    }
}
