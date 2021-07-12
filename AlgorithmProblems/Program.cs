using System;
using System.Collections;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm problems");
            Console.WriteLine("1.Permutation of string");
            Console.WriteLine("2.Exit");
            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Permutation permutation = new Permutation();
                    permutation.Permute("abc",0,2);
                    ArrayList array = permutation.ReturnArray();
                    foreach(string arr in array)
                    {
                        Console.WriteLine(arr);
                    }
                    break;
                case 2:
                    break;
            }
            Console.Read();
        }
    }
}
