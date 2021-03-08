using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plateNo = new MyDictionary<int, string>();
            plateNo.Add(01, "Adana");
            plateNo.Add(02, "Adıyaman");
            plateNo.Add(03, "Afyon");
            plateNo.Add(04, "Ağrı");
            plateNo.Add(05, "Amasya");
            Console.WriteLine(plateNo.Length);
            plateNo.Add(06, "Ankara");
            plateNo.Add(07, "Antalya");
            plateNo.Add(08, "Artvin");
            plateNo.Add(09, "Aydın");
            plateNo.Add(10, "Balıkesir");
            Console.WriteLine(plateNo.Length);
            plateNo.ToList();
        }
    }
}
