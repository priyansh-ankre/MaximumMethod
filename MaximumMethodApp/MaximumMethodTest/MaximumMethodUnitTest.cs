using NUnit.Framework;

namespace MaximumMethodTest
{
    public class MaximumMethodUnitTest
    {
        
        [Test]
        public void givenNumbers_WhenTested_ShouldReturnMaximumNumber()
        {
            object[] inputNumbers = { 13, 7, 6, 45, 21, 9, 2, 100 };
            MaximumMethod.MaximumMethodUtility maximumMethod = new MaximumMethod.MaximumMethodUtility(inputNumbers);
            Assert.AreEqual(100,maximumMethod.findMaximum());
            maximumMethod.toPrint();
        }
        [Test]
        public void givenFloats_WhenTested_ShouldReturnMaximumFloat()
        {
            object[] inputFloats = { 2.62, 1.32, 5.987, 4.43 };
            MaximumMethod.MaximumMethodUtility maximumMethod = new MaximumMethod.MaximumMethodUtility(inputFloats);
            Assert.AreEqual(5.987,maximumMethod.findMaximum());
            maximumMethod.toPrint();
        }
        [Test]
        public void givenStrings_WhenTested_ShouldReturnMaximumString()
        {
            object[] inputStrings = { 2.62, 1.32, 5.987, 4.43 };
            MaximumMethod.MaximumMethodUtility maximumMethod = new MaximumMethod.MaximumMethodUtility(inputStrings);
            Assert.AreEqual(5.987, maximumMethod.findMaximum());
            maximumMethod.toPrint();
        }
    }
}