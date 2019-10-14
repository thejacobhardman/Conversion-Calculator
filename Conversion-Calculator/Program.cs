using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Calculator
{
    class Program
    {
        private static void OctalToDecimal()
        {
            bool userConfirm = false;
            string userInput = "", result = string.Empty;
            int octalNumber = -1;
            double decimalNumber = 0.0;

            while (userConfirm == false)
            {
                Console.Write("Octal: ");
                userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out octalNumber))
                {
                    Console.WriteLine("\nPlease make a selection by entering an Octal.");
                }
                else
                {
                    octalNumber = Convert.ToInt32(userInput);
                    break;
                }
            }

            List<double> listOfDoubles = new List<double>();
            while (octalNumber > 0)
            {
                listOfDoubles.Add(octalNumber % 10);
                octalNumber = octalNumber / 10;
            }

            for (int i = 0; i < listOfDoubles.Count; i++)
            {
                listOfDoubles[i] = listOfDoubles[i] * Math.Pow(8, i);
                decimalNumber += listOfDoubles[i];
            }

            result = decimalNumber.ToString();

            Console.WriteLine();
            Console.WriteLine("Decimal: {0}", result);
        }

        private static void DecimalToOctal()
        {
            bool userConfirm = false;
            string userInput = "", result = string.Empty;
            double decimalNumber = 0.0;
            double remainder = 0.0;

            while (userConfirm == false)
            {
                Console.Write("Decimal: ");
                userInput = Console.ReadLine();
                if (!double.TryParse(userInput, out decimalNumber))
                {
                    Console.WriteLine("\nPlease make a selection by entering a Decimal.");
                }
                else
                {
                    decimalNumber = Convert.ToInt32(userInput);
                    break;
                }
            }

            while (decimalNumber > 8)
            {
                decimalNumber = Math.Truncate(decimalNumber) / 8;
                remainder = (decimalNumber - Math.Truncate(decimalNumber)) * 8;
                result = remainder.ToString() + result;
            }

            remainder = Math.Truncate(decimalNumber);
            result = remainder.ToString() + result;

            Console.WriteLine();
            Console.WriteLine("Octal: {0}", result);
        }

        private static void BinaryToDecimal()
        {
            bool userConfirm = false;
            string userInput = "", result = string.Empty;
            int binaryNumber = 0;
            double decimalNumber = 0.0;

            while (userConfirm == false)
            {
                Console.Write("Binary Number: ");
                userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out binaryNumber))
                {
                    Console.WriteLine("\nPlease make a selection by entering a Binary Number.");
                }
                else
                {
                    binaryNumber = Convert.ToInt32(userInput);
                    break;
                }
            }

            List<double> listOfDoubles = new List<double>();
            while (binaryNumber > 0)
            {
                listOfDoubles.Add(binaryNumber % 10);
                binaryNumber = binaryNumber / 10;
            }

            for (int i = 0; i < listOfDoubles.Count; i++)
            {
                listOfDoubles[i] = listOfDoubles[i] * Math.Pow(2, i);
                decimalNumber += listOfDoubles[i];
            }

            result = decimalNumber.ToString();

            Console.WriteLine();
            Console.WriteLine("Decimal: {0}", result);
        }

        private static void DecimalToBinary()
        {
            bool userConfirm = false;
            string userInput = "", result = string.Empty;
            int decimalNumber = -1, remainder;

            while (userConfirm == false)
            {
                Console.Write("Decimal: ");
                userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out decimalNumber))
                {
                    Console.WriteLine("\nPlease make a selection by entering a Decimal.");
                }
                else
                {
                    decimalNumber = Convert.ToInt32(userInput);
                    break;
                }
            }

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }

            Console.WriteLine();
            Console.WriteLine("Binary: {0}", result);
        }

        private static void HexadecimalToDecimal()
        {
            bool userConfirm = false, badInput = false;
            string userInput = "", result = string.Empty;
            double decimalNumber = 0.0;
            List<double> listOfDoubles = new List<double>();

            while (userConfirm == false)
            {
                badInput = false;
                Console.Write("Hexadecimal Number: ");
                userInput = Console.ReadLine();

                char[] charArray = userInput.ToCharArray();
                listOfDoubles.Clear();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (badInput == true)
                    {
                        break;
                    }
                    switch (charArray[i])
                    {
                        case '0':
                            listOfDoubles.Add(0);
                            userConfirm = true;
                            break;
                        case '1':
                            listOfDoubles.Add(1);
                            userConfirm = true;
                            break;
                        case '2':
                            listOfDoubles.Add(2);
                            userConfirm = true;
                            break;
                        case '3':
                            listOfDoubles.Add(3);
                            userConfirm = true;
                            break;
                        case '4':
                            listOfDoubles.Add(4);
                            userConfirm = true;
                            break;
                        case '5':
                            listOfDoubles.Add(5);
                            userConfirm = true;
                            break;
                        case '6':
                            listOfDoubles.Add(6);
                            userConfirm = true;
                            break;
                        case '7':
                            listOfDoubles.Add(7);
                            userConfirm = true;
                            break;
                        case '8':
                            listOfDoubles.Add(8);
                            userConfirm = true;
                            break;
                        case '9':
                            listOfDoubles.Add(9);
                            userConfirm = true;
                            break;
                        case 'A':
                            listOfDoubles.Add(10);
                            userConfirm = true;
                            break;
                        case 'B':
                            listOfDoubles.Add(11);
                            userConfirm = true;
                            break;
                        case 'C':
                            listOfDoubles.Add(12);
                            userConfirm = true;
                            break;
                        case 'D':
                            listOfDoubles.Add(13);
                            userConfirm = true;
                            break;
                        case 'E':
                            listOfDoubles.Add(14);
                            userConfirm = true;
                            break;
                        case 'F':
                            listOfDoubles.Add(15);
                            userConfirm = true;
                            break;
                        default:
                            Console.WriteLine("Make sure to input your hexadecimal value with all uppercase letters!");
                            userConfirm = false;
                            badInput = true;
                            break;
                    }
                }
            }

            if (userConfirm == true)
            {
                listOfDoubles.Reverse();

                for (int i = 0; i < listOfDoubles.Count; i++)
                {
                    listOfDoubles[i] = listOfDoubles[i] * Math.Pow(16, i);
                    decimalNumber += listOfDoubles[i];
                }

                result = decimalNumber.ToString();

                Console.WriteLine();
                Console.WriteLine("Decimal: {0}", result);
            }
        }

        private static void DecialToHexadecimal()
        {

        }

        static void Main(string[] args)
        {
            int choice = -1;
            bool userConfirm = false;
            string userInput = "";

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

                while (userConfirm == false)
                {
                    Console.Write("\n                                   Enter an option. (1-7): ");
                    userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out choice))
                    {
                        Console.WriteLine("\nPlease make a selection by entering an integer.");
                    }
                    else
                    {
                        choice = Convert.ToInt32(userInput);
                        break;
                    }
                }

                switch (choice)
                {
                    case 1:
                        OctalToDecimal();
                        break;
                    case 2:
                        DecimalToOctal();
                        break;
                    case 3:
                        BinaryToDecimal();
                        break;
                    case 4:
                        DecimalToBinary();
                        break;
                    case 5:
                        HexadecimalToDecimal();
                        break;
                    case 6:
                        DecialToHexadecimal();
                        break;
                    case 7:
                        Console.Write("Exit the Program.");
                        break;
                    default:
                        Console.Write("Please enter a valid selection.");
                        break;
                }

                Console.WriteLine("\nPlease press 'enter' to continue.");
                Console.ReadLine();



            } while (choice != 7);
        }
    }
}
