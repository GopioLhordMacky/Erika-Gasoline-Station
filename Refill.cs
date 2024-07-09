using System;
using System.Security.Cryptography.X509Certificates;
namespace Refill
{
    internal class Refill
    {
        public static void wow(string[] args)
       
        {
            Console.WriteLine("What gas type do you want to check?: ");
            Console.WriteLine("1. Diesel");
            Console.WriteLine("2. Premium");
            Console.WriteLine("3. Gasoline");
            Console.WriteLine("4. Unleaded");
            Console.WriteLine("5. Kerosene");
            Console.WriteLine("6. Petrol");
            int gas = Convert.ToInt32(Console.ReadLine());
            int amount = Convert.ToInt32(Console.ReadLine()); ;
            switch (gas)
            {
                case 1:
                    double DieselMarketPrice = 54.06;
                    List<int> DieselGasEarned = new List<int>();
                    DieselGasEarned.Add(amount);
                    double DieselEarned = 0;
                    foreach (var DieselEarning in DieselGasEarned)
                    {
                        DieselEarned += DieselEarning;
                    }
                    double DieselTotalEarnings = DieselEarned / DieselMarketPrice;
                    Console.WriteLine($"Your total earning for Diesel is {DieselEarned}.");
                    Console.Write("/nHow much Diesel do you want to refill?: ");
                    double DieselRefill = Convert.ToInt32(Console.ReadLine());
                    double RefillLiter = DieselRefill / DieselMarketPrice;
                    Console.WriteLine($"You can refill {RefillLiter} liters of Diesel");
                    break;
                case 2:   
                    
                    double PremiumMarketPrice = 59.06;
                    List<int> PremiumGasEarned = new List<int>(); 
                   amount = Convert.ToInt32(Console.ReadLine());
                   PremiumGasEarned.Add(amount);
                    double PremiumEarned = 0;
                    foreach (var PremiumEarning in PremiumGasEarned)
                    {
                        PremiumEarned += PremiumEarning;
                    }
                    Console.WriteLine($"Your total earning for Diesel is {PremiumEarned}.");
                    Console.Write("/nHow much Diesel do you want to refill?: ");
                    double PremiumRefill = Convert.ToInt32(Console.ReadLine());
                    double PremiumLiter = PremiumRefill / PremiumMarketPrice;
                    Console.WriteLine($"You can refill {PremiumLiter} liters of Diesel");
                    break;
                case 3:
                    double GasolineMarketPrice = 58.05;
                    List<int> GasolineGasEarned = new List<int>();
                     Console.Write("How much?: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    GasolineGasEarned.Add(amount);
                    double GasolineEarned = 0;
                    foreach (var GasolineEarning in GasolineGasEarned)
                    {
                        GasolineEarned += GasolineEarning;
                    }
                    Console.WriteLine($"Your total earning for Diesel is {GasolineEarned}.");
                    Console.Write("/nHow much Diesel do you want to refill?: ");
                    double GasolineRefill = Convert.ToInt32(Console.ReadLine());
                    double GasolineLiter = GasolineRefill / GasolineMarketPrice;
                    Console.WriteLine($"You can refill {GasolineLiter} liters of Diesel");
                    break;
                case 4:
                    double KeroseneMarketPrice = 58.05;
                    List<int> KeroseneGasEarned = new List<int>();
                    amount = Convert.ToInt32(Console.ReadLine());
                      KeroseneGasEarned.Add(amount);
                    double KeroseneEarned = 0;
                    foreach (var KeroseneEarning in KeroseneGasEarned)
                    {
                        KeroseneEarned += KeroseneEarning;
                    }
                    Console.WriteLine($"Your total earning for Diesel is {KeroseneEarned}.");
                    Console.Write("/nHow much Diesel do you want to refill?: ");
                    double KeroseneRefill = Convert.ToInt32(Console.ReadLine());
                    double KeroseneLiter = KeroseneRefill / KeroseneMarketPrice;
                    Console.WriteLine($"You can refill {KeroseneLiter} liters of Diesel");
                    break;
                case 5:
                    double UnleadedMarketPrice = 59.06;
                    List<int> UnleadedGasEarned = new List<int>();
                     amount = Convert.ToInt32(Console.ReadLine());
                     UnleadedGasEarned.Add(amount);
                    double UnleadedEarned = 0;
                    foreach (var UnleadedEarning in UnleadedGasEarned)
                    {
                        UnleadedEarned += UnleadedEarning;
                    }
                    Console.WriteLine($"Your total earning for Diesel is {UnleadedEarned}.");
                    Console.Write("/nHow much Diesel do you want to refill?: ");
                    double UnleadedRefill = Convert.ToInt32(Console.ReadLine());
                    double UnleadedLiter = UnleadedRefill / UnleadedMarketPrice;
                    Console.WriteLine($"You can refill {UnleadedLiter} liters of Diesel");
                    break;
                case 6:
                    double PetrolMarketPrice = 54.06;
                    List<int> PetrolGasEarned = new List<int>();
                    amount = Convert.ToInt32(Console.ReadLine());
                   PetrolGasEarned.Add(amount);
                    double PetrolEarned = 0;
                    foreach (var PetrolEarning in PetrolGasEarned)
                    {
                        PetrolEarned += PetrolEarning;
                    }
                    Console.WriteLine($"Your total earning for Diesel is {PetrolEarned}.");
                    Console.Write("/nHow much Diesel do you want to refill?: ");
                    double PetrolRefill = Convert.ToInt32(Console.ReadLine());
                    double PetrolLiter = PetrolRefill / PetrolMarketPrice;
                    Console.WriteLine($"You can refill {PetrolLiter} liters of Diesel");
                    break;
            }
       }   
    }
}
  