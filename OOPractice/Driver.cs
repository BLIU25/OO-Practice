using OOPractice;

namespace OOPractice
{
    public class Driver
    {
        private Vehicle vehicle;

        public Driver(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string SpeedUp()
        {
            return vehicle.SpeedUp();
        }
    }
}