

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace CIS3170_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * PART I           
             * 1. Ask for a sentence or phrase, and store as string variable named phrase.
             * 2. Write the following to the console. Label each output:
             *    a. The original string
             *    b. The string in all lowercase characters
             *    c. The string in all uppercase characters
             *    d. All of the words in the string, each on its own line ending with a comma. 
             *       (You can assume that no punctuation occurs in the phrase.)
             *    e. Whether or not the phrase is a palindrome.s Do not consider spaces or 
             *       upper- vs. lowercase when checking for palindromes.
             *    f. The string sorted so that a < b < etc. This can be case sensitive, so:
             *       "Northern Vermont University" --> "  NUVeeehiimnnnoorrrrstttvy"
             *    
             * PART II
             * 3. Ask for a character, and store as an uppercase char named originalChar. If multiple
             *    characters are entered, just use the first.
             * 4. Ask for an offset (an integer between 0 and 25, inclusive.)
             * 5. Rotate the character by the offset. So, if the original character is 'A' and the
             *    offset is 2, the rotated character is 'C'. However, is the original character is
             *    'Z', then the rotated character would be 'B'. Name this rotatedChar.
             * 6. Write the following to the console. Label each output:
             *    a. The original character, the offset, and the rotated character in the format:
             *       "orignalChar rotated by offset is rotatedChar."
             */

            /*Part 1 */

            /* 1. */
            System.Console.Write("Enter a phrase no punctuation please: ");
            string phrase = System.Console.ReadLine();

            /* 2. */
            /*a*/ System.Console.WriteLine($"This is the orginal phrase: \"{ phrase}\"");
            /*b*/ System.Console.WriteLine($"This is the phrase in all lowercase: \"{phrase.ToLower()}\"");
            /*c*/ System.Console.WriteLine($"This is the phrase in all uppercase: \"{phrase.ToUpper()}\"");
            /*d*/ System.Console.WriteLine($"Comma separated: \n{ phrase.Replace(" ", ", \n")}");
            /*e*/
            string reverse = phrase.Replace(" ", "");
            reverse = reverse.ToLower();
            char[] tempChar = reverse.ToCharArray();
            System.Array.Reverse(tempChar);
            System.Console.WriteLine($"\"{phrase}\" is a palindrome: " + (new string(tempChar) == phrase.ToLower().Replace(" ", "")));
            /*f*/
            tempChar = phrase.ToCharArray();
            System.Array.Sort(tempChar);
            System.Console.WriteLine($"Sorted inputed sentence: \"{new string(tempChar)}\"");

            /* Part 2 */
            /*3*/
            System.Console.WriteLine($"Enter just ONE letter of your choice: ");
            char originalChar = System.Console.ReadLine().ToUpper()[0];
            System.Console.WriteLine($"The orginial character; {originalChar}");
            /*4*/
            System.Console.WriteLine($"Enter an offset integer between 0 and 25: ");
            /*5*/
            int offset = int.Parse(System.Console.ReadLine());
            char rotatedChar = (char)((originalChar - 'A' + offset) % 26 + 'A');
            /*6*/
            System.Console.WriteLine($"{originalChar} rotated by {offset} is {rotatedChar}");



        }
    }
}
