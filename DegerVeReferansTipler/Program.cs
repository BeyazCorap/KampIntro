using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 24;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 30, 60 };
            int[] sayilar2 = new int[] { 100, 300, 600 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999

            //int,decimal,double,float,bool : tip , deger
            //class,array,interface : reference 
        }
    }
}
