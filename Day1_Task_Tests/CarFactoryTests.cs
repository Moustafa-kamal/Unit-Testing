using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Task_Tests
{
    public class CarFactoryTests
    {
        #region     Throw Assert
        [Fact]
        public void NewCar_AskForToyota_Exception()
        {
            //Step1 : Arrange XXXX ----> Remeber You Used Static Class And Method Static    
            //Step3: Exception Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                //Step2: Act
                Car? result = CarFactory.NewCar(CarTypes.Toyota);
            });
            Assert.ThrowsAny<Exception>(() =>
            {
                //Step2: Act
                Car? result = CarFactory.NewCar(CarTypes.Toyota);
            });
        }
        //----------------------------------------------------------------
        [Fact]
        public void NewCar_AskForHonda_Exception()
        {
            //Step1 : Arrange XXXX ----> Remeber You Used Static Class And Method Static    
            //Step3: Exception Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                //Step2: Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
            Assert.ThrowsAny<Exception>(() =>
            {
                //Step2: Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }
        #endregion

        #region   Type Assert
        [Fact]
        public void NewCar_AskForBMW_BMWObject()
        {
            //Step1 : Arrange XXXX ----> Remeber You Used Static Class And Method Static

            //Step2: Act
            Car? result = CarFactory.NewCar(CarTypes.BMW);

            //Step3: Type Assert
            Assert.IsType<BMW>(result);
            Assert.IsNotType<Toyota>(result);
            Assert.IsAssignableFrom<Car>(result);
        }
        //----------------------------------------------------------------------
        [Fact]
        public void NewCar_AskForToyota_ToyotaObject()
        {
            //Step1 : Arrange XXXX ----> Remeber You Used Static Class And Method Static

            //Step2: Act
            Car? result = CarFactory.NewCar(CarTypes.Toyota);

            //Step3: Type Assert
            Assert.IsType<Toyota>(result);
            Assert.IsNotType<BMW>(result);
            Assert.IsAssignableFrom<Car>(result);
        }
        #endregion
    }
}
