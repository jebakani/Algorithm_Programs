using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class BubbleSort
    {
        //bubble sort compare the current element with next element 
        public int[] Sort(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                int temp;
                for(int j=i+1;j<array.Length;j++)
                {
                    //if the next element is less than current element then swap
                    if(array[i].CompareTo(array[j])>0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
