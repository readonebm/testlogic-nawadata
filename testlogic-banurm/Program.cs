using System;
using System.Collections.Generic;
using System.Linq;

namespace testlogic_banurm
{
    public class Program
    {
        static void Main(string[] args)
        {
            string procVowel(string param)
            {
                string paraVowel = param.ToLower();
                //string[] paramVowels = paraVowel.Split(' ');


                char[] inpParams = paraVowel.ToCharArray();

                List<char> vowels = new List<char>();

                string result = "";

                foreach (char s in inpParams)
                {
                    
                    if (s == 'a' || s == 'i' || s == 'u' || s == 'e' || s == 'o')
                    { 
                        vowels.Add(s);
                    }
                }

                foreach (char s in vowels.OrderBy(i => i))
                {
           
                    result += s;
                }

                return result;
            }

            string procConsonant(string param)
            {
                string paraCons = param.ToLower();
                char[] inpParams = paraCons.ToCharArray();

                List<char> vowels = new List<char>();

                string result = "";

                foreach (char s in inpParams)
                {
                    if (s == 'a' || s == 'i' || s == 'u' || s == 'e' || s == 'o')
                    {
                        continue;
                    }
                    else
                    {
                        vowels.Add(s);
                    }
                }

                foreach (char s in vowels.OrderByDescending(i => i))
                {

                    result += s;
                }

                return result;
            }


            Console.Write("Input one line of words (S) : ");
            string input = Console.ReadLine();
            //string input = "Sample Case";

            string charVowel = procVowel(input);
            string charConsonant = procConsonant(input);

            Console.WriteLine("Vowel Characters : ");
            Console.WriteLine(charVowel);
            Console.WriteLine("Consonant Characters : ");
            Console.WriteLine(charConsonant);
        }
    }
}
