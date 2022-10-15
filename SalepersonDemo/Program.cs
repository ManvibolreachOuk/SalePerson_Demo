using System;

namespace SalepersonDemo_Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateSalesperson resp = new RealEstateSalesperson("Reach", "Vibol");
            resp.SalesSpeech();
            resp.MakeSale(300000);
            resp.MakeSale(350000);
            resp.MakeSale(400000);
            Console.WriteLine("Total value of houses sold = ${0:N0}", resp.TotalValueSold);
            Console.WriteLine("Total commission earned {0}% = ${1:N2}", RealEstateSalesperson.CommissionRate, resp.TotalCommissionEarned);
            Console.WriteLine($"------------------------------------------------------------");
            GirlScout gs = new GirlScout("Reach", "Vibol");
            gs.SalesSpeech();
            gs.MakeSale(5);
            gs.MakeSale(10);
            gs.MakeSale(20);
            Console.WriteLine("Total number of boxes of cookies sold = ${0:N0}", gs.BoxesOfCookiesSold);
            Console.ReadKey();
        }
    
    }
}
