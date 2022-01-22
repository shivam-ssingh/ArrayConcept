using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    /// <summary>
    /// given a 2d array, query.Query consists of 4 elements which are the position in the matrix.
    /// Calculate the sum of the matrix enclosed.
    /// </summary>
    public class QueryOptimizationFor2dArray
    {
        private int[,] arr;
        //brute force
        public void sum2d()
        {
            var array = new int[,] { { 1,2,3}, { 4,5,6}, { 2,0,1} };
            var q = new int[] { 0,1,1,2 };
            var ans = 0;
            for (int i= q[0]; i<=q[2];i++)
            {
                for (int j = q[1]; j <= q[3]; j++)
                {
                    ans += array[i,j];
                }
            }
            Console.WriteLine(ans);
        }

        public void precomputation2d()
        {
            var array = new int[,] { {1,2,3,4,5 },{6,7,8,9,10 }};
            var k = 0;
            print2dArray(array);
            //sum of 
            while (k < array.GetLength(0))
            {
                for (int i = 1; i < array.GetLength(1); i++)
                {
                    array[k, i] += array[k, i - 1];
                }
                k++;
            }
            print2dArray(array);
            k = 0;
            while (k < array.GetLength(1))
            {
                for (int i = 1; i < array.GetLength(0); i++)
                {
                    array[i,k] += array[i-1,k];
                }
                k++;
            }
            print2dArray(array);
        }


        private  void print2dArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
            Console.WriteLine();//new line at each row  
            Console.WriteLine();//new line at each row  

        }
    }
}
