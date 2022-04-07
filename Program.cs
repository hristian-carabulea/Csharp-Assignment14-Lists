using System;
using System.Collections.Generic;

/// <summary>
/// Find largest numbers from multiple lists in a list.
/// </summary>
namespace Assignment14_FindLargestNumber_from_groupOfCollections
{
    class Program
    {
        static void Main()
        {
            //source list of 'list of int'
            List<List<int>> sourceList = new List<List<int>>()
            {
                new List<int>() { 100, 10, 50 },
                new List<int>() { 30, 750, 99, 600 },
                new List<int>() { 888, 333, 2021, 1, 200 }
            };

            // Create list with largest numbers from each list in the sourceList
            List<int> findLargest = FindLargestInList(sourceList); 

            // Print to the screen the numbers in the findLargest list
            Console.Write("List of largest numbers = (");
            int numItemsInList = findLargest.Count;

            for (var i=0; i<numItemsInList; i++)
            {
                if (i == numItemsInList - 1)
                {
                    Console.Write(findLargest[i]);
                }
                else
                    Console.Write(findLargest[i] + ", ");
            }
                
            Console.WriteLine(")");
            Console.ReadKey();
        }

        /// <summary>
        /// Receive a list of lists of int. 
        /// Return list of largest numbers in each list
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static List<int> FindLargestInList(List<List<int>> numbers)
        {
            List<int> resultsList = new List<int>(); // create empty list
            foreach (var child_list in numbers)
            {
                if (child_list.Count > 0) //check if list contains values, sort values, and add new item
                {
                    child_list.Sort(); 
                    resultsList.Add(child_list[child_list.Count - 1]); 
                }
            }
            return resultsList;
        }
    }
}

