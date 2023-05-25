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

            if (stringToCheck == null || stringToCheck == string.Empty)
            {
                throw new ArgumentNullException(nameof(stringToCheck));
            }

            char[] chars = stringToCheck.ToCharArray();
            Array.Reverse(chars);
            string reverse = new(chars);

            return stringToCheck.Equals(reverse, StringComparison.OrdinalIgnoreCase);
        }

        public static int LettersCounter(string strToCount)
        {
            int counter = 0;
            foreach (char c in strToCount)
            {
                if (char.IsLetter(c))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}