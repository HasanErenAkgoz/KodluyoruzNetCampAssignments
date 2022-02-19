using System;

namespace ForLoopAndBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Lütfen Bir Sayı Giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
            int tekToplam = 0;
            int çiftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
               if (i % 2 == 0)
               {
                    çiftToplam += i;
               }
               else
               tekToplam += i;
            }
            System.Console.WriteLine("Tek Toplam: "+tekToplam);
            System.Console.WriteLine("Çift Toplam: "+çiftToplam);

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                System.Console.WriteLine(i);
            }
        }
    }
}
