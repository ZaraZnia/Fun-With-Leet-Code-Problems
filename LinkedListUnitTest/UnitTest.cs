using LinkedList_Leet_Code;
using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedListUnitTest
{
    public class UnitTest
    {
        [Fact]
        public void Test3()
        {
            ListNode ln7 = new ListNode(9, null);
            ListNode ln6 = new ListNode(9, ln7);
            ListNode ln5 = new ListNode(9, ln6);
            ListNode ln4 = new ListNode(9, ln5);
            ListNode ln3 = new ListNode(9, ln4);
            ListNode ln2 = new ListNode(9, ln3);
            ListNode ln1 = new ListNode(9, ln2);

            var lst1 = new List<ListNode>();
            lst1.AddRange(new[] { ln1, ln2, ln3, ln4, ln5, ln6, ln7 });
            var lst1Arr = lst1.ToArray();
            LinkedList<ListNode> l1 = new LinkedList<ListNode>(lst1Arr);

            ListNode ln24 = new ListNode(9, null);
            ListNode ln23 = new ListNode(9, ln24);
            ListNode ln22 = new ListNode(9, ln23);
            ListNode ln21 = new ListNode(9, ln22);

            var lst2 = new List<ListNode>();
            lst2.AddRange(new[] { ln21, ln22, ln23, ln24 });
            var lst1Arr1 = lst2.ToArray();
            LinkedList<ListNode> l2 = new LinkedList<ListNode>(lst1Arr1);

            Solution solution = new Solution();
            string actual = solution.GetFinalResult(l1, l2);

            Assert.Equal(expected : "89990001", actual);
        }

        [Fact]
        public void Test2()
        {
            ListNode ln3 = new ListNode(3, null);
            ListNode ln2 = new ListNode(4, ln3);
            ListNode ln1 = new ListNode(2, ln2);

            ListNode[] lstArr1 = new[] { ln1, ln2, ln3 }; // [2, 4, 3];

            ListNode ln23 = new ListNode(4, null);
            ListNode ln22 = new ListNode(6, ln23);
            ListNode ln21 = new ListNode(5, ln22);

            ListNode[] lstArr2 = new[] {ln21, ln22, ln23} ; //[5, 6, 4];

            LinkedList<ListNode> l1 = new LinkedList<ListNode>(lstArr1);
            LinkedList<ListNode> l2 = new LinkedList<ListNode>(lstArr2);

            Solution solution = new Solution();
            string actual = solution.GetFinalResult(l1, l2);

            Assert.Equal(expected: "708", actual);
        }
        [Fact]
        public void Test1()
        {
            ListNode ln3 = new ListNode(3, null);
            ListNode ln2 = new ListNode(4, ln3);
            ListNode ln1 = new ListNode(2, ln2);

            ListNode[] lstArr1 = new[] { ln1, ln2, ln3 }; // [2, 4, 3];

            ListNode ln23 = new ListNode(4, null);
            ListNode ln22 = new ListNode(6, ln23);
            ListNode ln21 = new ListNode(5, ln22);

            ListNode[] lstArr2 = new[] {ln21, ln22, ln23} ; //[5, 6, 4];

            List<ListNode> l1 = new List<ListNode>(lstArr1);
            List<ListNode> l2 = new List<ListNode>(lstArr2);

            Solution1 solution = new Solution1();
            string actual = solution.GetFinalResult(l1, l2);

            Assert.Equal(expected: "708", actual);
        }

    }
}
