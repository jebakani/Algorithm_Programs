using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Anagram
    {
        public int CheckAnagram(string str1,string str2)
        {
            if (str1.Length != str2.Length)
            {
                return 0;
            }
            else
            {
                int flag = 1;
                char[] string1 = str1.ToCharArray();
                char[] string2 = str2.ToCharArray();
                Array.Sort(string1);
                Array.Sort(string2);
                for(int i=0;i<str1.Length;i++)
                {
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
