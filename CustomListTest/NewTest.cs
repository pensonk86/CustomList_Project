using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTest
{
    public class NewTest
    {
        [TestMethod]

        public void AddTwoNumbers()
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
        public void OneString()
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
        public void












        


        
        


    }


    
}
