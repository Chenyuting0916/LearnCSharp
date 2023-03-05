namespace LeetCode
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            // var result = new ListNode(head.val);
            // while(head.next != null){
            //     if(head.next.val != result.val){
            //         result.next = head.next;
            //     }

            //     head = head.next;
            // }
            // return result;
            if (head == null) { return null; } //Don't forget this edge case
            ListNode ptr = head; //Helps for returning at the end

            while (ptr.next != null)
            { //Terminates if there is no next node(end of list)
                if (ptr.next.val == ptr.val)
                { //Check for duplicate next node
                    ptr.next = ptr.next.next; //Delete next node
                }
                else
                {
                    ptr = ptr.next; //Advance if no duplicate is found
                }
            }
            return head; //Return the original start of list
        }
    }
}
