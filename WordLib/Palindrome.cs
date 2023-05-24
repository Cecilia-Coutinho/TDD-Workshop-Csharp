namespace WordLib
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
        }

        public static string Something()
        {
            return "something";
        }

        public static bool IsPalindrome(string stringToCheck)
        {
            return IsPalindromeChecker(stringToCheck);
        }

        static bool IsPalindromeChecker(string stringToCheck)
        {
            char[] chars = stringToCheck.ToCharArray();
            Array.Reverse(chars);
            string reverse = new(chars);

            return stringToCheck.Equals(reverse, StringComparison.OrdinalIgnoreCase);
        }
    }
}