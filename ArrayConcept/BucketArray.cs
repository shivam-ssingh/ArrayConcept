using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    public class BucketArray
    {
        public void Bucket()
        {
            //int[] array = new int[] { 20, 25,27, 33, 65, 70 };
            //int[] array = new int[] { 3, 6, 9, 1 };
            int[] array = new int[] { 1, 10000000 };
            //int[] array = new int[] { 1, 3,100};
            int n = array.Length;

            int min = int.MaxValue;
            int max = int.MinValue;
            var Bmax = new int[n];
            var Bmin = new int[n];

            for (int i=0; i< n; i++)
            {
                min = array[i] < min ? array[i] : min;
                max = array[i] > max ? array[i] : max;
            }
            for (int i = 0; i < n; i++)
            {
                Bmin[i] = int.MaxValue;
            }

            for (int i = 0; i < n; i++)
            {
                Bmax[i] = int.MinValue;
            }

            var gap = (max - min) / (n - 1);
            if ((max - min) % (n-1) !=0)
            {
                gap++;
            }
            for (int i = 0; i < n; i++)
            {
                int pos = (int)((array[i] - min) / gap);
                Bmin[pos] = Bmin[pos] < array[i] ? Bmin[pos] : array[i];
                Bmax[pos] = Bmax[pos] < array[i] ? array[i] : Bmax[pos];
            }

            int answer = int.MinValue;
            int previous = int.MinValue;
            for (int i =0; i<n;i++)
            {
                if (Bmin[i] == int.MaxValue) 
                {
                    continue;
                }
                if (previous == int.MinValue)
                {
                    previous = Bmax[i];
                }
                else
                {
                    var diff = Bmin[i] - previous;
                    answer = diff > answer ? diff : answer;
                    previous = Bmax[i];
                }
            }

            Console.WriteLine("Array");
            PrintArray(array);

            Console.WriteLine("Bmin");
            PrintArray(Bmin);

            Console.WriteLine("Bmax");
            PrintArray(Bmax);

            Console.WriteLine("Answer is " + answer);
        }


        public void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
