using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Translate 
    {  
        public int TranslateToArabic(string value)
        {
            var romanToArabic = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };


            var letters = value.ToUpper().ToCharArray();
            var result = 0;
            
            var keys = romanToArabic.Keys;
            
            for (int index = 0; index <= letters.Length -1 ; index++)
            {
                if (index == letters.Length - 1)
                {
                    result +=  romanToArabic[letters[index]];
                    return result;
                }
                
                var current = romanToArabic[letters[index]];

                var nextIndex = index + 1;
                var next = romanToArabic[letters[nextIndex]];

                if (current < next)
                {
                    result -= current;
                }
                if(current >= next)
                {
                    result += current;
                }

            }
            
            return result;
        }

        
    }
}