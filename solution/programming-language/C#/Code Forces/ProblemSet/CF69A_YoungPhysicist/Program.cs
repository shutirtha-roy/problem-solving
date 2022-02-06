using System;
using System.Collections;

namespace CF69A_YoungPhysicist
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var count = 0;

                ArrayList x = new ArrayList();
                ArrayList y = new ArrayList();
                ArrayList z = new ArrayList();

                var n = int.Parse(value);
                string[][] coordinate = new string[n][];
                int[] values = new int[n];

                for (var i = 0; i < n; i++)
                {
                    coordinate[i] = Console.ReadLine().Split(' ');
                    x.Add(int.Parse(coordinate[i][0]));
                    y.Add(int.Parse(coordinate[i][1]));
                    z.Add(int.Parse(coordinate[i][2]));
                }

                var xValue = adder((int[]) x.ToArray(typeof(int)));
                var yValue = adder((int[])y.ToArray(typeof(int)));
                var zValue = adder((int[])z.ToArray(typeof(int)));

                count += checker(xValue) + checker(yValue) + checker(zValue);

                if (count == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        static int adder(int[] value)
        {
            int total = 0;

            for (var i = 0; i < value.Length; i++)
            {
                total += int.Parse(Convert.ToString(value[i]));
            }

            return total;
        }

        static int checker(int value)
        {
            if (value == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
