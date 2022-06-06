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
    public ListNode MiddleNode(ListNode head) {
        ListNode tail = head;
        int count = 0;
        int midPosition = 0;
        
        while(tail != null)
        {
            count++;
            tail = tail.next;
        }
        
        midPosition = 1 + (count / 2);
        count = 0;
        tail = head;
        while(tail != null)
        {
            count++;
            if(count == midPosition)
            {
                return tail;
            }
            
            tail = tail.next;
        }
        
        return null;
        
    }
}