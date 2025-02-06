// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

using System.Linq.Expressions;

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productInventory = new List<string>();
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
                    Console.Write("Enter Product Quantity: ");
                    int wawa = int.Parse(Console.ReadLine());
                    productInventory.Add(newProduct);
                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {
                    foreach (string product in productInventory)
                    {
                        Console.WriteLine(product);
                    }
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
