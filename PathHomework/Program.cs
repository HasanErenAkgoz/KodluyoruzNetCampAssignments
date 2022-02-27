using System;

namespace PathHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //   CiftSayıBulma();
            //   Algoritma2();
            //   Algoritma3();

        }
        public static void CiftSayıBulma()
        {

            Console.WriteLine("--------------- Çift Sayı Bulma Uygulamasına Hoş Geldiniz ---------------");
            Console.Write("Pozitif sayı adedi giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı Giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    Console.WriteLine(sayiDizisi[i]);
                }
            }

        }
        

        public static void Algoritma2()
        {

            int n, m;
            System.Console.Write("Lütfen 1. pozitif sayıyı giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Lütfen 2. pozitif sayıyı giriniz:");
            m = Convert.ToInt32(Console.ReadLine());
            int[] sayıDizisi = new int[n];

            for (int i = 0; i < sayıDizisi.Length; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı Giriniz:", i + 1);
                sayıDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in sayıDizisi)
            {
                if (item % m == 0 || item == m)
                {
                    System.Console.WriteLine(item);
                }
                else
                {
                    System.Console.WriteLine("Dizi içerisinde belirttiğin koşula uyan değer yok ");
                }
            }
      ;








        }

        public static void Algoritma3()
        {

            int sayı;
            System.Console.Write("Lütfen pozitif bir sayı giriniz:");
            sayı = Convert.ToInt32(Console.ReadLine()); ;
            if (sayı >= 0)
            {
                string[] dizi = new string[sayı];
                for (int i = 0; i < dizi.Length; i++)
                {
                    System.Console.Write("Lütfen {0}. Kelimeyi Girin:", i + 1);
                    dizi[i] = Convert.ToString(Console.ReadLine());
                }
                int son=dizi.Length-1;
                for (int i = son; i >= 0; --i)
                {
                    Console.WriteLine(dizi[i]);
                }

            }
        }


        public static void Algoritma4(){
            
             Console.WriteLine("Bir Cümle Giriniz ");
            string cumle = Convert.ToString(Console.ReadLine());
            string[] kelimeler = cumle.Split(" ");
            char[] harfler = cumle.ToCharArray();

            int harfSayisi = 0;

            Console.WriteLine("Verilen Cümlede {0} Kelime Vardır.",kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                 char[] harfdizi = kelimeler[i].ToCharArray();
                harfSayisi += harfdizi.Length;
            }
            System.Console.WriteLine("Verilen Cümlede {0} Harf Vardır.",harfSayisi);

        }
    }
}

