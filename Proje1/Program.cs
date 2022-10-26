using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.

                //     - Negatif ve numeric olmayan girişleri engelleyin.
                //     - Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                //     - Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            Console.WriteLine(" ");
            Console.WriteLine("LÜTFEN SADECE SAYISAL DEĞERLER GİRİNİZ GİRMEMENİZ HALİNDE PROGRAM DURDURULACAKTIR.!!!!!");
            
            ArrayList asal = new ArrayList();
            ArrayList asaldegil = new ArrayList();
            
            int asalsayılartoplam = 0;
            int asalolmayantoplam = 0;
            for (int i = 0; i < 20; i++)
            {
             
                int kontrol = 0;
                Console.Write("{0}. Sayıyı Giriniz :", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());

                    for (int y = 2; y < sayi; y++)
                        {
                            if (sayi % y == 0)
                                kontrol++;
                        }

                        if (kontrol != 0)
                        {
                            asaldegil.Add(sayi);
                            asalolmayantoplam += sayi;
                        }
                        else
                        {
                        
                            asal.Add(sayi);
                            asalsayılartoplam +=sayi;
                        }
            }


            asal.Sort();
            Console.WriteLine("Asal olanların eleman sayısı: "+ asal.Count);
                foreach (var item in asal)
                {
                    Console.WriteLine(item);
                }
            Console.WriteLine("Asal olan sayıların ortalaması: " + asalsayılartoplam / asal.Count );


            asaldegil.Sort();
            Console.WriteLine("Asal olmayan eleman sayısı: "+ asaldegil.Count);
           
                foreach (var item in asaldegil)
                {
                    Console.WriteLine(item);
                }
            Console.WriteLine("Asal olmayan sayıların ortalaması: "+ asaldegil.Count);
            }
            catch 
            {
                return;
            }
        Console.ReadKey();
        }

    }
}