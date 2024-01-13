using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            Rotate(nums, 3);
            Console.WriteLine(String.Join(", ", nums));
        }

        static void Rotate(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 1 || nums.Length == k)
                return;

            int s = 0;
            int p = 0;
            int e = nums[p];

            for (int c = 1; c <= nums.Length; c++)
            {
                p = (p + k) % nums.Length;
                (e, nums[p]) = (nums[p], e);

                if (p == s)
                {
                    s++;
                    p++;
                    e = nums[p];
                }
            }
        }
    }
}
