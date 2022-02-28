using System;
using System.Collections;
namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //birden fazla veri tipini aynı anda saklayabiliriz.
            ArrayList arrayList=new ArrayList();
            arrayList.Add("Eren");
            arrayList.Add(2);
            arrayList.Add(true);
            arrayList.Add('a');

            System.Console.WriteLine(arrayList[1]);
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item );
            }
        }
    }
}
