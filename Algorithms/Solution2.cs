using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Solution2
    {
        /*
         * 
         
            You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

            You may assume the two numbers do not contain any leading zero, except the number 0 itself.

            Example - 1 
            Input: l1 = [2,4,3], l2 = [5,6,4]
            Output: [7,0,8]
            Explanation: 342 + 465 = 807.

            Example - 2
            Input: l1 = [0], l2 = [0]
            Output: [0]

            Example - 3
            Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            Output: [8,9,9,9,0,0,0,1]

            Solution Stats: 
            Runtime: 96 ms, faster than 96.65% of C# online submissions for Add Two Numbers.
            Memory Usage: 28.1 MB, less than 82.65% of C# online submissions for Add Two Numbers.
        */

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode rootNode = null;
            ListNode tailNode = null;

            int sum = l1.val + l2.val;
            int remainder = sum % 10;

            rootNode = new ListNode(remainder, null);
            tailNode = rootNode;
            int tmp = sum / 10;
            while ((l1 != null && l1.next != null)
                  || (l2 != null && l2.next != null))
            {
                l1 = l1?.next;
                l2 = l2?.next;

                sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + tmp;
                remainder = sum % 10;
                tmp = sum / 10;

                tailNode = InsertNode(tailNode, remainder);
            }

            if (tmp > 0)
            {
                tailNode = InsertNode(tailNode, tmp);
            }

            return rootNode;
        }

        public ListNode InsertNode(ListNode tailNode, int val)
        {

            ListNode newNode = new ListNode(val, null);
            tailNode.next = newNode;
            return newNode;

        }
    }


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

}
