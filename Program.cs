namespace ConsoleAppprodassessment4
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the number of products
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            // Dictionary to store product details
            Dictionary<int, (string name, decimal price)> products = new Dictionary<int, (string, decimal)>();

            // Get the product details
            Console.Write("Enter the product details (ID:Name:Price): ");
            string[] productDetails = Console.ReadLine().Split(' ');

            // Populate the product dictionary
            foreach (var detail in productDetails)
            {
                var parts = detail.Split(':');
                int id = int.Parse(parts[0]);
                string name = parts[1];
                decimal price = decimal.Parse(parts[2]);
                products[id] = (name, price);
            }

            // Get the product ID to update
            Console.Write("Enter the product id: ");
            int productId = int.Parse(Console.ReadLine());

            // Get the new amount to update
            Console.Write("Enter the amount to update: ");
            decimal newAmount = decimal.Parse(Console.ReadLine());

            // Check if the product ID exists and update the price
            if (products.ContainsKey(productId))
            {
                // Update the product price
                var product = products[productId];
                products[productId] = (product.name, newAmount);

                // Output the updated product details
                Console.WriteLine($"{product.name} {newAmount}");
            }
            else
            {
                // Handle invalid product ID
                Console.WriteLine("Invalid id");
            }
        }
    }
}