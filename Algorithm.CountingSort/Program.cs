using System;

namespace Algorithm.CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //SortColors(new int[] { 2, 0, 2, 1, 1, 0 });

            SortColors(new int[] { 2, 0, 1 });
        }

        public static void SortColors(int[] nums)
        {
            int length = nums.Length;
            int loopLength = length / 2;
            if (length % 2 == 1) loopLength++;
            int right = 0;
            int left = 0;
            int p1 = 0;
            int p2 = length - 1; ;
            while (p1 < loopLength && p1<p2)
            {
                right = nums[p1];
                left = nums[p2];
                if (right == 2)
                {
                    nums[p1] = left;
                    nums[p2] = right;
                    p1++;
                }
                else if(right == 0)
                {
                    nums[p1] = left;
                    nums[p2] = right;
                    p2--;
                }
            }
        }
    }
}
