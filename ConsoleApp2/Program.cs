using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sort = new int[] { 54, 35, 12, 95, 34, 78, 85 };
            int temp = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (sort[i] < sort[j])
                    {
                        temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                    }
                }
            }
            foreach (var item in sort)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
