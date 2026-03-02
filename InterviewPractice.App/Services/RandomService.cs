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

    public int[] ShelvesThatNeedRestocking(int[] stock, int threshold)
    {
        return stock.
            Select((value, index) => new { value, index }).
            Where(x => x.value < threshold).
            Select(x => x.index).
            ToArray();
    }

    public string[] ExtractUsername(string[] emails, string domain)
    {
        return emails.Where(email => email.Split('@').Last() == domain).Select(email => email.Split('@').First()).ToArray();
    }

    public LinkedList<int> RemoveDuplicates(LinkedList<int> input)
    {
        var listRep = new List<int>();
        var firstNode = input.First;

        while (firstNode is not null)
        {
            listRep.Add(firstNode.Value);
            firstNode = firstNode.Next;
        }

        listRep = listRep.Distinct().ToList();

        input = new LinkedList<int>();
        foreach (var item in listRep)
        {
            input.AddLast(item);
        }

        return input;
    }

    public string[] RemoveDuplicates(string [] input)
    {
        // Must remove duplicates from input
        // Must preserve order or occurence

        var distinctList = new List<string>();
        var tempHash = new HashSet<string>();

        foreach (var item in input)
        {
            if (tempHash.Add(item))
            {
                distinctList.Add(item);
            }
        }

        return distinctList.ToArray();
    }

    public char GetFirstNonRepeatingChar(string input)
    {
        foreach (var item in input)
        {
            if (input.Where(c => c == item).Count() == 1)
                return item;
        }

        return ' ';
    }
}