using System;
namespace mutlak_kare
{
    class Program
    {
        static void Main(string[] args)
        {  double kucukler=0;
           double buyukler=0;
            Console.WriteLine("Kaç sayı gireceksin?");
            int n=Convert.ToInt32(Console.ReadLine());
            double[] sayilar=new double[n];
            for(int i=0;i<n;i++)
            {   Console.WriteLine("Lütfen {0}. sayıyı gir.",(i+1));
                sayilar[i]=Convert.ToDouble(Console.ReadLine());

            }
        for(int j=0;j<n;j++)
        {
            if(sayilar[j]<67)
            {
                kucukler+=67-sayilar[j];
            
            }
         else if(sayilar[j]>67)
         {
            buyukler+=Math.Pow((sayilar[j]-67),2);
         }
         else
         {
            Console.WriteLine("0");
         }
        
        }
        Console.WriteLine("Küçüklerin Farklarının Toplamı:{0} ve Büyüklerin Farklarının Karelerinin Toplamı:{1}",kucukler,buyukler);
        
        }
    }
}