using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingTwoValuesToList_ExpectingCountToBeTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstNumber = 17;
            int secondNumber = 18;
            int expected = 2;
            int actual;

            //Act
            customList.Add(firstNumber);
            customList.Add(secondNumber);
            actual = customList.Count;
            
            //Assert
                
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneStringName_CheckingZeroIndex()
        {
                //Arrange
                CustomList<string> nameList = new CustomList<string>();
                string expected = "Kelly";
                string actual;

                //Act
                nameList.Add("Kelly");
                actual = nameList[0];

                //Assert
                Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingTwoStringValuesToList_ExpectingCountToBeTwo()
        {
            //Arrange
            CustomList<string> carList = new CustomList<string>();
            int expected = 2;
            int actual;

            //Act
            carList.Add("Honda");
            carList.Add("Jeep");

            actual = carList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        public void Add_AddFiveItems_CapacityShouldBe8()
        {
            //Arrange
            CustomList<string> carList = new CustomList<string>();
            int expected = 4;
            int actual;

            //Act
            carList.Add("Honda");
            carList.Add("Jeep");
            carList.Add("Mazda");
            carList.Add("Toyota");
            carList.Add("Nissan");

            actual = carList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        public void Add_AddFiveItems_0IndexPersists()
        {
            //Arrange
            CustomList<string> carList = new CustomList<string>();
            int expected = 5;
            int actual;

            //Act
            carList.Add("Honda");
            carList.Add("Jeep");
            carList.Add("Mazda");
            carList.Add("Toyota");
            carList.Add("Nissan");

            actual = carList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        
        public void Add_AddNumber_CountIncreaseByOne()
        {   //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstNumber = 17;
            int secondNumber = 1;
            int expected = 1;
            int actual;

            //Act
            customList.Add(firstNumber);
            customList.Add(secondNumber);
            actual = customList.Count;

            //Assert

            Assert.AreEqual(expected, actual);

        }
         


        
        
        //check capacity when list is created
        //check capacity when list has more than 4 values added
        //check an index to make sure a value is still in the right spot after capity is increased
        








    }
    
}
