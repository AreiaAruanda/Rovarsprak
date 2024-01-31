using System.Diagnostics.Metrics;
using System.Numerics;

namespace Rövarsprak
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What would you like to translate into rövarspråk?\n");
            Console.WriteLine("Please enter a word or sentence: ");
            string word = Console.ReadLine();
            string wordNew = word.ToLower();

            for (int i = 0; i < wordNew.Length; i++)
            {
                if (!"aeiouäåö ,;:!?.".Contains(wordNew[i]))
                    Console.Write($"{wordNew[i]}o{wordNew[i]}");
                else
                    Console.Write(wordNew[i]);
            };
            Console.WriteLine();
        }
    }
}