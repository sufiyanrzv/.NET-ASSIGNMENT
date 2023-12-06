using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Dividend: ");
                int dividend = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int result = dividend / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero exception handled: " + ex.Message);
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                int value = arr[5];
                Console.WriteLine("Value: " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range exception handled: " + ex.Message);
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = "abc";
                int value = Convert.ToInt32(input);
                Console.WriteLine("Value: " + value);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception handled: " + ex.Message);
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques4
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) 
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = -5;
                if (age < 0)
                {
                    throw new CustomException("Age cannot be negative.");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom exception handled: " + ex.Message);
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Outer Try Block");
                try
                {
                    Console.WriteLine("Inner Try Block");
                    throw new Exception("Inner Exception");
                }
                catch (Exception innerExMessage)
                {
                    Console.WriteLine("Inner Catch Block: " + innerExMessage.Message);
                }
                //Here First Inner block exception is Handled and after that the outer exception is handled.
                Console.WriteLine("After Inner Try-Catch");
                throw new Exception("Inner Exception");
            }
            catch (Exception outerEx)
            {
                Console.WriteLine("Outer Catch Block: " + outerEx.Message);
            }
            Console.WriteLine("After Outer Try-Catch");
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the dividend: ");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    if (divisor == 0)
                    {
                        throw new DivideByZeroException("Division can't be Zero!!.");
                    }
                    double result = (double) dividend / divisor;
                    Console.WriteLine("Result of division: " + result);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numeric values.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DivideByZeroMethod();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught and handled exception: " + ex.Message);
            }
        }

        static void DivideByZeroMethod()
        {
            try
            {
                int dividend = 10;
                int divisor = 0;
                int result = dividend / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
                throw;
            }
        }
    }
}





﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Calculator Menu:");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Quit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 5)
                    {
                        break;
                    }
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double result = 0;
                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            break;
                        case 2:
                            result = num1 - num2;
                            break;
                        case 3:
                            result = num1 * num2;
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("Division by zero is not allowed.");
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid operation.");
                            continue;
                    }
                    Console.WriteLine("Result: " + result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numeric values.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxAllowedPrice = 10000;
            int[] shoppingCart = new int[10];
            int itemCount = 0;
            int totalPrice = 0;
            Console.WriteLine("Welcome to the shopping cart!");
            Console.WriteLine("Please enter the price of items (enter a negative price to finish):");
            while (true)
            {
                try
                {
                    Console.Write("Item " + (itemCount + 1) + ": $");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Please enter a valid price.");
                        continue;
                    }
                    int price = int.Parse(input);
                    if (price < 0)
                    {
                        throw new NegativePriceException();
                    }
                    if (price > maxAllowedPrice)
                    {
                        throw new PriceTooHighException();
                    }
                    shoppingCart[itemCount] = price;
                    totalPrice += price;
                    itemCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input: Please enter a valid price.");
                }
                catch (NegativePriceException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                catch (PriceTooHighException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input: Price value is too high.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
                if (itemCount >= shoppingCart.Length || totalPrice >= maxAllowedPrice)
                {
                    break;
                }
            }
            Console.WriteLine("Items in your shopping cart:");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine("Item " + (i + 1) + ": $" + shoppingCart[i]);
            }
            Console.WriteLine("Total Price: $" + totalPrice);
        }
    }
    class NegativePriceException : Exception
    {
        public NegativePriceException() : base("Invalid price: Price cannot be negative.") 
        { 
        }
    }

    class PriceTooHighException : Exception
    {
        public PriceTooHighException() : base("Invalid price: Price exceeds the maximum allowed.") 
        { 
        }
    }
}