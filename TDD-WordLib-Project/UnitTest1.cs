
using global::WordLib;
namespace WordLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPalindrome()
        {
            // Create an instance to test:
            Worder worder = new Worder();

            // expected output
            string expectedResult = "bob";
            string inputWord = "bob";
            // Run the method under test:
            string actualResult = worder.IsPalindromeWordChecker(inputWord);

            // Assert / Verify the result:
            Assert.AreEqual(expectedResult, actualResult);

              
        }

        [TestMethod]

        public void IsPalindromeThrowsException()
        {
            // Create an instance to test:
            Worder worder = new Worder();

            // expected output
            string inputWord = null;

            // Assert / Verify the result:
            Assert.ThrowsException<ArgumentException>(() => worder.IsPalindromeWordChecker(inputWord));


        }

        [TestMethod]

        public void StringLenghtCheck()
        {
            // Create an instance to test:
            Worder worder = new Worder();

            // expected output
            int expectedOutput = 5;
            string inputWord = "Paris";

            // Run the method under test:
            int actualResult = worder.CheckingStringLength(inputWord);
            // Assert / Verify the result:
            Assert.AreEqual(expectedOutput, actualResult);


        }







    }
}