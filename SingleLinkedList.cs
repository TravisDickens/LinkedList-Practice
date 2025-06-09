using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        // Reference to the first node in the list
        private Node start;

        // Constructor to initialize the list
        public SingleLinkedList()
        {
            start = null;
        }

        // Display all nodes in the list
        public void DisplayList()
        {
            Node p;

            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.WriteLine("List is: ");

            p = start;
            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }

            Console.WriteLine();
        }

        // Count the number of nodes in the list
        public void CountNodes()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            int n = 0;
            p = start;

            while (p != null)
            {
                n++;
                p = p.link;
            }

            Console.WriteLine("The number of nodes are: " + n);
        }

        // Search for a node with given data
        public bool Search(int x)
        {
            int position = 1;
            Node p = start;

            while (p != null)
            {
                if (p.info == x)
                {
                    Console.WriteLine(x + " is at position " + position);
                    return true;
                }
                p = p.link;
                position++;
            }

            Console.WriteLine(x + " not found in the list");
            return false;
        }

        // Insert a node at the beginning
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        // Insert a node at the end
        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            Node p = start;
            while (p.link != null)
                p = p.link;

            p.link = temp;
        }

        
        public void CreateList()
        {
            Console.WriteLine("Enter the number of nodes ?");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted");
                int data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        // Insert a node after a specific value
        public void InsertAfter(int data, int x)
        {
            Node p = start;

            while (p != null)
            {
                if (p.info == x)
                    break;

                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(x + " Not present in the list");
            }
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        // Insert a node before a specific value
        public void InsertBefore(int data, int x)
        {
            // If list is empty
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // If inserting before the first node
            if (start.info == x)
            {
                Node temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;

                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine(x + " not present in the list");
            }
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        // Insert a node at a specific position
        public void InsertAtPosition(int k, int data)
        {
            if (k == 1)
            {
                Node temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (int i = 1; i < k - 1 && p != null; i++)
                p = p.link;

            if (p == null)
            {
                Console.WriteLine("You can insert only up to position " + (k - 1));
            }
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        // Delete the first node
        public void DeleteFirstNode()
        {
            if (start == null)
                return;

            start = start.link;
        }

        // Delete the last node
        public void DeleteLastNode()
        {
            if (start == null)
                return;

            if (start.link == null)
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.link.link != null)
                p = p.link;

            p.link = null;
        }

        // Delete a node with specific data
        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (start.info == x)
            {
                start = start.link;
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;

                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine("Element " + x + " not found");
            }
            else
            {
                p.link = p.link.link;
            }
        }

        // Reverse the linked list
        public void ReverseList()
        {
            Node previous = null, current = start, next;

            while (current != null)
            {
                next = current.link;
                current.link = previous;
                previous = current;
                current = next;
            }

            start = previous;
        }

        // Bubble sort using data exchange
        public void BubbleSortExData()
        {
            Node end, p, q;
            int temp;

            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;

                    if (p.info > q.info)
                    {
                        temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        // Bubble sort using link exchange
        public void BubbleSortExLinks()
        {
            if (start == null || start.link == null)
                return;

            Node end = null;

            while (end != start.link)
            {
                Node r = null, p = start, q = start.link;

                while (q != end)
                {
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;

                        if (r != null)
                            r.link = q;
                        else
                            start = q;

                        r = q;
                        q = p.link;
                    }
                    else
                    {
                        r = p;
                        p = p.link;
                        q = q.link;
                    }
                }

                end = p;
            }
        }

        // Recursive merge sort
        private Node MergeSortRec(Node head)
        {
            if (head == null || head.link == null)
                return head;

            Node middle = GetMiddle(head);
            Node nextOfMiddle = middle.link;
            middle.link = null;

            Node left = MergeSortRec(head);
            Node right = MergeSortRec(nextOfMiddle);

            return MergeTwoSortedLists(left, right);
        }

        // Find the middle node using the slow-fast pointer technique
        private Node GetMiddle(Node head)
        {
            if (head == null)
                return head;

            Node slow = head, fast = head;

            while (fast.link != null && fast.link.link != null)
            {
                slow = slow.link;
                fast = fast.link.link;
            }

            return slow;
        }

        // Merge two sorted linked lists
        private Node MergeTwoSortedLists(Node a, Node b)
        {
            if (a == null) return b;
            if (b == null) return a;

            Node result;

            if (a.info <= b.info)
            {
                result = a;
                result.link = MergeTwoSortedLists(a.link, b);
            }
            else
            {
                result = b;
                result.link = MergeTwoSortedLists(a, b.link);
            }

            return result;
        }

        // Public method to start merge sort
        public void MergeSort()
        {
            start = MergeSortRec(start);
        }

        // Insert a cycle by connecting the last node to a node with specified data
        public void InsertCycle(int data)
        {
            if (start == null)
                return;

            Node p = start, targetNode = null;

            while (p.link != null)
            {
                if (p.info == data)
                    targetNode = p;

                p = p.link;
            }

            if (targetNode != null)
            {
                p.link = targetNode;
                Console.WriteLine("Cycle inserted at node with value " + data);
            }
            else
            {
                Console.WriteLine("Node not found, cycle not created");
            }
        }

        // Detect if a cycle exists in the list
        public bool HasCycle()
        {
            Node slow = start, fast = start;

            while (fast != null && fast.link != null)
            {
                slow = slow.link;
                fast = fast.link.link;

                if (slow == fast)
                    return true;
            }

            return false;
        }

        // Remove a cycle if it exists
        public void RemoveCycle()
        {
            if (start == null || start.link == null)
                return;

            Node slow = start, fast = start;

            while (fast != null && fast.link != null)
            {
                slow = slow.link;
                fast = fast.link.link;

                if (slow == fast)
                    break;
            }

            if (fast == null || fast.link == null)
                return;

            slow = start;

            if (slow == fast)
            {
                while (fast.link != slow)
                    fast = fast.link;
            }
            else
            {
                while (slow.link != fast.link)
                {
                    slow = slow.link;
                    fast = fast.link;
                }
            }

            fast.link = null;
            Console.WriteLine("Cycle removed");
        }
    }
}
