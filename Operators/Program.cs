using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            y = y + 2;

            System.Console.WriteLine(y);
            y += 2;
            System.Console.WriteLine(y);
            y /= 1;
            System.Console.WriteLine(y);
            x += 2;
            System.Console.WriteLine(x);

            bool isSuccess = true;
            bool isCompoted = false;

            if (isSuccess && isCompoted)
                System.Console.WriteLine("Perfect!");

            if (isSuccess || isCompoted)
                System.Console.WriteLine("Great!");

            if (isSuccess && !isCompoted)
                System.Console.WriteLine("Fine!");


            int a = 2;
            int b = 4;
            bool sonuc = a < b;

            System.Console.WriteLine(sonuc);
            sonuc = a < b;
            System.Console.WriteLine(sonuc);
            sonuc = a <= b;
            System.Console.WriteLine(sonuc);
            sonuc = a >= b;
            System.Console.WriteLine(sonuc);
            sonuc = a == b;
            System.Console.WriteLine(sonuc);
            sonuc = a != b;
            System.Console.WriteLine(sonuc);

            int sayı = 10;
            int sayı2 = 5;
            int sonuc1 = sayı / sayı2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayı * sayı2;
            System.Console.WriteLine(sonuc);
            sonuc1=sayı+sayı2;
            System.Console.WriteLine(sonuc);
            sonuc1=sayı*sayı2;
            System.Console.WriteLine(sonuc);

        }
    }
}
