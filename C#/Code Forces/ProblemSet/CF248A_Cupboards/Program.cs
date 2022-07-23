using System;

namespace CF248A_Cupboards
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftDoorCountOne = 0, rightDoorCountOne = 0, leftDoorCountZero = 0, rightDoorCountZero = 0, count = 0;
            
            for(int i = 0; i < n; i++)
            {
                int[] doors = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                leftDoorCountOne += doors[0];
                rightDoorCountOne += doors[1];
            }

            leftDoorCountZero = n - leftDoorCountOne;
            rightDoorCountZero = n - rightDoorCountOne;

            if (rightDoorCountOne >= rightDoorCountZero)
                count += rightDoorCountZero;
            else
                count += rightDoorCountOne;

            if (leftDoorCountOne >= leftDoorCountZero)
                count += leftDoorCountZero;
            else
                count += leftDoorCountOne;

            Console.WriteLine(count);
        }
    }
}
