using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables for user choices and input data
            int choice, data, k, x;

            // Create a new linked list instance
            SingleLinkedList list = new SingleLinkedList();

            // Create the initial list from user input
            list.CreateList();

            // Loop to display menu and handle user operations
            while (true)
            {
                // Display the menu options
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert in empty list/Insert in beginning of the list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete any node");
                Console.WriteLine("12.Reverse the list");
                Console.WriteLine("13.Bubble sort by exchanging data");
                Console.WriteLine("14.Bubble sort by exchanging links");
                Console.WriteLine("15.MergeSort");
                Console.WriteLine("16.Insert Cycle");
                Console.WriteLine("17.Detect Cycle");
                Console.WriteLine("18.Remove cycle");
                Console.WriteLine("19.Quit");

                // Get user choice
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                // Exit the loop if user chooses to quit
                if (choice == 19)
                    break;

                // Perform action based on user's choice
                switch (choice)
                {
                    case 1:
                        // Display the linked list
                        list.DisplayList();
                        break;

                    case 2:
                        // Count the number of nodes
                        list.CountNodes();
                        break;

                    case 3:
                        // Search for a specific element
                        Console.Write("Enter the element to be searched : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;

                    case 4:
                        // Insert at the beginning
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;

                    case 5:
                        // Insert at the end
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;

                    case 6:
                        // Insert after a specific value
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;

                    case 7:
                        // Insert before a specific value
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;

                    case 8:
                        // Insert at a specific position
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position at which to insert : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;

                    case 9:
                        // Delete the first node
                        list.DeleteFirstNode();
                        break;

                    case 10:
                        // Delete the last node
                        list.DeleteLastNode();
                        break;

                    case 11:
                        // Delete a node by value
                        Console.Write("Enter the element to be deleted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;

                    case 12:
                        // Reverse the linked list
                        list.ReverseList();
                        break;

                    case 13:
                        // Sort the list using bubble sort (by data)
                        list.BubbleSortExData();
                        break;

                    case 14:
                        // Sort the list using bubble sort (by links)
                        list.BubbleSortExLinks();
                        break;

                    case 15:
                        // Sort the list using merge sort
                        list.MergeSort();
                        break;

                    case 16:
                        // Insert a cycle at a specified node
                        Console.Write("Enter the element at which the cycle has to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;

                    case 17:
                        // Check if the list contains a cycle
                        if (list.HasCycle())
                            Console.WriteLine("List has a cycle");
                        else
                            Console.WriteLine("List does not have a cycle");
                        break;

                    case 18:
                        // Remove a cycle from the list if it exists
                        list.RemoveCycle();
                        break;

                    default:
                        // Handle invalid choices
                        Console.WriteLine("Wrong choice");
                        break;
                }

                Console.WriteLine();
            }

            // Exit message
            Console.WriteLine("Exiting");
        }
    }
}
