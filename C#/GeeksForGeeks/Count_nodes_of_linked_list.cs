class Solution
{
    //Complete this function
    public int getCount(Node head)
    {
        var count = 0;
        
        while(head != null)
        {
            count++;
            head = head.next;
        }
        
        return count;
    }

}