using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    /// <summary>
    /// Find the sum of all subArrays present in the Array
    /// </summary>
    public class ReverseLookupSumOfSubArray
    {
        public void lookupsum()
        {
            var array = new int[] { 1,2,3};
            int n = array.Length;
            var sum =0;
            for (int i = 0; i< n; i++ )
            {
                sum += array[i] * (n - i) * (i + 1);
            }
            Console.WriteLine(sum);
        }
    }
}
