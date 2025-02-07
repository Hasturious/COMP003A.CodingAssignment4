// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productInventory = new List<string>(); //Declares our inventory list
            List<int> productAmount = new List<int>(); //Declares our quantity lsit
            int choice = 0; //Decares our choice function

            while (choice != 4) //When we reach the end of any of the below if/else statements we get to go to the menu again
            {
                Console.Write("1. Add a Product \n2. Update Product Summary \n3. View Inventory Summary \n4. Exit\nEnter Option: ");
                //Basic try/catch system to prevent an invalid options from breaking the code
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
                    //create new product in the list
                    Console.Write("Enter Product Name: ");
                    string newProduct = Console.ReadLine();
                    productInventory.Add(newProduct);
     
                    //adds a qauntity to the list
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
                    //writes the contents of the inventory list so the user doesnt have to remember the name/spelling
                    Console.Write($"Make change to what product ({string.Join(",", productInventory)}):\n");
                    string changeProduct = Console.ReadLine();

                    //Find index searches for an occurance in the list. The expression below matches the product in the list and the string in changeProduct
                    int index = productInventory.FindIndex(p => p.Equals(changeProduct));

                    if (index != -1) // Product exists
                    {
                        Console.Write("New Quantity: ");
                        //Declares our updatedProduct and ensures its a valid interger
                        if (int.TryParse(Console.ReadLine(), out int updatedProduct) && updatedProduct >= 0)
                        {
                            //The code in choice == 1 makes sure that our product and quantity have the same index number
                            //by determining the index of a product name we learn the index of the qauntity assigned to it
                            //so we re-assign that index and it works!
                            productAmount[index] = updatedProduct; // Update quantity
                            Console.WriteLine($"Updated {productInventory[index]} is now {productAmount[index]}.");
                        }
                        else
                        {
                            //ensures we wrote a valid interger
                            Console.WriteLine("Invalid quantity! Please enter a valid number.");
                        }
                    }
                    else
                    {
                        //ensures we wrote a valid product
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (choice == 3)
                {
                    //the for statment counts through each product in the list and writes them along with their quantity
                    for (int i = 0; i < productInventory.Count; i++)
                    {
                        Console.WriteLine(productInventory[i] + ": " + productAmount[i]);
                    }
                    //then we can get the number of unique products next to the sum of them
                    Console.WriteLine($"Total Products: {productInventory.Count}\nTotal Quantity: {productAmount.Sum()}");
                    //divide for an average
                    Console.WriteLine($"Average Quantity: {productAmount.Sum() / productInventory.Count}.00");
                }
                else if (choice == 4)
                {
                    //now that choice == 4 the menu will stop reapeating
                    Console.WriteLine("Goodbye!");
                    Console.ReadKey(); //On any keystroke the terminal closes
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
        }
    }
}
