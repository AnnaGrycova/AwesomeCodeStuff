using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string possibleAnagram1 = Console.ReadLine();
            string possibleAnagram2 = Console.ReadLine();
            Anagram anagram = new Anagram(possibleAnagram1, possibleAnagram2);
            Console.WriteLine(anagram.Check());

        }
    }
}
