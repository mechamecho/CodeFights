using System;
using System.Collections.Generic;

namespace firstNotRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public char FirstNotRepeatingCharacter(string s)
        {
            List<char> characters = new List<char>();
            var distinctChars = new List<char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (characters.Contains(s[i]))
                {
                    if (distinctChars.Contains(s[i]))
                    {
                        distinctChars.Remove(s[i]);
                    }
                }
                else
                {
                    distinctChars.Add(s[i]);
                }
                characters.Add(s[i]);
            }
            if (distinctChars.ToArray().Length != 0)
                return distinctChars[0];
            return '_';


        }
    }

   

}
