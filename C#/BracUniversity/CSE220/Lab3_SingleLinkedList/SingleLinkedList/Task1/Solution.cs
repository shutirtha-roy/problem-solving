namespace Task1;

public class Solution
{
    public ListNode PopulateList(int[] arr)
    {
        var head = new ListNode(arr[0]);
        var current = head;

        foreach (var item in arr)
        {
            current.next = new ListNode(item);
            current = current.next;
        }

        return head;
    }
}
