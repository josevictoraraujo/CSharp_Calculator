using System;

namespace CSharp_Calculator
{
    public class Calculator
    {
        public void Menu()
        {
            Console.WriteLine("Choose one of the operations below");
            Console.WriteLine("1-Addition\n2-Subtraction\n3-Multiplication\n4-Division\n5-Square Root\n6-Leave");
            string operation = Console.ReadLine();
            int result = 0;

            try
            {
                // Validation of the chosen operation
                if (Int32.TryParse(operation, out int option) && option >= 1 && option <= 6)
                {
                    result = option;
                    Console.WriteLine("The chosen option is valid");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("The chosen option is not valid");
                Console.WriteLine(ex.Message);
                throw;
            }

            Console.WriteLine("Option: " + operation);
            Solve(result);
        }

        public void Solve(int op)
        {
            // Variables
            double num1, num2, result;

            switch (op)
            {
                case 1:
                    Console.WriteLine("choose two numbers to perform the sum operation: ");
                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    string s1 = String.Format("{0} + {1}", num1, num2);
                    Console.WriteLine(s1);
                    result = num1 + num2;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Press ENTER to go back to the menu");
                    break;

                case 2:
                    Console.WriteLine("choose two numbers to perform the subtraction operation");
                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    string s2 = String.Format("{0} - {1}", num1, num2);
                    Console.WriteLine(s2);
                    result = num1 - num2;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Press ENTER to go back to the menu");
                    break;

                case 3:
                    Console.WriteLine("Choose two numbers to perform the multiplication operation");
                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    string s3 = String.Format("{0} * {1}", num1, num2);
                    Console.WriteLine(s3);
                    result = num1 * num2;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Press ENTER to go back to the menu");
                    break;

                case 4:
                    Console.WriteLine("Choose two numbers to perform the division operation");
                    num1 = double.Parse(Console.ReadLine());

                    // Validation to test the division denominator
                    do
                    {
                        num2 = double.Parse(Console.ReadLine());
                        if(num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero. Try insert the second number again.");
                        }

                    } while (num2 == 0);

                    Console.WriteLine("");
                    string s4 = String.Format("{0} / {1}", num1, num2);
                    Console.WriteLine(s4);

                    result = num1 / num2;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Press ENTER to go back to the menu");
                    break;

                case 5:
                    Console.WriteLine("choose a number to calculate the square root: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Press ENTER to go back to the menu");
                    break;

                case 6:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Option not found, try again.");
                    Console.WriteLine("Press ENTER to go back to the menu");
                    break;

            }
        }
    }
}
