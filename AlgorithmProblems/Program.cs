using System;
using System.Collections;
using System.IO;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\HP1\source\repos\ALGORITHMPROBLEMS\AlgorithmProblems\AlgorithmFile.txt";
            string text = File.ReadAllText(filepath);
            string[] textArray = text.Split(" ");
            Console.WriteLine("Welcome to Algorithm problems");
            Console.WriteLine("1.Permutation of string");
            Console.WriteLine("2.Binary search for word");
            Console.WriteLine("3.Insertion sort");
            Console.WriteLine("4.Bubble sort");
            Console.WriteLine("5.Exit");
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
                    BinarySearchWord binarySearch = new BinarySearchWord(textArray);
                    Console.WriteLine("Enter the word to search:");
                    string word = Console.ReadLine();
                    int found = binarySearch.FindWord(word, 0, textArray.Length);
                    if (found == 1)
                    {
                        Console.WriteLine("{0} is found",word);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not found",word);
                    }
                    break;

                case 3:
                    InsertionSort<string> insertionSort = new InsertionSort<string>();
                    insertionSort.Sort(textArray);
                    insertionSort.Display(textArray);
                    break;

                case 4:
                    int[] intArray = { 58, 69, 1, 15, 9, 100, 30 };
                    BubbleSort bubbleSort = new BubbleSort();
                    intArray=bubbleSort.Sort(intArray);
                    bubbleSort.Display(intArray);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
            Console.Read();
        }
    }
}
