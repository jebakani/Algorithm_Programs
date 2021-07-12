using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class InsertionSort<T> where T:IComparable
    {
        public void Sort(T[] array)
        {
            T maxValue;
            for(int i=1;i<array.Length;i++)
            {
                //make first element as maximum value
                maxValue = array[i];
                int j = i -1;
                //split the array into sorted and unsorted array 
                //check for minimum and move into sorted array
                while(j>=0 && array[j].CompareTo(maxValue)>0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                //make the mimum value into sorted array
                array[j + 1] = maxValue;
            }
        }

        public void Display(T[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
