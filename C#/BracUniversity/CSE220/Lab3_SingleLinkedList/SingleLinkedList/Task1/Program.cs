using Task1;
using LinkedListGenerator;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        var head = new LinkedListModel()
            //.PopulateList(new int[] { 10, 15, 34, 41, 56, 72 });
            .PopulateList(new int[] { 10, 15, 44, 41, 56, 72 });

        var result = solution
            .CheckIfListAscending(head);

        Console.WriteLine(result);
    }

    
}