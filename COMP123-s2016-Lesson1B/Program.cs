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
* Version: 0.2 - Added GetUserName method
*/

namespace COMP123_s2016_Lesson1B
{
    class Program
    {
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
            Console.Write("Enter UserName: ");
            UserName = Console.ReadLine();

            Console.WriteLine("/n========================");
            Console.WriteLine("You Entered: " + UserName);

            return UserName;
        }
    }
}
