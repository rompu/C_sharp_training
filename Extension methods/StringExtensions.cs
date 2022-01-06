using System;
using System.Linq;

namespace System //placing extension methods in System namespace means that the applications using them dont need to separately import the name space (eg. "using ExtensionsMehtods.Extensions;")
{
    public static class StringExtensions //extension method classes must be public and static
    {

        public static string Shorten(this string str, int numberOfWords) //extension methods must be public and static, this keyword makes it into an extnesion method.
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords shold be greater or equal to zero");
            if (numberOfWords == 0)
                return "";
            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords))+"...";
        }
    }
}
