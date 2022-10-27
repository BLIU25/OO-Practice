using System;
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
            Engine engine = new Engine("gasoline");
            Car car = new Car("Cool car", engine);

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

        [Fact]
        public void Should_return_msg_when_speed_up_given_driver_car_name_speed()
        {
            //given
            Vehicle vehicle = new Vehicle("Cool car", 30);
            Driver driver = new Driver(vehicle);

            //when
            string msg = driver.SpeedUp();

            //then
            Assert.Equal("Cool car: speed up 30km/h", msg);
        }

        [Fact]
        public void Should_return_msg_when_speed_up_given_driver_truck_name_speed()
        {
            //given
            Vehicle vehicle = new Vehicle("Big truck", 10);
            Driver driver = new Driver(vehicle);

            //when
            string msg = driver.SpeedUp();

            //then
            Assert.Equal("Big truck: speed up 10km/h", msg);
        }
    }
}
