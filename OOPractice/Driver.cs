using OOPractice;

namespace OOPracticeTest
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