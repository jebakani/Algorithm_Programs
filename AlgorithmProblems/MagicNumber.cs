using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class MagicNumber
    {
        public int startPoint = 1;
        public int endPoint = 100;

        public int FindMid()
        {
            int mid = (startPoint + endPoint) / 2;
            return mid;
        }

        public void CheckwithUser(int midNumber)
        {
            //get the user opinion
            Console.WriteLine("1.Number is greater than {0}\n2.Number is less than equal to {0}", midNumber, midNumber);
            Console.Write("enter your option");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    startPoint = midNumber + 1;
                    break;
                case 2:
                    endPoint = midNumber;
                    break;
                default:
                    Console.WriteLine("enter valid option");
                    break;
            }
        }
        //calling think number method 
        public void ThinkNumber()
        {
            //run until startpoint will be equal to end point
            while (startPoint != endPoint)
            {
                //find mid
                int mid = FindMid();
                //pass mid to binary search method
                CheckwithUser(mid);
            }
            //if start == end point then the number guessed is that
            if (startPoint == endPoint)
            {
                Console.WriteLine("the number you guess is {0}", startPoint);
            }
        }
    }
}
