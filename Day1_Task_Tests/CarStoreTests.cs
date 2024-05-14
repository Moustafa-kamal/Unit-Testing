using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Task_Tests
{
    public class CarStoreTests
    {
        #region Collection Assert
        [Fact]
        public void AddCar_AddToyota_ListContainObject()
        {
            // Step1: Arrange
            CarStore carStore = new CarStore();
            Toyota toyota = new Toyota()
            {
                drivingMode = DrivingMode.Forward
            };
            BMW bMW = new BMW();

            // Step2: Act
            carStore.AddCar(toyota);

            // Collection Asserts

            // By Using Empty And NotEmpty
            Assert.Empty(carStore.cars);
            Assert.NotEmpty(carStore.cars);

            // By Using Value Equlity  
            Assert.Contains<Car>(toyota, carStore.cars);
            //Assert.Contains<Car>(bMW, carStore.cars);

            // By Using Contains
            //Assert.Contains<Car>(carStore.cars, c => c.drivingMode == DrivingMode.Backward);
            Assert.Contains<Car>(carStore.cars, c => c.drivingMode == DrivingMode.Forward);

            // By Using DoesNotContains
            Assert.DoesNotContain<Car>(carStore.cars, c => c.velocity == 10);
        }
        #endregion
    }
}
