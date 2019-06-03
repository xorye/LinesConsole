using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class UserInput
    {

        /// <summary>
        /// Prompts the user to enter the player name.
        /// </summary>
        public static String GetPlayerName()
        {
            Console.WriteLine("Enter the player's name");
            return ReadLine();
        }

        /// <summary>
        /// Promts the user to enter the source and destination nodes
        /// for their current move's edge
        /// </summary>
        /// <returns></returns>
        public static Edge GetEdge()
        {
            Console.WriteLine("Enter a move: ");
            int userInput = GetInteger();
            Edge newEdge;

            while (true)
            {
                try
                {
                    newEdge = new Edge(userInput);
                    return newEdge;
                }
                catch (InvalidEdgeException)
                {
                    userInput = GetInteger();
                }
            }
        }

        private static int GetInteger()
        {
            String input = ReadLine();
            int result;

            while (true)
            {
                try
                {
                    result = Int32.Parse(input);
                    return result;
                }
                catch (System.FormatException)
                {
                    input = ReadLine();
                }
            }
        }

        /// <summary>
        /// Returns two integers from user input
        /// </summary>
        /// <returns></returns>
        private static int[] GetTwoIntegers()
        {
            String input = ReadLine();
            while (!IsTwoIntegers(input))
            {
                input = ReadLine();
            }

            int[] result = new int[2];
            String[] nodes = input.Split(',');
            result[0] = Int32.Parse(nodes[0]);
            result[1] = Int32.Parse(nodes[1]);
            return result;
        }

        private static String ReadLine()
        {
            return Console.ReadLine().Trim();
        }

        /// <summary>
        /// Returns true iff input string is only seperated by one comma and contains
        /// only two integers. This method does not check if the nodes represented by the
        /// two integers are adjacent. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static Boolean IsTwoIntegers(String input)
        {
            return IsSeperatedByOneComma(input) && ContainsIntegers(input);
        }

        private static Boolean IsSeperatedByOneComma(String input)
        {
            return input.Split(',').Length == 2;
        }

        /// <summary>
        /// Returns true iff comma separated string contains only integers
        /// </summary>
        /// <param name="input">Comma separated string</param>
        /// <returns></returns>
        private static Boolean ContainsIntegers(String input)
        {
            try
            {
                String[] nodes = input.Split(',');
                for (int i = 0; i < nodes.Length; i++)
                {
                    Int32.Parse(nodes[i]);
                }
                
            }
            catch (System.FormatException)
            {
                return false;
            }
            return true;
        }

    }
}
