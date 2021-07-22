using System;
using System.Collections;
using System.IO;

namespace AlgorithmProblems
{
    /// <summary>
    /// P1-permutation of string using recurrsion
    /// P2-Binary search
    /// P3-insertion sort
    /// P4-Bubble Sort
    /// P5-Merge sort
    /// P6-Search and sort using generic
    /// </summary>
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
            Console.WriteLine("5.Merge Sort");
            Console.WriteLine("6.Anagram");
            Console.WriteLine("7.Prime number between 1-1000");
            Console.WriteLine("8.Palindrome and anagrams of prime ");
            Console.WriteLine("9.Magic Number");
            Console.WriteLine("10.Message Demonstration");
            Console.WriteLine("11.Job scheduling");
            Console.WriteLine("12.Exit");
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
                    BinarySearchWord<string> binarySearch = new BinarySearchWord<string>(textArray);
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
                    BubbleSort<int> bubbleSort = new BubbleSort<int>();
                    intArray=bubbleSort.Sort(intArray);
                    bubbleSort.Display(intArray);
                    break;
                case 5:
                    MergeSort<string> mergeSort = new MergeSort<string>();
                    mergeSort.Msort(textArray, 0, textArray.Length - 1);
                    mergeSort.MDisplay(textArray);
                    break;
                case 6:
                    Anagram anagram = new Anagram();
                    int check=anagram.CheckAnagram("abcd","dsac");
                    if (check == 1)
                    {
                        Console.WriteLine("Two strings are anagram");
                    }
                    else
                    {
                        Console.WriteLine("the strings are not anagram");
                    }
                    break;

                case 7:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.IsPrime();
                    primeNumber.display();
                    primeNumber.PrintPalindrome();
                    primeNumber.CheckAnagram();
                    break;

                case 8:
                    PrimeNumber primeNumber1 = new PrimeNumber();
                    primeNumber1.IsPrime();
                    primeNumber1.PrintPalindrome();
                    primeNumber1.CheckAnagram();
                    break;

                case 9:
                    Console.WriteLine("choose a number between 1-100");
                    MagicNumber magic = new MagicNumber();
                    magic.ThinkNumber();
                    break;
                case 10:
                    MessageDemonstration message = new MessageDemonstration();
                    message.Demonstrate();
                    break;
                case 11:
                    TaskScheduling taskScheduling = new TaskScheduling();
                    taskScheduling.JobSchedule();
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
            Console.Read();
        }
    }
}
