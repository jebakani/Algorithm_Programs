using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Palindrome
    {
        public int IsPalindrome(int num)
        {
            int res = 0;
            int temp = num;
            while(temp!=0)
            {
                res = (res * 10) + (temp % 10);
                temp /= 10;
            }
            if(res==num)
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
