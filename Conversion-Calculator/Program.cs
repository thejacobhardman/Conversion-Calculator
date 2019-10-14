using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine(new String('\n', 40));
                Console.WriteLine(@"
   ____                              _                ____      _            _       _             
  / ___|___  _ ____   _____ _ __ ___(_) ___  _ __    / ___|__ _| | ___ _   _| | __ _| |_ ___  _ __ 
 | |   / _ \| '_ \ \ / / _ \ '__/ __| |/ _ \| '_ \  | |   / _` | |/ __| | | | |/ _` | __/ _ \| '__|
 | |__| (_) | | | \ V /  __/ |  \__ \ | (_) | | | | | |__| (_| | | (__| |_| | | (_| | || (_) | |   
  \____\___/|_| |_|\_/ \___|_|  |___/_|\___/|_| |_|  \____\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|   
                                                                                                   
                
                                    1. Convert Octal to Decimal
                                    2. Convert Decimal to Octal
                                    3. Convert Binary to Decimal
                                    4. Convert Decimal to Binary
                                    5. Convert Hexadecimal to Decimal
                                    6. Convert Decimal to Hexadecimal
                                    7. Exit the Program");
            } while (choice != 7);
        }
    }
}
