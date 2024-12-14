using Acfour;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EvaluateValue_ShouldReturnNumber_WhenPositive()
        {

            int input = 5;

            int? result = Exercici4.EvaluateValue(input);

            Assert.AreEqual(input, result.Value);
        }
        [TestMethod]
        public void EvaluateValue_ShouldReturnNull_WhenNegative()
        {
            // Arrange
            int input = -5;

            // Act
            int? result = Exercici4.EvaluateValue(input);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void DescendingOrder_ShouldSortArrayDescending()
        {
            // Arrange
            int[] inputArray = { 5, 3, 8, 1, 7 };

            // Act
            Exercici4.DescendingOrder(inputArray);

            // Assert
            int[] expectedArray = { 8, 7, 5, 3, 1 };
            CollectionAssert.AreEqual(expectedArray, inputArray);
        }

    }
}