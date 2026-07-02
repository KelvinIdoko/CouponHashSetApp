using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a HashSet to store used coupon numbers
        // HashSet ensures fast lookup and no duplicates
        HashSet<string> usedCoupons = new HashSet<string>();

        while (true)
        {
            // Ask user to enter a coupon number
            Console.Write("Enter the coupon number: ");
            string input = Console.ReadLine();

            // Stop condition (non-numeric input like "e")
            if (!int.TryParse(input, out int coupon))
            {
                break;
            }

            // Check if coupon has already been used
            if (usedCoupons.Contains(input))
            {
                Console.WriteLine("Sorry, a coupon can be used only once.");
            }
            else
            {
                // Mark coupon as used
                usedCoupons.Add(input);
                Console.WriteLine("Success!");
            }
        }

        // Display all used coupons
        Console.WriteLine("A list of used coupons:");

        foreach (string coupon in usedCoupons)
        {
            Console.Write(coupon + " ");
        }
    }
}