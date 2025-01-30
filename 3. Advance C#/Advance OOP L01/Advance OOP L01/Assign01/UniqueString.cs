using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal class UniqueString<T> where T : IEquatable<T>, IComparable<T>
    {
        public int FindFirstUniqueIndex(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;  

            Dictionary<T, int> charCount = new Dictionary<T, int>();
            Dictionary<T, int> charIndex = new Dictionary<T, int>();


            for (int i = 0; i < input.Length; i++)
            {
                T character = (T)(object)input[i]; 

                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    charCount[character] = 1;
                    charIndex[character] = i;
                }
            }


            foreach (var ch in charIndex)
            {
                if (charCount[ch.Key] == 1)
                    return ch.Value; 
            }

            return -1;  
        }
    }
}
