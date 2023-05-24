using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = WordLib.Palindrome.Something();
            Assert.AreEqual("something", result);
        }
    }
}