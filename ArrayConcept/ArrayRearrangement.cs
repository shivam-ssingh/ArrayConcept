using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    public class ArrayRearrangement
    {
        public void Rearrange()
        {
            int[] array = new int[] { 1, 3, 0, 2 };
            PrintArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    int val = i;
                    int newindex = array[i];
                    while (i != newindex)
                    {
                        int temp = array[newindex];
                        array[newindex] = -(val + 1);

                        val = newindex;
                        newindex = temp;
                    }

                    array[newindex] = -(val + 1);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
                array[i] *= -1;
            }
            PrintArray(array);

        }

        public void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }



        public void FirstMissingPositive()
        {
            //var array = new int[] { 3, 4, 2, 1 };
            //var array = new int[] { 1, 1 };
            //var array = new int[] { 7, 8, 9, 11, 12 };
            //var array = new int[] { 1};
            //var array = new int[] { 0,-1,3,1};
            //var array = new int[] { 2,2,2,2,2};
            var array = new int[] { 39, 8, 43, 12, 38, 11, -9, 12, 34, 20, 44, 32, 10, 22, 38, 9, 45, 26, -4, 2, 1, 3, 3, 20, 38, 17, 20, 25, 41, 35, 37, 18, 37, 34, 24, 29, 39, 9, 36, 28, 23, 18, -2, 28, 34, 30 };
            int count = 0;
            int loop = 0;
            bool isNpresent = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 || array[i] >= array.Length)
                {
                    isNpresent = array[i] == array.Length;
                    array[i] = 0;
                }
            }
            Console.WriteLine("After Removing >n and <0");
            PrintArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    count++;
                }
            }
            if (count == array.Length && !isNpresent)
            {
                Console.WriteLine("Answer is 1");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0 && array[i] < array.Length)
                    {
                        int new_index = array[i];
                        int val = array[i];
                        while (i != new_index && loop < array.Length)
                        {
                            loop++;
                            array[i] = 0;
                            int temp = array[new_index];
                            array[new_index] = val;
                            new_index = temp;
                            val = temp;
                        }
                        array[new_index] = val;
                    }
                }
                Console.WriteLine("Final Array to work with");
                PrintArray(array);

                for(int i=1; i < array.Length; i++)
                {
                    if(array[i] == 0 || array[i] != i)
                    {
                        Console.WriteLine("Smallest missing element is "+i);
                    }
                }

                if (!isNpresent) 
                {
                    Console.WriteLine("Smallest missing element is " + array.Length);
                }
                else 
                {
                    Console.WriteLine("Smallest missing element is " + (array.Length+1));
                }
            }
           
        }
    }
}
