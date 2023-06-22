using LinkedListGenerator;

namespace Task2;

public class Solution
{
    private int TotalElement(ListNode head)
    {
        var currentNode = head;
        var count = 0;

        while (currentNode != null)
        {
            count++;
            currentNode = currentNode.next;
        }

        return count;
    }

    public ListNode GetModifiedCompartmentSequence(ListNode head, int lastPos)
    {
        var totalElement = TotalElement(head);
        var positionBeforeItem = totalElement - lastPos;

        if(positionBeforeItem < 0)
        {
            return head;
        }



        return new ListNode();
    }
}
