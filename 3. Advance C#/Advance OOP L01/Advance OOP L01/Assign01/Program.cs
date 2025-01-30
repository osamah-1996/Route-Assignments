﻿using System.Collections;

namespace Assign01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region This is the Answer of Question 1
            Range<int>? RangeValue01 = new Range<int>(minValue: 10, maxValue: 32);

            Console.WriteLine(RangeValue01.IsInRange(10));    
            Console.WriteLine(RangeValue01.IsInRange(5));     
            Console.WriteLine(RangeValue01.Length());
            Console.WriteLine($"{new string('*' , 40)}");
            Range<double>? RangeValue02 = new Range<double>(minValue: 32.2, maxValue: 88.3); 
            Console.WriteLine(RangeValue02.IsInRange(73.4));    
            Console.WriteLine(RangeValue02.IsInRange(5.32));     
            Console.WriteLine(Math.Round(RangeValue02.Length(), 3));
            #endregion

            #region This is the Answer of Question 2 :  
            ArrayList myArray = new ArrayList { 1, 2, 3, 4, 5, 6, 7 };
            Reverse<int> reverse = new Reverse<int>();

            Console.WriteLine($"{new string('*', 20)} This is the Orignal array {new string('*', 20)}");
            foreach (int item in myArray)
            {
                Console.Write(item   + " ");
            }

            Console.WriteLine();
            reverse.ReverseArray(myArray);
            Console.WriteLine($"{new string('*', 20)} This is after reversing the array {new string('*', 20)}");
            foreach(int item in myArray)
            {
                Console.Write(item + " ");
            }
            #endregion

            #region This is the Answer of Question 3 :  
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> eventNumbers =  EventNumbers.GetEventNumbers(Numbers);
            foreach(int number in eventNumbers)
            {
                Console.WriteLine($"{number}");
            }
            #endregion

            #region This is the Answer of Question 4  
            FixedSizeList<int> fixedList = new FixedSizeList<int>(3);  

            fixedList.Add(10);
            fixedList.Add(20);
            fixedList.Add(30);
            Console.WriteLine("Element at index 1: " + fixedList.Get(1));
            Console.WriteLine($"{fixedList.Get(1)} located at {fixedList.Count()}");
            Console.WriteLine($"The total element stored in the array is {fixedList.Capacity()}");
            #endregion

            #region This is the Answer of Question 5 : 
            UniqueString<char> finder = new UniqueString<char>();

            string testString = "swwiss";
            int index = finder.FindFirstUniqueIndex(testString);

            Console.WriteLine("First non-repeating character index: " + index);
            #endregion
        }
    }
}
