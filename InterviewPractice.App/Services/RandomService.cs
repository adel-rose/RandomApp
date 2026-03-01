using InterviewPractice.App.Models;

namespace InterviewPractice.App.Services;

public class RandomService
{
    public LinkedList<int> ReverseList(LinkedList<int> list)
    {
        // list.First()
        // list.Last()
        // item = list.First(), item.next()

        var reversedLinkedList = new LinkedList<int>();

        var node = list.Last;

        while (node is not null)
        {
            reversedLinkedList.AddLast(node.Value);
            node = node.Previous;
        }

        return reversedLinkedList;

    }
    
    public int FindMiddle(LinkedList<int> list)
    {
        var linkedListCount = list.Count;
        var even = linkedListCount % 2 == 0;

        int midPoint = even 
            ? linkedListCount / 2 + 1
            : linkedListCount / 2;

        for (int i = 0; i < midPoint; i++)
        {
            var node = list.First;
            node = node.Next;

            if (i == midPoint)
            {
                return node.Value;
            }
        }

        return 0;
    }
}