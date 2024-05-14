using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Task_Tests
{
    public class ToyotaTests
    {
        #region Boolean Assert  
        [Fact]
        public void IsStopped_Velocity0_true()
        {

            // Step1: Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            // Step2: Act
            bool actualResult = toyota.IsStopped();

            // Step3: Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void IsStopped_Velocity20_false()
        {
            // Step1: Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 20;

            // Step2: Act
            bool actualResult = toyota.IsStopped();

            // Step3: Assert
            Assert.False(actualResult);
        }
        #endregion

        #region String Assert
        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            // Step1: Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Backward };
            // Step2: Act
            string result = toyota.GetDirection();
            // Step3: String Assert
            Assert.Equal("Backward", result);
            Assert.StartsWith("Ba", result);
            Assert.EndsWith("rd", result);
            Assert.Contains("ck", result);
            Assert.DoesNotContain("zx", result);
            Assert.Matches("F[a-z]{5}", result);
            Assert.DoesNotMatch("F[a-z]{10}", result);
        }
        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Step1: Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };
            // Step2: Act
            string result = toyota.GetDirection();
            // Step3: String Assert
            Assert.Equal("Forward", result);
            Assert.StartsWith("Fo", result);
            Assert.EndsWith("rd", result);
            Assert.Contains("wa", result);
            Assert.DoesNotContain("zx", result);
            Assert.Matches("F[a-z]{6}", result);
            Assert.DoesNotMatch("F[a-z]{8}", result);
        }
        #endregion

        #region Reference Assert
        [Fact]
        public void GetMyCar_AskForRefrence_Same()
        {
            // Step1: Arrange
            BMW bMW11 = new BMW();
            BMW bMW12 = new BMW();
            // Step2: Act
            Car result = bMW11.GetMyCar();
            // Step3: Reference Assert
            Assert.Same(bMW11, result);
            Assert.NotSame(bMW12, result);
            //-------------------------------------------------------------
            // Step1: Arrange
            Toyota toyota = new Toyota();
            Toyota t = new Toyota();
            // Step2: Act
            Car result2 = toyota.GetMyCar();
            // Step3: Reference Assert
            Assert.Same(toyota, result2);
            Assert.NotSame(t, result2);
        }
        #endregion
    }
}
