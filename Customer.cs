using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erika__Gasoline_Refill_
{
    internal class Customer
    {
       
            static void Wow(string[] args)
            {
                Console.WriteLine("Welcome to my Erika's Gas Station");

                Console.Write("Enter your plate number: ");
                int platenum = Convert.ToInt32(Console.ReadLine());
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

                double DieselPrice = 60.05;
                double PremiumPrice = 68.00;
                double GasolinePrice = 64.40;
                double UnleadedPrice = 65.40;
                double KerosenePrice = 72.96;
                double PetrolPrice = 60;
                Console.Write("How much Fuel do you want to spend: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                switch (fuel)

                {
                    case 1:
                        priceliter = DieselPrice;
                        gastype = "Diesel";

                        break;
                    case 2:
                        priceliter = PremiumPrice;
                        gastype = "Premium";
                        break;
                    case 3:
                        priceliter = GasolinePrice;
                        gastype = "Gasoline";
                        break;
                    case 4:
                        priceliter = UnleadedPrice;
                        gastype = "Unleaded";
                        break;
                    case 5:
                        priceliter = KerosenePrice;
                        gastype = "Kerosene";
                        break;
                    case 6:
                        priceliter = PetrolPrice;
                        gastype = "Petrol";
                        break;
                    default:
                        Console.Write("Invalid Choice. Please select a valid option (1-6).");
                        break;
                }


                double JeepneyDieselEfficiency = 13.00;
                double JeepneyPremiumEfficiency = 11.00;
                double JeepneyGasolineEfficiency = 10.00;
                double JeepneyUnleadedEfficiency = 8.00;

                double TricycleDieselEfficiency = 30.00;
                double TricyclePremiumEfficiency = 25.00;
                double TricycleGasolineEfficiency = 20.00;
                double TricycleUnleadedEfficiency = 24.00;
                double TricycleKeroseneEfficiency = 15.00;
                double TricyclePetrolEfficiency = 28.00;

                double MotorDieselEfficiency = 40.00;
                double MotorPremiumEfficiency = 35.00;
                double MotorGasolineEfficiency = 30.00;
                double MotorUnleadedEfficiency = 30.00;
                double MotorKeroseneEfficiency = 25;
                double MotorPetrolEfficiency = 35.00;

                double CarDieselEfficiency = 15.00;
                double CarPremiumEfficiency = 13.00;
                double CarGasolineEfficiency = 13.5;
                double CarUnleadedEfficiency = 12.5;
                double CarKeroseneEfficiency = 9.5;
                double CarPetrolEfficiency = 14.5;

                double BusDieselEfficiency = 10.00;

                double VanDieselEfficiency = 18.00;

                double TruckDieselEfficiency = 8.00;

                double liters = amount / priceliter;
                double kl = 0;

                switch (vehicles)
                {
                    case 1:
                        if (gastype == "Diesel")
                        {
                            kl = JeepneyDieselEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else if (gastype == "Premium")
                        {
                            kl = JeepneyPremiumEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Gasoline")
                        {
                            kl = JeepneyGasolineEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else if (gastype == "Unleaded")
                        {
                            kl = JeepneyUnleadedEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Jeepney doesn't use that kind of Fuel. Please choose the correct fuel type.");
                        }
                        break;
                    case 2:
                        if (gastype == "Diesel")
                        {
                            kl = TricycleDieselEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else if (gastype == "Premium")
                        {
                            kl = TricyclePremiumEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Gasoline")
                        {
                            kl = TricycleGasolineEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Unleaded")
                        {
                            kl = TricycleUnleadedEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Kerosene")
                        {
                            kl = TricycleKeroseneEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Petrol")
                        {
                            kl = TricyclePetrolEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Tricycle doesn't use that kind of Fuel. Please choose the correct fuel type.");
                        }
                        break;
                    case 3:
                        if (gastype == "Diesel")
                        {
                            kl = MotorDieselEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else if (gastype == "Premium")
                        {
                            kl = MotorPremiumEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Gasoline")
                        {
                            kl = MotorGasolineEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Unleaded")
                        {
                            kl = MotorUnleadedEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Kerosene")
                        {
                            kl = MotorKeroseneEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Petrol")
                        {
                            kl = MotorPetrolEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Motor doesn't use that kind of Fuel. Please choose the correct fuel type.");
                        }
                        break;
                    case 4:
                        if (gastype == "Diesel")
                        {
                            kl = CarDieselEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else if (gastype == "Premium")
                        {
                            kl = CarPremiumEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Gasoline")
                        {
                            kl = CarGasolineEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Unleaded")
                        {
                            kl = CarUnleadedEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Kerosene")
                        {
                            kl = CarKeroseneEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;

                        }
                        else if (gastype == "Petrol")
                        {
                            kl = CarPetrolEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Car doesn't use that kind of Fuel. Please choose the correct fuel type.");
                        }
                        break;
                    case 5:
                        if (gastype == "Diesel")
                        {
                            kl = BusDieselEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bus doesn't use that kind of Fuel. Please choose the correct fuel type.");
                        }
                        break;
                    case 6:
                        if (gastype == "Diesel")
                        {
                            kl = VanDieselEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Van doesn't use that kind of Fuel. Please choose the correct fuel type.");
                        }
                        break;
                    case 7:
                        if (gastype == "Diesel")
                        {
                            kl = TruckDieselEfficiency;
                            Console.WriteLine($"You have {liters} liters of {gastype} and it can go approximately {kl:F2} kilometers with the amount of {amount}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Truck doesn't use that kind of Fuel. Please choose the correct fuel type.");
                        }
                        Console.WriteLine($"For {amount}, you can buy {liters:.} liters of {gastype}.");
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your {gastype} can go approximately {kl:.} kilometer.");
                        break;
                }
                Console.WriteLine("\nECB POWER GAS STATION");
                Console.WriteLine("888-888-8888");
                Console.WriteLine("--- Gas Station Receipt ---");
                DateTime purchasetime = DateTime.Now;
                Console.WriteLine($"Time of Purchase: {purchasetime.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Your Plate Number: {platenum}");
                Console.WriteLine($"Fuel Type: {gastype}");
                Console.WriteLine($": {amount}");
                Console.WriteLine("");

                Console.WriteLine("Thank you for your purchase!");
            }
        }

    }

