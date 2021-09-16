namespace Lab2_Taxi
{
    public class Passenger
    {
        private int age;
        private int travelDistance;
        public int Age 
        {
            get => age;
            set => age = value > 0 && value < 120 ? value : age;
        }
        public int TravelDistance
        {
            get => travelDistance;
            set => travelDistance = value > 0 ? value : travelDistance;
        }

        public Passenger(int age, int travelDistance) => (Age, TravelDistance) = (age, travelDistance);
        public Passenger()
        { }

        public override string ToString() => $"Возраст: {Age}\tДистанция поездки: {TravelDistance}";
    }
}
