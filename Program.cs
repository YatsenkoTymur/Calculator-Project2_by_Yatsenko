using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Test_Projekt2_TymursCalculator_coolemoji_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE TYMUR'S CALCULATOR (COOL_EMOJI)(COOL_EMOJI)(EXPLOSION_EMOJI)");

            double OutX = 0;
            double OutY = 0;

            while (true) // Makes infinite cycle
            {
                Console.WriteLine("Select the mathematic operation that you want to make! \n1: Addition \n2: Subtraction \n3: Multiplication \n4: Subdivision\n5: Exponentiation\n#: Exit");
                string InOperation = Console.ReadLine(); // Reads user input and stores it
                int OutOperation = 0; // Creates a placeholder for the converted variable
                if (InOperation == "#") // If user input is "#"
                {
                    return; // Make nothing, hereby ending the program
                }
                else if (!Int32.TryParse(InOperation, out OutOperation)) // TryParse stores converted variable into the second (out) variable. It also returns boolean "True" if conversion has been completed successfully (in this case, the ! sign means logic NOT)
                {
                    Console.WriteLine("Please, input your answer as an integer!");
                    continue; // Return to the beginning of the code
                }
                else
                {
                    OutOperation = Convert.ToInt32(InOperation); // Converts InOperation (str) to OutOperation (int)
                    if (OutOperation == 1) // If converted user input is 1
                    {
                        // Addition
                        Console.WriteLine("Input the first number:");
                        string InX = Console.ReadLine(); // User input is stored in InX
                        if (!Double.TryParse(InX, out OutX)) // Error catching when converting InX (str) to OutX (double)
                        {
                            Console.WriteLine("Please, input your first number as a double!");
                            continue; // Return to the beginning of the code
                        }
                        else
                        {
                            OutX = Convert.ToDouble(InX); // Converts InX (str) to OutX (double)
                            Console.WriteLine("Input the second number:");
                            string InY = Console.ReadLine(); // User input is stored in InY
                            if (!Double.TryParse(InY, out OutY)) // Error catching when converting InY (str) to OutY (double)
                            {
                                Console.WriteLine("Please, input your second number as a double!");
                                continue; // Return to the beginning of the code
                            }
                            else
                            {
                                OutY = Convert.ToDouble(InY); // Converts InY (str) to OutY (double)
                                double Result = OutX + OutY; // Stores Result as an addition of OutX and OutY
                                Console.WriteLine("The result is: " + Result.ToString("N12")); // Prints Result showing the 12 signs after the comma
                            }
                        }
                    }
                    else if (OutOperation == 2) // If converted user input is 2
                    {
                        // Subtraction
                        Console.WriteLine("Input the first number:");
                        string InX = Console.ReadLine(); // User input is stored in InX
                        if (!Double.TryParse(InX, out OutX)) // Error catching when converting InX (str) to OutX (double)
                        {
                            Console.WriteLine("Please, input your first number as a double!");
                            continue; // Return to the beginning of the code
                        }
                        else
                        {
                            OutX = Convert.ToDouble(InX); // Converts InX (str) to OutX (double)
                            Console.WriteLine("Input the second number:");
                            string InY = Console.ReadLine(); // User input is stored in InY
                            if (!Double.TryParse(InY, out OutY)) // Error catching when converting InY (str) to OutY (double)
                            {
                                Console.WriteLine("Please, input your second number as a double!");
                                continue; // Return to the beginning of the code
                            }
                            else
                            {
                                OutY = Convert.ToDouble(InY); // Converts InY (str) to OutY (double)
                                double Result = OutX - OutY; // Stores Result as a subtraction of OutX and OutY
                                Console.WriteLine("The result is: " + Result.ToString("N12")); // Prints Result showing the 12 signs after the comma
                            }
                        }
                    }
                    else if (OutOperation == 3) // If converted user input is 3
                    {
                        // Multiplication
                        Console.WriteLine("Input the first number:");
                        string InX = Console.ReadLine(); // User input is stored in InX
                        if (!Double.TryParse(InX, out OutX)) // Error catching when converting InX (str) to OutX (double)
                        {
                            Console.WriteLine("Please, input your first number as a double!");
                            continue; // Return to the beginning of the code
                        }
                        else
                        {
                            OutX = Convert.ToDouble(InX); // Converts InX (str) to OutX (double)
                            Console.WriteLine("Input the second number:");
                            string InY = Console.ReadLine(); // User input is stored in InY
                            if (!Double.TryParse(InY, out OutY)) // Error catching when converting InY (str) to OutY (double)
                            {
                                Console.WriteLine("Please, input your second number as a double!");
                                continue; // Return to the beginning of the code
                            }
                            else
                            {
                                OutY = Convert.ToDouble(InY); // Converts InY (str) to OutY (double)
                                double Result = OutX * OutY; // Stores Result as a multiplication of OutX and OutY
                                Console.WriteLine("The result is: " + Result.ToString("N12")); // Prints Result showing the 12 signs after the comma
                            }
                        }
                    }
                    else if (OutOperation == 4) // If converted user input is 4
                    {
                        // Subdivision
                        Console.WriteLine("Input the first number:");
                        string InX = Console.ReadLine(); // User input is stored in InX
                        if (!Double.TryParse(InX, out OutX)) // Error catching when converting InX (str) to OutX (double)
                        {
                            Console.WriteLine("Please, input your first number as a double!");
                            continue; // Return to the beginning of the code
                        }
                        else
                        {
                            OutX = Convert.ToDouble(InX); // Converts InX (str) to OutX (double)
                            Console.WriteLine("Input the second number:");
                            string InY = Console.ReadLine(); // User input is stored in InY
                            if (!Double.TryParse(InY, out OutY)) // Error catching when converting InY (str) to OutY (double)
                            {
                                Console.WriteLine("Please, input your second number as a double!");
                                continue; // Return to the beginning of the code
                            }
                            else
                            {
                                OutY = Convert.ToDouble(InY); // Converts InY (str) to OutY (double)
                                double Result = OutX / OutY; // Stores Result as a subdivision of OutX and OutY
                                Console.WriteLine("The result is: " + Result.ToString("N12")); // Prints Result showing the 12 signs after the comma
                            }
                        }
                    }
                    else if (OutOperation == 5) // If converted user input is 5
                    {
                        // Exponentiation
                        Console.WriteLine("Input the first number:");
                        string InX = Console.ReadLine(); // User input is stored in InX
                        if (!Double.TryParse(InX, out OutX)) // Error catching when converting InX (str) to OutX (double)
                        {
                            Console.WriteLine("Please, input your first number as a double!");
                            continue; // Return to the beginning of the code
                        }
                        else
                        {
                            OutX = Convert.ToDouble(InX); // Converts InX (str) to OutX (double)
                            Console.WriteLine("Input the second number:");
                            string InY = Console.ReadLine(); // User input is stored in InY
                            if (!Double.TryParse(InY, out OutY)) // Error catching when converting InY (str) to OutY (double)
                            {
                                Console.WriteLine("Please, input your second number as a double!!");
                                continue; // Return to the beginning of the code
                            }
                            else
                            {
                                OutY = Convert.ToDouble(InY); // Converts InY (str) to OutY (double)
                                double Result = Math.Pow(OutX, OutY); // Stores Result as an exponentiation of OutX in power of OutY
                                Console.WriteLine("The result is: " + Result.ToString("N12")); // Prints Result showing the 12 signs after the comma
                            }
                        }
                    }
                    else // When int is below or above 1-5
                    {
                        Console.WriteLine("Please, input an integer from 1 to 5!!");
                        continue; // Return to the beginning of the code
                    }
                }
            }
        }
    }
}
