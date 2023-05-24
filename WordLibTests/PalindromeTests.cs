using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = Palindrome.Something();
            Assert.AreEqual("something", result);
        }

        [TestMethod]
        public void TestPalindromeTrue()
        {
            bool result = Palindrome.IsPalindrome("abba");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestPalindromeFalse()
        {
            bool result = Palindrome.IsPalindrome("palindrome");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void ExceptionTestPalidrome_ThrowExceptionWithEmptyString()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Palindrome.IsPalindrome(string.Empty));
            Assert.ThrowsException<ArgumentNullException>(() => Palindrome.IsPalindrome(null));
        }
    }
}