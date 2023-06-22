using LinkedListGenerator;
using Task2;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        var head = new LinkedListModel()
            .PopulateList(new int[] { 10, 15, 34, 41, 56, 72 });

        var result = solution
            .GetModifiedCompartmentSequence(head, 6);

        new LinkedListModel().PrintList(result);
    }


}