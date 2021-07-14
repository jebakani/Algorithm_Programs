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
    }
}
