using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi={23,12,4,5,7,19,30};

            System.Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayiDizisi,2,2);
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("*** Array IndexOf ***");
            System.Console.WriteLine(Array.IndexOf(sayiDizisi,3));
        }
    }
}
