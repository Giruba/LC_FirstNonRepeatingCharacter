using System;

namespace LC_FirstNonRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Non-repeating character in String!");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Enter the string whose non-repeating " +
                "   character's index has to be found");
            try
            {
                string s = Console.ReadLine();
                int index = GetFirstNonRepeatingCharacter(s);
                if (index == -1)
                {
                    Console.WriteLine("No non-repeating character found" +
                        " in the string");
                }
                else {
                    Console.WriteLine("The first non-repeating character" +
                        " is found at index "+index);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static int GetFirstNonRepeatingCharacter(string s) {
            int[] hash = new int[256];

            for (int i = 0; i < s.Length; i++) {
                int index = (int)s[i] - 97;
                hash[index]++;
            }
            for (int i = 0; i < s.Length; i++) {
                int index = (int)s[i] - 97;
                if (hash[index] == 1) {
                    return i;
                }
            }
            return -1;
        }
    }
}
