using System;
using System.Collections.Generic;

namespace LinkedList_Leet_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]");
            
            ListNode ln6 = new ListNode(9, null);
            ListNode ln5 = new ListNode(9, ln6);
            ListNode ln4 = new ListNode(9, ln5);
            ListNode ln3 = new ListNode(9, ln4);
            ListNode ln2 = new ListNode(9, ln3);
            ListNode ln1 = new ListNode(9, ln2);

            var lst1 = new List<ListNode>();
            lst1.AddRange(new[] { ln1, ln2, ln3, ln4, ln5, ln6 });
            var lst1Arr = lst1.ToArray();
            LinkedList<ListNode> l1 = new LinkedList<ListNode>(lst1Arr);

            ListNode ln24 = new ListNode(9, null);
            ListNode ln23 = new ListNode(9, ln24);
            ListNode ln22 = new ListNode(9, ln23);
            ListNode ln21 = new ListNode(9, ln22);

            var lst2 = new List<ListNode>();
            lst2.AddRange(new[] {ln21, ln22, ln23, ln24});
            var lst1Arr1 = lst2.ToArray();
            LinkedList<ListNode> l2 = new LinkedList<ListNode>(lst1Arr1);

            Solution solution = new Solution();
            string answer = solution.GetFinalResult(l1, l2);

            Console.WriteLine("The result is :" + answer);
        }
    }
}
