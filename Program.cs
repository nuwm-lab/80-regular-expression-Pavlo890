using System;
using System.Text;
using System.Text.RegularExpressions;

namespace lab8
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Хрещення Русі було в 988 році.";
            Console.WriteLine("Текст:");
            Console.WriteLine(text);

            string pattern = @"\b\d+\b";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                Console.WriteLine("\nВ тексті є числа:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("\nВ тексті немає чисел.");
            }
        }
    }
}