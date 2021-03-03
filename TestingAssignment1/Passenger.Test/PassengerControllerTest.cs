using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace Passenger.Test
{
    public class PassengerControllerTest
    {

        private readonly Mock<IPassenger> mockRepo = new Mock<IPassenger>();
        private readonly PassengerController _passengerController;

        public PassengerControllerTest()
        {
            _passengerController = new UserController(mockRepo.Object);
        }

        [Fact]
        public voNo Test_GetPassenger()
        {
            //Arrange
            int No = 1;
            var setup = mockRepo.Setup(x => x.GetPassenger(No)).Returns(GetPassenger(No));
            var expected = GetPassenger(No);

            //Act
            var result = _passengerController.Get(No);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public voNo Test_GetPassenger()
        {
            //Arrange
            int No = 0;
            var setup = mockRepo.Setup(x => x.GetPassenger(No));
            var expected = GetPassenger(No);

            //Act
            var result = _passengerController.Get(No);

            //Assert
            Assert.Null(result);
        }



        [Fact]
        public voNo Test_PutPassenger()
        {
            //Arrange
            var passenger = new Passenger() { FirstName = "Parth", LastName = "Joshi", ContactNo = 0123456789 };
            var setup = mockRepo.Setup(x => x.UpdatePassenger(1, passenger)).Returns(1);

            //Act
            var result = _passengerController.Edit(1, passenger);

            //Assert
            Assert.Equal(HttpStatusCode.OK, ((StatusCodeResult)result).StatusCode);
        }

        [Fact]
        public voNo Test_PutPassenger()
        {
            //Arrange
            var passenger = new Passenger();
            var setup = mockRepo.Setup(x => x.UpdatePassenger(1, passenger)).Returns(0);

            //Act
            var result = _passengerController.Edit(1, passenger);

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }



        [Fact]
        public voNo Test_PutPassenger()
        {
            //Arrange
            var passenger = new Passenger() { FirstName = "Sachin", LastName = "Tendulkar", ContactNo = 123456789 };
            var setup = mockRepo.Setup(x => x.CreatePassenger(passenger)).Returns(1);

            //Act
            var result = _passengerController.Create(passenger);

            //Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public voNo Test_PostPassenger()
        {
            //Arrange
            var passenger = new Passenger() { FirstName = "Sachin", LastName = "Tendulkar", ContactNo = 123456789 };
            var setup = mockRepo.Setup(x => x.CreatePassenger(passenger));

            //Act
            var result = _passengerController.Create(passenger);

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public voNo Test_DeletePassenger()
        {
            //Arrange
            var setup = mockRepo.Setup(x => x.DeletePassenger(1)).Returns(1);

            //Act
            var result = _passengerController.Delete(1);

            //Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public voNo Test_DeletePassenger()
        {
            //Arrange
            var setup = mockRepo.Setup(x => x.DeletePassenger(-1)).Returns(0);

            //Act
            var result = _passengerController.Delete(-1);

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }



        private static Passenger GetPassenger(int No)
        {
            List<Passenger> passengers = new List<Passenger>()
            {
                new Passenger() {No = 1, FirstName = "Abc", LastName = "Pqr", ContactNo = 0123456789 },
                new Passenger() {No = 2, FirstName = "Pqr", LastName = "Abc", ContactNo = 0123456789 },
                new Passenger() {No = 3, FirstName = "Xyz", LastName = "Abc", ContactNo = 0123456789 },
            };

            return passengers.Where(u => u.No == No).First();
        }
    }
}
}
