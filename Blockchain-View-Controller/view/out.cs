using Blockchain_View_Controller.controller.custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_View_Controller.view
{
    using Blockchain_View_Controller.controller.custom;

    public class @out
    {
        public static void p_error(string error_string)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[!] ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(error_string + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void p_info(string error_string)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(error_string + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }



        #region Error_Displaying
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void FormatError(exceptions.ErrorFactory.ErrorInfo error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] {error.Type}: At: ({error.Location.LocationType}): ({error.Location.LocationLiteral})");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" | {error.Message}");

            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}
