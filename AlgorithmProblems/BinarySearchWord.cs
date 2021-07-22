using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class BinarySearchWord<T> where T:IComparable
    {
        T[] array;
        //store the array and sort it in times of object creation
        public BinarySearchWord(T[] array)
        {
            this.array = array;
            Array.Sort(this.array);
        }
        //method to find the word using binary search technique
        //passing search word low level and high level
        public int FindWord(T word,int low,int high)
        {
            int mid = low;
            //initialize mid as low
            while (low <= high)
            {
                //find mid position between high and low
                mid = (high + low) / 2;
                //if element in mid pos is the search word return true
                if (array[mid].CompareTo(word)==0)
                {
                    return 1;
                }
                //of mid value is greater than search word then serch left
                else if (array[mid].CompareTo(word) > 0)
                {
                    high = mid - 1;
                }
                //else search right and do the same
                else
                {
                    low = mid + 1;
                }
            }
            //loop until low and high equal
            if(array[mid].CompareTo(word)==0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
