using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class CirclularLinkedListValidator 
    {
        public bool IsCircular<T>(LinkedList<T> linkedList)
        {
            if (linkedList == null)
            {
                return false;
            };

            LinkedListNode<T> listFirstIndexNode = linkedList.First;

            if (listFirstIndexNode.Next == null)
            {
                return false;
            }
            LinkedListNode<T> listSecondIndexNode = listFirstIndexNode.Next;
  
            while (listSecondIndexNode.Next != null)
            {
                if (listSecondIndexNode.Next == null)
                {
                    return false;
                }
                listSecondIndexNode = listSecondIndexNode.Next;
                if (listFirstIndexNode == listSecondIndexNode)
                {
                    return true;
                }
                if (listSecondIndexNode.Next == null)
                {
                    return false;
                }
                listSecondIndexNode = listSecondIndexNode.Next;
                listFirstIndexNode = listFirstIndexNode.Next;

            }
            return false;
        }

    }


}
