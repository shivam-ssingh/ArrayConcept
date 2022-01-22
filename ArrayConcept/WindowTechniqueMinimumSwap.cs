using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    /// <summary>
    /// In the given array, find the minimum number of swaps to bring together
    /// all the elements <= K together.
    /// </summary>
    public class WindowTechniqueMinimumSwap
    {
        public void swap()
        {
            List<int> yo = new List<int>() { 1, 2 };
            
            var array = new int[] { 4 ,11 ,6 ,5, 11, 20, 19, 14, 14, 2, 9, 20, 11, 11, 15, 1, 7, 12, 19, 9 };
            var k = 14;
            var lessThanK = 0;
            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<=k)
                {
                    lessThanK++;
                }
            }

            for(int i =0; i< lessThanK; i++)
            {
                if(array[i]<= k)
                {
                    count++;
                }
            }
            var maxCount = count;
            for (int j=lessThanK; j<array.Length;j++)
            {
                if (array[j] <=k)
                {
                    count++;
                }
                if (array[j-lessThanK] <=k)
                {
                    count--;
                }
                maxCount = count > maxCount ? count : maxCount;
            }

            Console.WriteLine(lessThanK - maxCount);
        }
    }
}
