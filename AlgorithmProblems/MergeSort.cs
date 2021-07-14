using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class MergeSort
    {
        protected void Merge(string[] arr,int left,int mid,int right)
        {
            int leftLen = mid - left + 1;
            int rightLen = right - mid;
            //create a temp array
            string[] leftArr = new string[leftLen];
            string[] rightArr = new string[rightLen];
            int i, j;
            //coppy the data to temp array
            for(i=0;i<leftLen;i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (j = 0; j < rightLen; j++)
            {
                rightArr[j] = arr[mid+1+ j];
            }
            i = 0;
            j = 0;
            int k = left;
            while (i < leftLen && j < rightLen)
            {
                if (leftArr[i].CompareTo(rightArr[j])<=0)
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }
            // Copy remaining elements
            // of L[] if any
            while (i < leftLen)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            // Copy remaining elements
            // of L[] if any
            while (j < rightLen)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }        }
        public void Msort(string[] arr,int left,int right)
        {
            if(left<right)
            {
                int mid = left + (right - left) / 2;
                //split the array into left and right sub array
                //until subarray with element 1 or 0
                Msort(arr, left, mid);
                Msort(arr, mid + 1, right);
                //merge the array
                Merge(arr, left, mid, right);
            }
        }

        public void MDisplay(string[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
