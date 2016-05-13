using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Author: Meer Zaheen
* Date Created: May 13, 2016
* Date Modified: May 14, 2016
* Student ID: 300522487
* 
* Description: This program demonstrates GitHUB and version control 
* best practices, we also explore unit testing
*
* Version: 0.4 - Extracted outPutStringToConsole from GetUserName method
*/

namespace COMP123_s2016_Lesson1B
{
    /**
    * This is the driver class for our program
    *
    * @class Program
    * @constructor Main
    */
    class Program
    {
        /**
        * Main Method for class Program
        * 
        * @constructor Main@param {string[]} args
        */
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
        * This method reads the UserName from the console
        *
        * @method GetUserName
        * @return {string} UserName
        */

        public static string GetUserName()
        {
            // Initial Variables
            string UserName = "";

            // WriteLine makes blank space and name under, Write inputs the variable in same line
            OutputStringToConsole("Enter UserName: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n========================\n");
            Console.WriteLine("You Entered: " + UserName + "\n");

            return UserName;
        }
        
        /**
        * This method writes a string to the console. Parameters allow the user to
        * hoose to add a newLine character
        *
        * @method OutputStringToConsole
        * @param {string} outPutString
        * @param {bool} hasNewLine
        * @return {string} outPutString
        */

        private static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            if(hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.Write(outputString);
            }

            return outputString;
        }
    }
}
