using System;
using System.Collections.Generic;

namespace Lab2_Taxi
{
    public class Taxi
    {
        private List<Passenger> _passengers = new();

        public int Id { get; set; }
        public string Driver { get; init; }
        public int CostPerKm { get; set; }

        public Taxi(string driver) => Driver = driver;
        public Taxi()
        { }

        public bool TryAddPassenger(Passenger passenger)
        {
            if (_passengers.Count == 4)
            {
                return false;
            }

            _passengers.Add(passenger);
            return true;
        }

        public int CalculateCost(Passenger passenger)
        {
            if (_passengers.Contains(passenger))
            {
                return passenger.TravelDistance * CostPerKm;
            }

            return 0;
        }

        public int CalculateCost(IEnumerable<Passenger> passengers)
        {
            int cost = default;

            foreach (Passenger passenger in passengers)
            {
                cost += CalculateCost(passenger);
            }

            return cost;
        }

        public int CalculateCostForAll()
        {
            int cost = default;

            foreach (Passenger passenger in _passengers)
            {
                cost += CalculateCost(passenger);
            }

            return cost;
        }

        public override string ToString()
        {
            string info = string.Empty;

            info += $"Номер такси: {Id}\nВодитель: {Driver}\nЦена за километр: {CostPerKm}\n\n";

            foreach (Passenger passenger in _passengers)
            {
                info += $"Пассажир {_passengers.IndexOf(passenger)+1}: {passenger}\tЦена поездки: {CalculateCost(passenger)}\n";
            }

            return info;
        }
    }
}
