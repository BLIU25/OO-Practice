using System.Runtime.CompilerServices;

namespace OOPracticeTest
{
    using OOPractice;
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
    }
}
