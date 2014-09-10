using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textstats
{
    class Program
    {
        static void Main(string[] args)
        {
        }




        static void TextStats(string input)
        {
            //add input
            string input = input.ToLower();
            //print the number of letters, words, vowels, consonants, special characters, longest word and the shorterest word
            



            //print number of letters
            Console.WriteLine("number of letters: " + input.Length);
            
            //print number of words
            Console.WriteLine("number of words: " + input.Split(' '));
            
            
            //print number of vowels("number of vowels:" input.Where(x => aeio.Contains(x.ToString()).Count(;
            Console.WriteLine("number of vowels:" + input.Where(x => "aeio".Contains(x.ToString()).Count()));
            

            //Print number of consonants
            Console.WriteLine("Number of consonants:" input.Where(x => "bcdefghjklmnpqrstvwxyz").Contains(x.ToString());

            //print number of special characters
            Console.WriteLine("Nuumber of special characcters:" + input.Count(x => "' '!@#$%^&*".Contains(x.ToString());

            //print the longest word
            Console.WriteLine("Longest Word:" + input.Count(x =>.Length.Last());

            //print the shortest word
            Console.WriteLine("Shortest Word:" + input.Split(' ').OrderBy(x +> x.Length.First());
        }
    }
}