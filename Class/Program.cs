using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Calısan calısan1=new Calısan();
            calısan1.Name="Hasan";
            calısan1.SurName="Akgöz";
            calısan1.No=5;
            calısan1.Departman="Bilgi İşlem";
            calısan1.CalısanBİlgileri();
        }
    }
    public class Calısan
    {

        public string Name { get; set; }
        public string SurName { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public void CalısanBİlgileri()
        {
            System.Console.WriteLine("Çalışanın Adı {0}", Name);
            System.Console.WriteLine("Çalışanın Soyadı {0}", SurName);
            System.Console.WriteLine("Çalışanın Numarası {0}", No);
            System.Console.WriteLine("Çalışanın Departmanı {0}", Departman);

        }

    }
}
