using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    public class WindowTechniqueFrequency
    {
        /// <summary>
        /// In the given Array, find the frequency of x in subarrays of k.
        /// </summary>
        public void frequency()
        {
            var array = new int[] { 2,2,1,2,4,6,2};
            int x = 2;
            int k = 4;
            var subarrFrequency = 0;
            for (int i =0; i< k;i++)
            {
                if (array[i] == x)
                {
                    subarrFrequency++;  
                }
            }

            for (int j = k; j< array.Length;j++)
            {
                Console.WriteLine(subarrFrequency);
                if(array[j] == x)
                {
                    subarrFrequency++;
                }
                if (array[j-k] ==x)
                {
                    subarrFrequency--;
                }
            }
            Console.WriteLine(subarrFrequency);
        }
    }
}
