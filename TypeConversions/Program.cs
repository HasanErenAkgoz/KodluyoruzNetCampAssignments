using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
           // Implicity Conversion => Bilinçsiz Dönüşüm 
           byte a=5;
           sbyte b=30;
           short c=10;

           int d=a+b+c;
           System.Console.WriteLine("d: "+d);

           long h=d;
           float i=h;
           System.Console.WriteLine("i: "+i);

           string e="zikriye";
           char f='k';
           object g=e+f;
           System.Console.WriteLine(g);

           


           // Explicit Conversion  => Bilinçli Dönüşüm
        }
    }
}
