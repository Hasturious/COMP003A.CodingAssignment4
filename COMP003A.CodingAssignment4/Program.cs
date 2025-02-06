// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inventory = new int[10];


            Menu();





            static void Menu()
            {
                Console.Write("1. Add a Product \n2. Update Product Summary \n3. View Inventory Summary \n4. Exit\nEnter Option:");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
            
                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {

                }
                else
                {
                Console.WriteLine("Invalid Input");
                Menu();
                }
            }
        }
    }
}
