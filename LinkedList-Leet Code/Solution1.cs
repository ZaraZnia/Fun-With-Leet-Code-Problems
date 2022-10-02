using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Leet_Code
{
    public class Solution1
    {        
        public string GetFinalResult(List<ListNode> listNodes1, List<ListNode> listNodes2)
        {
            List<int> listNodes = AddTwoLinkedList(listNodes1, listNodes2);

            listNodes.Reverse();
            var Result = GetNodesSumValue(listNodes);

            return Result;
        }

        private List<int> AddTwoLinkedList(List<ListNode> listNodes1, List<ListNode> listNodes2)
        {

            ListNode[] nodesArray1 = new ListNode[listNodes1.Count + 1];
            ListNode[] nodesArray2 = new ListNode[listNodes2.Count + 1];
            //ListNode[] resultLinkList = new ListNode[listNodes1.Count + listNodes2.Count];
            List<int> resultList = new List<int>();

            //listNodes1.Reverse();
            //listNodes2.Reverse();

            listNodes1.CopyTo(nodesArray1, 0);
            listNodes2.CopyTo(nodesArray2, 0);

            int len1 = listNodes1.Count;
            int len2 = listNodes2.Count;
            int len = nodesArray1.Length > nodesArray2.Length ?  len1: len2;

            for (int i = 0; i < len; i++)
            {
                var node1 = i < len1 ? nodesArray1[i] : new ListNode(0);
                var node2 = i < len2 ? nodesArray2[i] : new ListNode(0);

                (int main, int transfered) AddResult = GetAddedVal(node1, node2);
                
                ListNode ln = new ListNode();
                ln.val = AddResult.main;
                resultList.Add(ln.val);

                var node = nodesArray1[i + 1] != null ? nodesArray1[i + 1] : new ListNode();
                if (AddResult.transfered > 0)
                {
                    node.val += AddResult.transfered;
                }

                if (i == len - 1)
                {
                    resultList.Add(node.val);
                }
            }

            return resultList;
        }

        private static (int main, int transfered) GetAddedVal(ListNode listNode1, ListNode listNode2)
        {
            int val = listNode1.val + listNode2.val;
            int transfer = 0;

            if (val >= 10)
            {
                val -= 10;
                transfer = 1;
            }

            (int main, int transfered) Result = (val, transfer);

            return Result;
        }

        private string GetNodesSumValue(List<int> listNodes)
        {
            int[] listNodeVals = listNodes.ToArray();

            string result = string.Join("", listNodeVals);

            return result;
        }
    }
}
