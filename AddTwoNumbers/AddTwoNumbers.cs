using System;
using System.Collections.Generic;

namespace LeetCode.AddTwoNumbers
{
    public static class AddTwoNumbers
    {
        public static ListNode CreateNodeList(List<int> numbers)
        {
            List<ListNode> listNodes = new List<ListNode>();

            ListNode node = null;

            if (numbers.Count > 0)
            {
                listNodes.Add(new ListNode(numbers[^1], null));

                for (int i = numbers.Count - 2; i >= 0; i--)
                {
                    listNodes.Add(new ListNode(numbers[i], listNodes[^1]));
                }

                node = listNodes[^1];
            }

            return node;
        }


        public static List<int> AddNodes(ListNode node1, ListNode node2)
        {
            List<int> sum = new List<int>();
            int carry = 0;
            while (true)
            {
                int nodeSum = carry;

                if (node1 != null)
                    nodeSum += node1.val;

                if (node2 != null)
                    nodeSum += node2.val;

                carry = nodeSum / 10;
                nodeSum %= 10;

                sum.Add(nodeSum);

                if (node1?.next == null && node2?.next == null && carry == 0)
                    break;
                else
                {
                    node1 = node1?.next;
                    node2 = node2?.next;
                }
            }

            return sum;
        }
    }
}
