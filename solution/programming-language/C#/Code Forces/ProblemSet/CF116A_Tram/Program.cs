using System;
using System.Collections;

namespace CF116A_Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                ArrayList arrayList = new ArrayList();

                int n = int.Parse(value);
                int remainingPassengers = 0;


                string line = Console.ReadLine();
                var a = int.Parse(Convert.ToString(line.Split(' ')[0]));
                var b = int.Parse(Convert.ToString(line.Split(' ')[1]));
                var initialPassengerA = a;
                var initialPassengerB = b;

                remainingPassengers -= a;


                for (var i = 2; i <= n; i++)
                {
                    remainingPassengers += b;
                    line = Console.ReadLine();
                    a = int.Parse(Convert.ToString(line.Split(' ')[0]));
                    b = int.Parse(Convert.ToString(line.Split(' ')[1]));
                    arrayList.Add(remainingPassengers);
                    remainingPassengers -= a;
                }

                int max = -1;
                foreach (object i in arrayList)
                {
                    if (max < Convert.ToInt32(i))
                    {
                        max = Convert.ToInt32(i);
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}
