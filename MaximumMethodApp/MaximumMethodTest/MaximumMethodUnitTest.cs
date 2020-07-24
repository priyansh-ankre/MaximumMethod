using NUnit.Framework;

namespace MaximumMethodTest
{
    public class MaximumMethodUnitTest
    {
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnFirstNumber()
        {
            Assert.AreEqual(45,new MaximumMethod.MaximumMethodUtility<int>(45,40,35).findMaximum());
        }
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnSecondNumber()
        {
            Assert.AreEqual(45, new MaximumMethod.MaximumMethodUtility<int>(40, 45, 35).findMaximum());
        }
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnThirdNumber()
        {
            Assert.AreEqual(45, new MaximumMethod.MaximumMethodUtility<int>(40,35,45).findMaximum());
        }
        [Test]
        public void givenFloats_WhenTestedForMaximum_ShouldReturnFirstFloat()
        {
            Assert.AreEqual(23.9,new MaximumMethod.MaximumMethodUtility<double>(23.9, 3.8, 2.9).findMaximum());
        }
        [Test]
        public void givenFloats_WhenTestedForMaximum_ShouldReturnSecondFloat()
        {
            Assert.AreEqual(23.9, new MaximumMethod.MaximumMethodUtility<double>(3.8, 23.9, 2.9).findMaximum());
        }
        [Test]
        public void givenFloats_WhenTestedForMaximum_ShouldReturnThirdFloat()
        {
            Assert.AreEqual(23.9, new MaximumMethod.MaximumMethodUtility<double>(3.8, 2.9, 23.9).findMaximum());
        }
        [Test]
        public void givenStrings_WhenTestedForMaximum_ShouldReturnFirstString()
        {
            Assert.AreEqual("peach", new MaximumMethod.MaximumMethodUtility<string>("peach","banana","apple").findMaximum());
        }
        [Test]
        public void givenStrings_WhenTestedForMaximum_ShouldReturnSecondString()
        {
            Assert.AreEqual("peach", new MaximumMethod.MaximumMethodUtility<string>("banana", "peach", "apple").findMaximum());
        }
        [Test]
        public void givenStrings_WhenTestedForMaximum_ShouldReturnThirdString()
        {
            Assert.AreEqual("peach", new MaximumMethod.MaximumMethodUtility<string>("banana", "apple", "peach").findMaximum());
        }
    }
}