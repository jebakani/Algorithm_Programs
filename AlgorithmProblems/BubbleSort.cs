using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class BubbleSort<T> where T:IComparable
    {
        //bubble sort compare the current element with next element 
        public T[] Sort(T[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                T temp;
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
        //method to display the sorted array
        public void Display(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
