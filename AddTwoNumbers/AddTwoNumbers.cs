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

        public static int DeconstructList(ListNode node)
        {
            //var numbers = new List<int>();
            var number = 0;
            int index = 0;
            while (index >= 0)
            {
                //numbers.Add(node.val);
                number += node.val * (int)Math.Pow(10, index);

                if (node.next != null)
                {
                    node = node.next;
                    index++;
                }
                else
                    break;
            }

            return number;
        }

        public static List<int> GetNumbers(int number)
        {
            var numbers = new List<int>();

            while (number > 0)
            {
                int val = number % 10;
                numbers.Add(val);
                number /= 10;
            }

            return numbers;
        }
    }
}
