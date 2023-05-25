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

        [TestMethod]
        public void ExceptionTestPalidrome_ThrowExceptionWithNullOrEmptyString()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Palindrome.IsPalindrome(string.Empty));
            Assert.ThrowsException<ArgumentNullException>(() => Palindrome.IsPalindrome(null));
        }

        [TestMethod]
        public void TestCountLetters_ReturnCorrectCount()
        {
            int resultOne = Palindrome.LettersCounter("palindrome");
            int resultTwo = Palindrome.LettersCounter("abba abba");

            Assert.AreEqual(10, resultOne);
            Assert.AreEqual(8, resultTwo);
        }

        [TestMethod]
        public void TestCountLetters_EmptyStringReturnZero()
        {
            int result = Palindrome.LettersCounter("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCountLetters_ContainingNoLetters_ReturnOnlyLettersCount()
        {
            int result = Palindrome.LettersCounter("@@@881122#??¿¿!!&%&palindrome");

            Assert.AreEqual(10, result);
        }
    }
}