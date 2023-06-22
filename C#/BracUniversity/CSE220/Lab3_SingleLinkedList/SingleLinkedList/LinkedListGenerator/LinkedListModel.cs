namespace LinkedListGenerator;

public class LinkedListModel
{
    public ListNode PopulateList(int[] arr)
    {
        var head = new ListNode(arr[0]);
        var current = head;

        foreach (var item in arr.Skip(1))
        {
            current.next = new ListNode(item);
            current = current.next;
        }

        return head;
    }

    public void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write($"{head.val} ");
            head = head.next;
        }

        Console.WriteLine();
    }
}