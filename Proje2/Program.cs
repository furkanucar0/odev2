using System;
using System.Collections;

namespace Proje2
{
    internal class Program
    {
        
        //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
        //Her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)


        static void Main(string[] args)
        {
            
            ArrayList degerler = new ArrayList();
            int kucuksayılartoplam = 0;
            int buyuksayılartoplam = 0;
                for (int i = 0; i < 20; i++)
                    {
                        Console.Write("{0}. Değeri giriniz: ", i+1);
                        int sayi = Convert.ToInt32(Console.ReadLine());

                        degerler.Add(sayi);
                        
                    }
            System.Console.WriteLine("--------------");

            degerler.Sort();
            ArrayList kucukler = new ArrayList();
                for (int i = 0; i <= 2; i++)
                {
                    int y =Convert.ToInt32(degerler[i]);
                    kucukler.Add(y);
                    kucuksayılartoplam += i+1;
                    
                }
                    foreach (var item in kucukler)
                    {
                        Console.WriteLine(item);
                    }
            
            System.Console.WriteLine("--------");

            ArrayList buyukler = new ArrayList();
                for (int i = 17; i <= 19; i++)
                {
                    int x =Convert.ToInt32(degerler[i]);
                    buyukler.Add(x);
                    buyuksayılartoplam += i+1;
                    
                }
                    foreach (var item in buyukler)
                    {
                        Console.WriteLine(item);
                    }
            var buyuksayılarort = (buyuksayılartoplam/3);
            var kucuksayılarort = (kucuksayılartoplam/3);
            Console.WriteLine("Küçük sayıların ortalaması: " +  kucuksayılarort);
            Console.WriteLine("Büyük sayıların ortalaması: " + buyuksayılarort);
            Console.WriteLine("Ortalamaların toplamı: " + (kucuksayılarort + buyuksayılarort));

        Console.ReadKey();
        }
    }
}
