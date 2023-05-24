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

        [TestMethod]
        public void TestPalindromeTrue()
        {
            bool result = WordLib.Palindrome.IsPalindrome("abba");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestPalindromeFalse()
        {
            bool result = WordLib.Palindrome.IsPalindrome("palindrome");
            Assert.AreEqual(false, result);
        }
    }
}