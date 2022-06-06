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
        int total = 0;
        
        while(head != null)
        {
            total = (total << 1);
            total += head.val;
            head = head.next;
        }
        
        return total;
    }
}