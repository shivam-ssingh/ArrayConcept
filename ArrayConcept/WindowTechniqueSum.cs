using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    public class WindowTechniqueSum
    {
        /// <summary>
        /// in the given array, find the sum of the subarrays of size of k.
        /// </summary>
        public void window()
        {
            var array = new int[] { 1,2 ,-1,0,4};
            int k = 3;
            var answer = 0;// sum of all the subarrays of k length.
            var sumSub = 0; // sum of the particular window of sub arrays.
            for(int i =0; i< k; i++)
            {
                sumSub += array[i];
            }
            answer = sumSub;
            for (int j = k; j< array.Length; j++)
            {
                Console.WriteLine(sumSub);
                sumSub += array[j];
                sumSub -= array[j - k];
                answer += sumSub;
            }
            Console.WriteLine(sumSub);
            Console.WriteLine("Final Answer: "+answer);
        }
    }
}
