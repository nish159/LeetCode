// IMPLEMENT A SINGLY LINKED LIST

// Node class for a singly linked list
public class ListNode
{
    public int val; // Value of the node
    public ListNode next; // Pointer to the next node in the list
    
    // Constructor to initialize a node with a given value and optional next pointer
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

// Linked list class
public class LinkedList
{
    public ListNode head; // Pointer to the first node in the list (head)

    // Constructor to initialize an empty linked list
    public LinkedList()
    {
        head = null; // Initialize head to null indicating an empty list
    }

    // Method to add a node with a given value to the end of the list
    public void AddNode(int val)
    {
        ListNode newNode = new ListNode(val); // Create a new node with the given value
        if (head == null) // If the list is empty, set the new node as the head
            head = newNode;
        else
        {
            ListNode current = head; // Start traversal from the head
            while (current.next != null) // Traverse until the last node
                current = current.next;
            current.next = newNode; // Set the next pointer of the last node to the new node
        }
    }

    // Method to print the elements of the linked list
    public void PrintList()
    {
        ListNode current = head; // Start traversal from the head
        while (current != null) // Traverse until the end of the list
        {
            Console.Write(current.val + " "); // Print the value of the current node
            current = current.next; // Move to the next node
        }
        Console.WriteLine(); // Print a new line after printing all elements
    }
}

// Example usage
LinkedList linkedList = new LinkedList(); // Create a new linked list
linkedList.AddNode(1); // Add nodes with values 1, 2, and 3 to the list
linkedList.AddNode(2);
linkedList.AddNode(3);
linkedList.PrintList(); // Print the elements of the linked list (Output: 1 2 3)
