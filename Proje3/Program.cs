using System;
using System.Collections;

namespace Proje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden giriler metininin içindeki sesli harfleri bulan program
            ArrayList sesli = new ArrayList();
            Console.Write("Lütfen bir metin giriniz: ");
            char[] metin =(Console.ReadLine()).ToCharArray();
            
                 foreach (char item in metin)
                 {
                     if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü' || item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                     {
                         sesli.Add(item);
                     }
                 }

            sesli.Sort();
                foreach (var item in sesli)
                {
                    Console.WriteLine(item);
                }

                for (int i = 0; i < metin.Length; i++)
                {
                    foreach (var item in metin)
                    {
                        if (item == i)
                        {
                            sesli.Add(item);
                        }
                    }
                }
                sesli.Sort();
                foreach (var item in sesli)
                {
                    Console.WriteLine(item);
                }


         Console.ReadKey();


        }
    }
}