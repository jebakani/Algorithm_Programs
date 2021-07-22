using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class PrimeNumber
    {
        ArrayList array = new ArrayList();
        ArrayList primePali = new ArrayList();
        //method to find the number is prime or not 
        public void IsPrime()
        {
            int flag;
            for(int num=2;num<=1000;num++)
            {
                flag = 1;
                for(int i=2;i<=Math.Sqrt(num);i++)
                {
                    if(num%i==0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if(flag==1)
                {
                    array.Add(num);
                    PrimePalindrome(num);
                }
            }
        }
        public void display()
        {
            Console.WriteLine("Prime numbers are:");
            foreach(int i in array )
            {
                Console.WriteLine("{0}",i);
            }
        }
        //method to check whether the number is palindrome or not
        private void PrimePalindrome(int num)
        {
            Palindrome palindrome = new Palindrome();
            if(palindrome.IsPalindrome(num)==1)
            {
                primePali.Add(num);
            }
        }
        public void PrintPalindrome()
        {
            Console.WriteLine("Prime Palindrome");
            foreach(int i in primePali)
            {
                Console.WriteLine(i);
            }
        }

        //checks whethere the number is anagram or not using anagram class
        public void CheckAnagram()
        {
            string[] strOfPrime = new string[array.Count];
            Anagram anagram = new Anagram();
            int count = 0;
            Console.WriteLine("Anagrams between prime");
            foreach(int i in array)
            {
               strOfPrime[count] = i.ToString();
                count++;
            }
            //checking whether any other number is anagram to each other
            for(int i=2;i<count-1;i++)
            {
                int flag = 0;
                Console.Write("\nThe prime anagram to {0} are: ",strOfPrime[i]);
                for(int j=0;j<count-1;j++)
                {
                    if(strOfPrime[i].CompareTo(strOfPrime[j])==0)
                    {
                        continue;
                    }
                    else if(anagram.CheckAnagram(strOfPrime[i],strOfPrime[j])==1)
                    {
                        Console.Write("{0} ",strOfPrime[j]);
                        flag = 1;
                    }
                }
                if(flag==0)
                {
                    Console.Write("No prime anagram ");
                }
                
            }
        }
    }
}
