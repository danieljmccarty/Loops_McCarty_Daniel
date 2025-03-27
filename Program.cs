namespace Loops_McCarty_Daniel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the game question
            Console.WriteLine("why do you wnt to make games?");
            string response = Console.ReadLine();

            Console.WriteLine($"The sentence,\"{response}\" has{CountnumberOfspaces(response)} spaces in it.");

            // the whole number question
            Console.WriteLine("please enter a whole number!");
            string response2 = Console.ReadLine();

            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>Number of spaces in the sentence</returns>
        
        // counts the spaces
        static int CountnumberOfspaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character  in sentence) 
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        // sum of digits
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }

    }
}