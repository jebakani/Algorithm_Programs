using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Anagram
    {
        //method to find whether the two word is anagram or not
        public int CheckAnagram(string str1,string str2)
        {
            //if lenght of two string is not match the two string are not anagram
            if (str1.Length != str2.Length)
            {
                return 0;
            }
            else
            {
                //convert string to char array
                int flag = 1;
                char[] string1 = str1.ToCharArray();
                char[] string2 = str2.ToCharArray();
                //sort the array
                Array.Sort(string1);
                Array.Sort(string2);
                //check each value in both array are equal
                for(int i=0;i<str1.Length;i++)
                {
                    //if any one word is not equal then break and retur 0
                    if(string1[i].CompareTo(string2[i])!=0)
                    {
                        flag = 0;
                        break;
                    }
                }
                return flag;
            }
        }
    }
}
