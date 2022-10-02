using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Leet_Code
{
    public class Solution
    {
        public string GetFinalResult(LinkedList<ListNode> listNodes1, LinkedList<ListNode> listNodes2)
        {
            List<int> listNodes = AddTwoLinkedList(listNodes1, listNodes2);

            //listNodes.Reverse();
            var Result = GetNodesSumString(listNodes);

            return Result;
        }

        private string GetNodesSumString(List<int> listNodes)
        {
            int[] listNodeVals = listNodes.ToArray();

            string result = string.Join("", listNodeVals);

            return result;
        }

        private List<int> AddTwoLinkedList(LinkedList<ListNode> listNodes1, LinkedList<ListNode> listNodes2)
        {
            var largeList = listNodes1.Count > listNodes2.Count ? listNodes1 : listNodes2;
            var smallList = listNodes1.Count > listNodes2.Count ? listNodes2 : listNodes1;
            var result = new List<int>();

            int surplus = 0;
            while (largeList.First != null)
            {
                ListNode node1 = largeList.First.Value;
                ListNode node2 = null;
                if (smallList.First != null)
                  node2 = smallList.First.Value;

                (int main, int transfered) AddResult = GetAddedVal(node1, node2);
                
                result.Add(AddResult.main);

                if (AddResult.transfered > 0)
                {
                    surplus = AddResult.transfered;

                    if (node1.next != null)
                        node1.next.val += surplus;
                }

                if (largeList.Count > 0)
                    largeList.RemoveFirst();
                if (smallList.Count > 0)
                    smallList.RemoveFirst();
            }

            if (surplus > 0)
            {
                result.Add(surplus);
            }

            return result;
        }

        private (int main, int transfered) GetAddedVal(ListNode node1, ListNode node2)
        {
            int val1 = node1 == null ? 0 : node1.val;
            int val2 = node2 == null ? 0 : node2.val;
            int val = val1 + val2;
            int transfer = 0;

            if (val >= 10)
            {
                val -= 10;
                transfer = 1;
            }

            (int main, int transfered) Result = (val, transfer);

            return Result;

        }
    }
}
