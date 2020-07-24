using NUnit.Framework;

namespace MaximumMethodTest
{
    public class MaximumMethodUnitTest
    {
        MaximumMethod.MaximumMethodUtiity maximumMethod = new MaximumMethod.MaximumMethodUtiity();
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnFirstNumber()
        {
            Assert.AreEqual(45, maximumMethod.findMaximum(45, 35, 40));
        }
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnSecondNumber()
        {
            Assert.AreEqual(45, maximumMethod.findMaximum(40, 45, 35));
        }
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnThirdNumber()
        {
            Assert.AreEqual(45, maximumMethod.findMaximum(40, 35, 45));
        }
    }
}