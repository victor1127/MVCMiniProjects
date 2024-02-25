using MVCMiniProjects.Models;

namespace MVCMiniProjects.Services
{
    public class PalindromeService
    {
        public static Palindrome Reverse(string str)
        {
            if (string.IsNullOrEmpty(str)) return new();

            Palindrome palindrome = new();
            palindrome.UserInput = str;
            palindrome.ReversedWord = ReverseString(str);
            palindrome.IsPalindrom = string.Equals(palindrome.UserInput, palindrome.ReversedWord, StringComparison.CurrentCultureIgnoreCase);
            palindrome.Message = palindrome.IsPalindrom ? "is a palindrome" : "is not a palindrome";


            return palindrome;
        }

        private static string ReverseString(string str)
        {
            if (str.Length == 1) return str;
            return ReverseString(str.Substring(1)) + str[0];
        }
    }
}
