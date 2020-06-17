namespace LinkedListLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    public static class LinkedListExtension
    {
        public static void InsertIntegerInAscendingOrder(this LinkedList<int> list, int valueToInsert)
        {
            list.AddFirst(valueToInsert);

            var sortedList = list.OrderBy(x => x).ToList();
            
            var currentNode = list.First;
            var i = 0;
            
            // Copies the sorted list in the LinkedList
            while (currentNode != null)
            {
                if(currentNode.Value != sortedList.ElementAt(i))
                {
                    currentNode.Value = sortedList.ElementAt(i);
                }
                i++;
                currentNode = currentNode.Next;
            }
        }
    }
}
