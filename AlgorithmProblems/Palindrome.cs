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
            //initialize the result as 0
            int res = 0;
            int temp = num;
            //repeate until the temp becom null
            while(temp!=0)
            {
                res = (res * 10) + (temp % 10); //find remainder and add to the result 
                temp /= 10; // divide the temp by 10 to get the quotient
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
