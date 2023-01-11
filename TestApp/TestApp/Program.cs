using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "malayalam";

            var listOfSubStrings = new List<string>();
            var tempString = string.Empty;

            for (int outer = 0; outer < inputString.Length; outer++)
            {
                var inner = outer;
                while (inner < inputString.Length)
                {
                    tempString += inputString[inner];
                    listOfSubStrings.Add(tempString);
                    inner++;
                }
                tempString = string.Empty;
            }

            var outputList = new List<string>();

            foreach(string substring in listOfSubStrings)
            {
                var getPalindromeString = GetPalindrome(substring);
                if (!string.IsNullOrWhiteSpace(getPalindromeString))
                {
                    outputList.Add(getPalindromeString);
                }
            }

            Console.WriteLine("Output Items");
            foreach (var item in outputList.Distinct())
            {
                Console.WriteLine(item);
            }
        }

        private static string GetPalindrome(string substring)
        {
            if(string.Compare(substring, GetReverse(substring),true) == 0)
            {
                return substring;
            }

            return string.Empty;
        }

        private static string GetReverse(string substring)
        {
            var tempString = string.Empty;
           for(int index = substring.Length - 1; index >= 0; index--)
            {
                tempString += substring[index];
            }
            return tempString;
        }
    }
}
