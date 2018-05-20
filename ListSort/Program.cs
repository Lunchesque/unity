using System;

namespace ListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // General defenition
            string data = Console.ReadLine();
            string[] list = data.Split(' ');

            // 
            int[] list_for_sort = GenerateIntList(list);
            int[] sorted_list = Bubble(list_for_sort);

            OneLineListPrint(sorted_list);

            Console.WriteLine();
            Console.ReadKey();
        }

        static int[] OneLineListPrint(int[] for_print)
        {
             for (int i = 0; i < for_print.Length; i++)
            {
                Console.Write(for_print[i] + " ");
            }
        return null;
        }

        static int[] Bubble(int[] for_sort)
        {
            for (int i = for_sort.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (for_sort[j] > for_sort[j + 1])
                    {
                        int swap_area = for_sort[j];
                        for_sort[j] = for_sort[j + 1];
                        for_sort[j + 1] = swap_area;
                    }
                }
            }
            return for_sort;
        }

        static int[] GenerateIntList(string[] list)
        {
            int[] int_list = new int[list.Length];
            for (int i = 0; i < int_list.Length; i++)
            {
                int_list[i] = int.Parse(list[i]);
            }

            return int_list;
            }

    }
}
