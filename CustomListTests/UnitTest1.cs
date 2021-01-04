using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTwoNumbers_Age()
        {
                //Arrange
                
            int firstNumber = 17;
            int secondNumber = 18;
            
                //Act
        
            Calculator calculator = new Calculator();
            
                int sum = calculator.Add(firstNumber, secondNumber);

                //Assert
                
            Assert.AreEqual(35, sum);
        }


        public void OneStringName()
        {
                //Arrange
                CustomList<string> customList = new CustomList<string>();
                string expected = "Kelly";
                string actual;

                //Act
                customList.Add("Kelly");
                actual = customList[0];

                //Assert
                Assert.AreEqual(expected, actual);
        }
        public void TypeCar()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "Honda";
            string actual;

            //Act
            customList.Add("Honda");
            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Main(string[] args)
        {
            object[] array = new object[3];
            array[0] = 35;
            array[1] = "Kelly";
            array[2] = "Honda";
           
        }




        



    }
    
}
