namespace Task1;

public class Solution
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

    public bool CheckIfListAscending(ListNode head)
    {
        var prevNode = head;
        var prevItem = head.val;
        var currentNode = prevNode.next;

        while (currentNode != null)
        {
            var currentItem = currentNode.val;
            
            if(prevItem > currentItem)
            {
                return false;
            }

            prevItem = currentItem;
            currentNode = currentNode.next;
        }

        return true;
    }
}
