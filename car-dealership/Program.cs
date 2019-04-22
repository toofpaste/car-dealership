using System;
using System.Collections.Generic;

namespace Dealership
{
    public class Program
    {
        public static void Main()
        {
            Car porsche = new Car("2014 Porsche 918 spider", 2300000, 1200);
            Car ford = new Car("1992 Ford Tempus", 5, 430231);
            Car lexus = new Car("1994 Lexus ES300", 450, 152321);
            Car honda = new Car("2007 Honda CR-V", 5300, 73231);
            Car lincoln = new Car("2014 Lincoln MK-Z", 54000, 200);
            Car bmw = new Car("2007 BMW m5", 23000, 53000);

            List<Car> Cars = new List<Car>() { porsche, ford, lexus, honda, lincoln, bmw };
            List<Car> CarsPrice = new List<Car>(0);

            foreach (Car auto in Cars)
            {
                CarsPrice.Add(auto);
            }
            Console.WriteLine("Check for price? [Y,N]");
            string ans = Console.ReadLine();
            bool check = ans == "Y" || ans == "y";
            if (check)
            {
                Console.WriteLine("Enter a price: ");
                string maxPrice = Console.ReadLine();
                int numPrice = int.Parse(maxPrice);
                foreach (Car auto in CarsPrice)
                {
                    if (auto.CheckPrice(numPrice))
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine(auto.getModel());
                        Console.WriteLine(auto.getPrice());
                        Console.WriteLine(auto.getMile());
                    };
                }
            }else
                {
                Console.WriteLine("Add Car? [Y,N");
                string addAns = Console.ReadLine();
                bool checkAdd = addAns == "Y" || addAns == "y";
                if(checkAdd)
                {
                    
                    Console.WriteLine("Enter year, make, and model");
                    string make = Console.ReadLine();
                    Console.WriteLine("Enter Price");
                    string cost = Console.ReadLine();
                    int numCost = int.Parse(cost);
                    Console.WriteLine("Enter Mileage");
                    string strMile = Console.ReadLine();
                    int numMile = int.Parse(strMile);
                    Car newCar = new Car(make, numCost, numMile);
                    Cars.Add(newCar);
                    foreach (Car auto in Cars)
                    {
                            Console.WriteLine("------------------");
                            Console.WriteLine(auto.getModel());
                            Console.WriteLine(auto.getPrice());
                            Console.WriteLine(auto.getMile());
                    }
                }
            }
     
        }
    }
}
