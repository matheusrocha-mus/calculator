using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\n");

            Console.WriteLine("_____________________________");
            Console.WriteLine("| _________________________ |");
            Console.WriteLine("| |                       | |");
            Console.WriteLine("| |                       | |");
            Console.WriteLine("| |                       | |");
            Console.WriteLine("| |                       | |");
            Console.WriteLine("| |                       | |");
            Console.WriteLine("| |                       | |");
            Console.WriteLine("| ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾ |");
            Console.WriteLine("| _____ _____ _____   _____ |");
            Console.WriteLine("| | 1 | | 2 | | 3 |   | + | |");
            Console.WriteLine("| ‾‾‾‾‾ ‾‾‾‾‾ ‾‾‾‾‾   ‾‾‾‾‾ |");
            Console.WriteLine("| _____ _____ _____   _____ |");
            Console.WriteLine("| | 4 | | 5 | | 6 |   | - | |");
            Console.WriteLine("| ‾‾‾‾‾ ‾‾‾‾‾ ‾‾‾‾‾   ‾‾‾‾‾ |");
            Console.WriteLine("| _____ _____ _____   _____ |");
            Console.WriteLine("| | 7 | | 8 | | 9 |   | x | |");
            Console.WriteLine("| ‾‾‾‾‾ ‾‾‾‾‾ ‾‾‾‾‾   ‾‾‾‾‾ |");
            Console.WriteLine("| _____ _____ _____   _____ |");
            Console.WriteLine("| |mod| | 0 | |a^n|   | ÷ | |");
            Console.WriteLine("| ‾‾‾‾‾ ‾‾‾‾‾ ‾‾‾‾‾   ‾‾‾‾‾ |");
            Console.WriteLine("‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾");

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();

            bool valid_entry;
            bool end_app;
            var input = "0";

            do
            {

                do
                {

                    Console.WriteLine("Choose operation:");
                    Console.WriteLine("\n1) Addition");
                    Console.WriteLine("2) Subtraction");
                    Console.WriteLine("3) Multiplication");
                    Console.WriteLine("4) Division");
                    Console.WriteLine("5) Mod");
                    Console.WriteLine("6) Exponentiation\n");

                    input = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    double x = 0;
                    double y = 0;
                    double z = 0;

                    switch (input.ToLower())
                    {
                        case "addition":
                        case "1":
                            valid_entry = true;
                            Console.WriteLine("You chose: Addition\n");
                            Console.WriteLine("Enter first addend:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter second addend:");
                            y = Convert.ToDouble(Console.ReadLine());
                            z = x + y;
                            Console.WriteLine("Total: " + z);
                            break;

                        case "subtraction":
                        case "2":
                            valid_entry = true;
                            Console.WriteLine("You chose: Subtraction\n");
                            Console.WriteLine("Enter minuend:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter subtrahend:");
                            y = Convert.ToDouble(Console.ReadLine());
                            z = x - y;
                            Console.WriteLine("Difference: " + z);
                            break;

                        case "multiplication":
                        case "3":
                            valid_entry = true;
                            Console.WriteLine("You chose: Multiplication\n");
                            Console.WriteLine("Enter first factor:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter second factor:");
                            y = Convert.ToDouble(Console.ReadLine());
                            z = x * y;
                            Console.WriteLine("Product: " + z);
                            break;

                        case "division":
                        case "4":
                            valid_entry = true;
                            Console.WriteLine("You chose: Division\n");
                            Console.WriteLine("Enter dividend:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter divisor:");
                            y = Convert.ToDouble(Console.ReadLine());
                            z = x / y;
                            Console.WriteLine("Quotient: " + z);
                            break;

                        case "mod":
                        case "5":
                            valid_entry = true;
                            Console.WriteLine("You chose: Mod\n");
                            Console.WriteLine("Enter dividend:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter divisor:");
                            y = Convert.ToDouble(Console.ReadLine());
                            z = x % y;
                            Console.WriteLine("Remainder: " + z);
                            break;

                        case "exponentiation":
                        case "6":
                            valid_entry = true;
                            Console.WriteLine("You chose: Exponentiation\n");
                            Console.WriteLine("Enter base:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter exponent:");
                            y = Convert.ToDouble(Console.ReadLine());
                            z = Math.Pow(x, y);
                            Console.WriteLine("Power: " + z);
                            break;

                        default:
                            valid_entry = false;
                            break;
                    }

                } while (valid_entry == false);

                Console.WriteLine("\nWould you like to do another operation?\n");
                Console.WriteLine("1) Yes\n2) No");
                input = Convert.ToString(Console.ReadLine());

                do
                {
                    if (input.ToLower() == "yes" || input == "1")
                    {
                        valid_entry = true;
                        end_app = false;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "no" || input == "2")
                    {
                        valid_entry = true;
                        end_app = true;
                        Console.WriteLine("Thank you for using our calculator!");
                        System.Threading.Thread.Sleep(2500);
                        Environment.Exit(0);
                    }

                    else
                    {
                        valid_entry = false;
                        end_app = false;
                        Console.Clear();
                        Console.WriteLine("Please input a valid option.\n");
                    }

                } while (valid_entry == false);

            } while (end_app == false);

        }
    }
}
