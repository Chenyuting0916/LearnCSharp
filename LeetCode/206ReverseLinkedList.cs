using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _206ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode resultNode = null;
            while (head != null)
            {
                resultNode = new ListNode(head.val, resultNode);
                head = head.next;
            }
            return resultNode;
        }

        public ListNode ReverseList2(ListNode head)
        {
            ListNode cur = head;
            ListNode prev = null;
            ListNode nxt = null;
            while (cur != null)
            {
                nxt = cur.next;
                cur.next = prev;
                prev = cur;
                cur = nxt;
            }

            return prev;
        }
    }
}
