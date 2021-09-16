using System;

namespace Lab2_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new() { Driver = "Ашот", Id = 1, CostPerKm = 13 };

            Passenger p1 = new(12, 24);
            Passenger p2 = new(22, 11);
            Passenger p3 = new(18, 8);

            taxi.TryAddPassenger(p1);
            taxi.TryAddPassenger(p2);
            taxi.TryAddPassenger(p3);
            taxi.TryAddPassenger(new(35, 4));
            taxi.TryAddPassenger(new(16, 17));

            Console.WriteLine(taxi.ToString());

            Console.WriteLine(taxi.CalculateCost(p1));
            Console.WriteLine(taxi.CalculateCost(new Passenger[] { p1, p3 }));
            Console.WriteLine(taxi.CalculateCostForAll());
        }
    }
}
