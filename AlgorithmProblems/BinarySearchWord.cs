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
        public BinarySearchWord(T[] array)
        {
            this.array = array;
            Array.Sort(this.array);
        }
        public int FindWord(T word,int low,int high)
        {
            int mid = low;
            while (low <= high)
            {
                mid = (high + low) / 2;
                if (array[mid].CompareTo(word)==0)
                {
                    return 1;
                }
                else if (array[mid].CompareTo(word) > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
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
