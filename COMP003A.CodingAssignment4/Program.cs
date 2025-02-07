// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productInventory = new List<string>();
            List<int> productAmount = new List<int>();
            int choice = 0;

            while (choice != 4)
            {
                Console.Write("1. Add a Product \n2. Update Product Summary \n3. View Inventory Summary \n4. Exit\nEnter Option: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (choice == 1)
                {
                    Console.Write("Enter Product Name: ");
                    string newProduct = Console.ReadLine();
                    productInventory.Add(newProduct);
     
                    Console.Write("Enter Product Quantity: ");
                    try
                    {
                        int amount = int.Parse(Console.ReadLine());
                        productAmount.Add(amount);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (choice == 2)
                {
                    Console.Write($"Make change to what product ({string.Join(",", productInventory)}):\n");
                    string changeProduct = Console.ReadLine();

                    int index = productInventory.FindIndex(p => p.Equals(changeProduct, StringComparison.OrdinalIgnoreCase));

                    if (index != -1) // Product exists
                    {
                        Console.Write("New Quantity: ");
                        if (int.TryParse(Console.ReadLine(), out int updatedProduct) && updatedProduct >= 0)
                        {
                            productAmount[index] = updatedProduct; // Update quantity
                            Console.WriteLine($"Updated {productInventory[index]} is now {productAmount[index]}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity! Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (choice == 3)
                {
                    for (int i = 0; i < productInventory.Count; i++)
                    {
                        Console.WriteLine(productInventory[i] + ": " + productAmount[i]);
                    }
                    Console.WriteLine($"Total Products: {productInventory.Count}\nTotal Quantity: {productAmount.Sum()}");
                    Console.WriteLine($"Average Quantity: {productAmount.Sum() / productInventory.Count}.00");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadKey(); //On any keystroke the terminal closes
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
        }
    }
}
