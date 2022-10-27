using System.Runtime.CompilerServices;

namespace OOPracticeTest
{
    using OOPractice;
    using System.Diagnostics;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_return_msg_when_speed_up_given_car_name_speed()
        {
            //given
            Car car = new Car("Cool car", 30);

            //when
            string msg = car.SpeedUp();

            //then
            Assert.Equal("Cool car: speed up 30km/h", msg);
        }

        [Fact]
        public void Should_return_msg_when_speed_up_given_truck_name_speed()
        {
            //given
            Truck truck = new Truck("Big truck", 10);

            //when
            string msg = truck.SpeedUp();

            //then
            Assert.Equal("Big truck: speed up 10km/h", msg);
        }
    }
}
