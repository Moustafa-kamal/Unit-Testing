using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Task_Tests
{
    public class CarTests
    {
        #region Numerical Assert
        [Fact]
        public void Accelerate_velocity10_Range20to30()
        {
            // Step1: Arrange
            Toyota toyota = new Toyota() { velocity = 10 };
            BMW bMW = new BMW() { velocity = 10 };
            // Step2: Act
            toyota.Accelerate();
            bMW.Accelerate();
            // Step3: Assert
            Assert.InRange(toyota.velocity, 20, 30);
            Assert.InRange(bMW.velocity, 20, 30);
            Assert.NotInRange(toyota.velocity, 100, 120);
            //check 
            Assert.True(toyota.velocity > 10);
            Assert.True(bMW.velocity > 10);
        }
        #endregion
    }
}
