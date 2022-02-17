using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;
            sbyte c = 5;

            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2;
            long l = 4;
            ulong ul = 4;

            float f = 5;
            double d = 5.3;
            decimal de = 5;

            char ch = '2';
            string str = "2ikriye";

            bool b1 = true;
            bool b2 = false;

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            object o1 = "x";
            object o2 = '2';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "Hasan Eren Akgöz";
            string ad = "Hasan Eren";
            string soyad = "Akgöz";
            string tamisim = ad + " " + soyad;

            int integar1 = 5;
            int integer2 = 3;
            int integer3 = integar1 * integer2;

            //boolen

            bool bool1 = 10 > 2;

            string str20 = "20";
            int int20 = 20;


            string yeniDeger = str20 + int20.ToString();

            System.Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(date);

            string date2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(date2);

            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(date);


            bool degisken = false;
            bool degisken1 = true;

          
            


            Console.WriteLine(degisken);
        }
    }
}
