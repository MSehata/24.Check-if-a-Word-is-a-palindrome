using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Check_if_a_Word_is_a_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter a word (We will change it to upper cases): ");
            string word = Console.ReadLine();
            word = word.ToUpper();
            string reversedWord = Reverse(word);

            if (word == reversedWord)
                Console.WriteLine(word + " is a palindrome.");
            else
                Console.WriteLine(word + " is not a palindrome.");
            Console.Read();
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
