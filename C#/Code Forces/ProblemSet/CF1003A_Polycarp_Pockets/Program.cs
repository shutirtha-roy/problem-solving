namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            IDictionary<int, int> digitCountPairs = new Dictionary<int, int>();

            for(int i = 0; i < n; i++)
            {
                if (!digitCountPairs.ContainsKey(a[i]))
                {
                    digitCountPairs.Add(a[i], 1);
                    continue;
                }

                digitCountPairs[a[i]]++;
            }

            int minPocket = (from val in digitCountPairs
                             orderby val.Value descending
                             select val.Value).First();

            Console.WriteLine(minPocket);
        }
    }
}