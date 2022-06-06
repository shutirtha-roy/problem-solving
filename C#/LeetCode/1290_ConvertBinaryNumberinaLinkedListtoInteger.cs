/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        ListNode tail = head;
        List<int> binaryValues = new List<int>();
        int total = 0;
        
        while(tail != null)
        {
            binaryValues.Add(tail.val);
            tail = tail.next;
        }
        
        for(int i = binaryValues.Count - 1, j = 0; i >= 0; i--, j++)
        {
            if(binaryValues[i] == 0)
                continue;
            
            total += (1 << j);
        }
        
        return total;
    }
}