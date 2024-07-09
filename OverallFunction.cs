using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erika__Gasoline_Refill_
{
    internal class OverallFunction
    {
        static void Main(string[] args)
        {
            int Start = 1;
            while (Start > 0)
            {
                Console.Write("Are you a Customer (1) or Owner (2)");
                int Input = Convert.ToInt32(Console.ReadLine());
                while (Input > 0)
                {
                    Console.Write("Enter your plate number: ");
                    int platenum = Convert.ToInt32(Console.ReadLine());
                    int amountDiesel = 0;
                    int amountPremium = 0;
                    int amountKerosene = 0;
                    int amountUnleaded = 0;
                    int amountPetrol = 0;
                    int amountGasoline = 0;

              
                    switch (Input)
                    {
                        case 1:
                            int GasLoop = 100;
                            int Stop = 0;
                            while (GasLoop > Stop)
                            {
                                Console.Write("\nGas (1) or Exit (2)");
                                int Choices = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter the number corresponding to your vehicle type: ");
                                Console.WriteLine("1. Jeepney");
                                Console.WriteLine("2. Tricycle");
                                Console.WriteLine("3. Motor");
                                Console.WriteLine("4. Car");
                                Console.WriteLine("5. Bus");
                                Console.WriteLine("6. Van");
                                Console.WriteLine("7. Truck");
                                int vehicles = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\nEnter the number corresponding to your fuel type:");
                                Console.WriteLine("1. Diesel");
                                Console.WriteLine("2. Premium");
                                Console.WriteLine("3. Gasoline");
                                Console.WriteLine("4. Unleaded");
                                Console.WriteLine("5. Kerosene");
                                Console.WriteLine("6. Petrol");
                                int fuel = Convert.ToInt32(Console.ReadLine());
                                string gastype = "";
                                double priceliter = 0;

                                switch (Choices)
                                {

                                    case 1:

                                        switch (fuel)
                                        {

                                            case 1: // Diesel
                                                Console.Write("How much?: ");
                                                amountDiesel = Convert.ToInt32(Console.ReadLine());
                                                gastype = "";
                                                priceliter = 0;
                                                double JeepneyDieselEfficiency = 13.00;
                                                double TricycleDieselEfficiency = 30.00;
                                                double MotorDieselEfficiency = 40.00;
                                                double CarDieselEfficiency = 15.00;
                                                double BusDieselEfficiency = 10.00;
                                                double VanDieselEfficiency = 18.00;
                                                double TruckDieselEfficiency = 8.00;
                                                double liters = amountDiesel / priceliter;
                                                double kl = 0;
                                                switch (vehicles)
                                                {
                                                    case 1:// Jeepney
                                                        kl = JeepneyDieselEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                                                        break;
                                                    case 2: // Tricycle
                                                        kl = TricycleDieselEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                                                        break;
                                                    case 3: // Motor
                                                        kl = MotorDieselEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                                                        break;
                                                    case 4: // Car
                                                        kl = CarDieselEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                                                        break;
                                                    case 5://Bus
                                                        kl = BusDieselEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                                                        break;
                                                    case 6: // Van 
                                                        kl = VanDieselEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                                                        break;
                                                    case 7:// Truck
                                                        kl = TruckDieselEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                                                        break;
                                                    default:
                                                        break;
                                                }

                                                break;
                                            case 2: // Premium
                                                Console.Write("How much?: ");
                                                amountPremium = Convert.ToInt32(Console.ReadLine());
                                                gastype = "";
                                                priceliter = 0;
                                                double JeepneyPremiumEfficiency = 11.00;
                                                double TricyclePremiumEfficiency = 25.00;
                                                double MotorPremiumEfficiency = 35.00;
                                                double CarPremiumEfficiency = 13.00;
                                                liters = amountPremium / priceliter;
                                                kl = 0;
                                                switch (vehicles)
                                                {
                                                    case 1:// Jeepney
                                                        kl = JeepneyPremiumEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                                                        break;
                                                    case 2: // Tricycle
                                                        kl = TricyclePremiumEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                                                        break;
                                                    case 3: // Motor
                                                        kl = MotorPremiumEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                                                        break;
                                                    case 4: // Car
                                                        kl = CarPremiumEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                                                        break;
                                                    default:
                                                        break;
                                                }

                                                break;
                                            case 3: // Gasoline
                                                Console.Write("How much?: ");
                                                amountGasoline = Convert.ToInt32(Console.ReadLine());
                                                gastype = "";
                                                priceliter = 0;
                                                double JeepneyGasolineEfficiency = 10.00;
                                                double TricycleGasolineEfficiency = 20.00;
                                                double MotorGasolineEfficiency = 30.00;
                                                double CarGasolineEfficiency = 13.5;
                                                liters = amountGasoline / priceliter;
                                                kl = 0;
                                                switch (vehicles)
                                                {
                                                    case 1:// Jeepney
                                                        kl = JeepneyGasolineEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                                                        break;
                                                    case 2: // Tricycle
                                                        kl = TricycleGasolineEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                                                        break;
                                                    case 3: // Motor
                                                        kl = MotorGasolineEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                                                        break;
                                                    case 4: // Car
                                                        kl = CarGasolineEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                break;
                                            case 4: // Unleaded
                                                Console.Write("How much?: ");
                                                amountUnleaded = Convert.ToInt32(Console.ReadLine());
                                                gastype = "";
                                                priceliter = 0;
                                                double JeepneyUnleadedEfficiency = 8.00;
                                                double TricycleUnleadedEfficiency = 24.00;
                                                double MotorUnleadedEfficiency = 30.00;
                                                double CarUnleadedEfficiency = 12.5;

                                                liters = amountUnleaded / priceliter;
                                                kl = 0;
                                                switch (vehicles)
                                                {
                                                    case 1:// Jeepney
                                                        kl = JeepneyUnleadedEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                                                        break;
                                                    case 2: // Tricycle
                                                        kl = TricycleUnleadedEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                                                        break;
                                                    case 3: // Motor
                                                        kl = MotorUnleadedEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                                                        break;
                                                    case 4: // Car
                                                        kl = CarUnleadedEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                break;
                                            case 5: // Kerosene
                                                Console.Write("How much?: ");
                                                amountKerosene = Convert.ToInt32(Console.ReadLine());
                                                gastype = "";
                                                priceliter = 0;
                                                double TricycleKeroseneEfficiency = 15.00;
                                                double MotorKeroseneEfficiency = 25;
                                                double CarKeroseneEfficiency = 9.5;
                                                liters = amountKerosene / priceliter;
                                                kl = 0;
                                                switch (vehicles)
                                                {

                                                    case 2:
                                                        kl = TricycleKeroseneEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountKerosene}");
                                                        break;
                                                    case 3: // Motor
                                                        kl = MotorKeroseneEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountKerosene}");
                                                        break;
                                                    case 4: // Car
                                                        kl = CarKeroseneEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountKerosene}");
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                break;
                                            case 6: // Petrol
                                                Console.Write("How much?: ");
                                                amountPetrol = Convert.ToInt32(Console.ReadLine());
                                                gastype = "";
                                                priceliter = 0;
                                                double TricyclePetrolEfficiency = 28.00;
                                                double MotorPetrolEfficiency = 35.00;
                                                double CarPetrolEfficiency = 14.5;
                                                liters = amountPetrol / priceliter;
                                                kl = 0;
                                                switch (vehicles)
                                                {

                                                    case 2:
                                                        kl = TricyclePetrolEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountPetrol}");
                                                        break;
                                                    case 3: // Motor
                                                        kl = MotorPetrolEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountPetrol}");
                                                        break;
                                                    case 4: // Car
                                                        kl = CarPetrolEfficiency;
                                                        Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amountPetrol}");
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                        break;
                                }
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("What gas type do you want to check?: ");
                            Console.WriteLine("1. Diesel");
                            Console.WriteLine("2. Premium");
                            Console.WriteLine("3. Gasoline");
                            Console.WriteLine("4. Unleaded");
                            Console.WriteLine("5. Kerosene");
                            Console.WriteLine("6. Petrol");
                            double gas = Convert.ToInt32(Console.ReadLine());
                            switch (gas)
                            {
                                case 1:
                                    double DieselMarketPrice = 54.06;
                                    List<int> DieselGasEarned = new List<int>();
                                    DieselGasEarned.Add(amountDiesel);
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
                                    PremiumGasEarned.Add(amountPremium);
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
                                    GasolineGasEarned.Add(amountGasoline);
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
                                    KeroseneGasEarned.Add(amountKerosene);
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
                                    UnleadedGasEarned.Add(amountUnleaded);
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
                                    PetrolGasEarned.Add(amountPetrol);
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

                            break;
                        default:
                            Stop = 100;
                            break;
                    }
                    break;
                }
            }
        }
    }
}
