using System;
using System.Collections.Generic;

namespace ArrayConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumWindowTechnique sumWindowTechnique = new SumWindowTechnique();
            //sumWindowTechnique.window();

            //WindowTechniqueFrequency frequencyWindowTechnique = new WindowTechniqueFrequency();
            //frequencyWindowTechnique.frequency();

            //WindowTechniqueMinimumSwap windowTechniqueMinimumSwap = new WindowTechniqueMinimumSwap();
            //windowTechniqueMinimumSwap.swap();

            //ReverseLookupSumOfSubArray reverseLookupSumOfSubArray = new ReverseLookupSumOfSubArray();
            //reverseLookupSumOfSubArray.lookupsum();
            //TODO: Add brute force code in ReverseLookupSumOfSubArray


            //QueryOptimizationFor2dArray queryOptimizationFor2DArray = new QueryOptimizationFor2dArray();
            //queryOptimizationFor2DArray.precomputation2d();

            //BucketArray bucketArray = new BucketArray();
            //bucketArray.Bucket();

            //ArrayRearrangement arrayRearrangement = new ArrayRearrangement();
            //arrayRearrangement.FirstMissingPositive();

           var matrix = new int[,] { { 1, 2, 3 }, { 4,5,6}, { 7,8,9 } };
            foreach (var item in Spiral(matrix))
            {
                Console.Write(item + " ");
            }

        }

        public static List<int> Spiral(int[,] matrix) 
        {
            var ans = new List<int>();
            int R = matrix.GetLength(0) - 1;
            int B = matrix.GetLength(1) - 1;
            int L = 0;
            int T = 0;

            int counter = 0;
            int limit = matrix.GetLength(0)  * (matrix.GetLength(1));

            while (T <= B && L <= R)
            {
                if (counter < limit)
                {
                    for (int i = L; i <= R; i++)
                    {
                        ans.Add(matrix[T,i]);
                        counter++;
                    }
                    ++T;
                }

                if (counter < limit)
                {
                    for (int i = T; i <= B; i++)
                    {
                        ans.Add(matrix[i,R]);
                        counter++;
                    }
                    --R;
                }
                Console.WriteLine("Stuck");
                if (counter < limit)
                {
                    for (int i = R; i >= L; i--)
                    {
                        ans.Add(matrix[B,i]);
                        counter++;

                    }
                    --B;
                }

                if (counter < limit)
                {
                    for (int i = B; i >= T; i--)
                    {
                        ans.Add(matrix[i,L]);
                        counter++;

                    }
                    ++L;
                }

            }

            return ans;
        }

    }
}
