using NUnit.Framework;

namespace MaximumMethodTest
{
    public class MaximumMethodUnitTest
    {
        MaximumMethod.MaximumMethodUtiity maximumMethod = new MaximumMethod.MaximumMethodUtiity();
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnFirstNumber()
        {
            Assert.AreEqual(45, maximumMethod.findMaximumNumber(45, 35, 40));
        }
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnSecondNumber()
        {
            Assert.AreEqual(45, maximumMethod.findMaximumNumber(40, 45, 35));
        }
        [Test]
        public void givenNumbers_WhenTestedForMaximum_ShouldReturnThirdNumber()
        {
            Assert.AreEqual(45, maximumMethod.findMaximumNumber(40, 35, 45));
        }
        [Test]
        public void givenFloats_WhenTestedForMaximum_ShouldReturnFirstFloat()
        {
            Assert.AreEqual(23.9, maximumMethod.findMaximumFloat(23.9,3.8,2.9));
        }
        [Test]
        public void givenFloats_WhenTestedForMaximum_ShouldReturnSecondFloat()
        {
            Assert.AreEqual(23.9, maximumMethod.findMaximumFloat(3.8,23.9, 2.9));
        }
        [Test]
        public void givenFloats_WhenTestedForMaximum_ShouldReturnThirdFloat()
        {
            Assert.AreEqual(23.9, maximumMethod.findMaximumFloat(3.8,2.9,23.9));
        }
    }
}