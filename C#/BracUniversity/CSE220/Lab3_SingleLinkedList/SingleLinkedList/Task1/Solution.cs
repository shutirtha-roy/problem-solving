using LinkedListGenerator;

namespace Task1;

public class Solution
{
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
