using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_L02
{
    public static class Helper
    {


        #region Q1 : Helper
        public static void ChecKQuery(int[] numbers, int numOfQueries)
        {
            for (int i = 0; i < numOfQueries; i++)
            {
                int x;
                do
                {
                    Console.WriteLine("Please enter the target X");
                }
                while (!int.TryParse(Console.ReadLine(), out x));

                int counter = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (x < numbers[j])
                        counter++;
                }
                Console.WriteLine($"there is {counter} numbers that greater than x");
            }
        }
        #endregion



        #region Q2 : Helper
        public static bool IsPalindrome(int[] numbers, int n)
        {
            bool palindrome = true;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] != numbers[numbers.Length - i - 1])
                    palindrome = false;
                break;
            }
            return palindrome;
        }

        #endregion


        #region Q3 : Helper
        public static Queue RevQueue(Queue inputQ)
        {
            Stack temp = new Stack();

            int n = inputQ.Count;
            while (inputQ.Count > 0)
            {
                temp.Push(inputQ.Dequeue());
            }
            while (temp.Count > 0)
            {
                inputQ.Enqueue(temp.Pop());
            }

            return inputQ;
        }
        #endregion


        #region Q4 : Helper
        private static bool IsPair(char open, char close)
        {
            if (open == '(' && close == ')')
                return true;
            if (open == '[' && close == ']')
                return true;
            if (open == '{' && close == '}')
                return true;
            return false;
        }
        #endregion

        public static bool AreBalanced(string exp)
        {
            Stack<char> stack = new Stack<char>();
            int length = exp.Length;

            for (int i = 0; i < length; i++)
            {
                if (exp[i] == '(' || exp[i] == '[' || exp[i] == '{')
                    stack.Push(exp[i]);
                else if (exp[i] == ')' || exp[i] == ']' || exp[i] == '}')
                {
                    if (stack.Count == 0 || !IsPair(stack.Peek(), exp[i]))
                        return false;
                    else
                        stack.Pop();
                }

            }
            return stack.Count == 0 ? true : false;
        }



        #region Q5 : Helper
        public static int[] RemoveDuplicate(int[] arr)
        {
            HashSet<int> values = new HashSet<int>(arr);

            arr = values.ToArray();
            return arr;
        }
        #endregion

        #region Q6: Helper
        public static void RemoveoddNumber(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((int?)list[i] % 2 != 0)
                    list.RemoveAt(i);


            }
        }
        #endregion



        #region Q7: Helper
        public static void CreateQ()
        {
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(1);

            queue.Enqueue("Apple");

            queue.Enqueue(5.28);

            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

        }
        #endregion



        #region Q8: Helper
        public static void SearchTargetInStack(Stack<int> stack, int target)
        {
            bool flag = false;
            int counter = 0;
            foreach (var item in stack)
            {
                counter++;
                if (item == target)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Console.WriteLine($"Target was found and the counter {counter}");
            else
                Console.WriteLine("Targer was not found");
        }
        #endregion


        #region Q9: Helper
        public static int[] Intersection(int[] num1, int[] num2)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (var num in num1)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }
            List<int> Intersection = new List<int>();

            foreach (var num in num2)
            {
                if (countMap.ContainsKey(num) && countMap[num] > 0)
                {
                    Intersection.Add(num);
                    countMap[num]--;
                }
            }

            return Intersection.ToArray();
        }
        #endregion

        //10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.


        #region Q10: Helper
        public static int[] FindTarget(ArrayList list, int target)
        {
            int n = list.Count;
            int[] arr = (int[])list.ToArray(typeof(int));

            for (int start = 0; start < n; start++)
            {
                int currentSum = 0;
                for (int end = start; end < n; end++)
                {
                    currentSum += arr[end];
                    if (currentSum == target)
                    {
                        int[] result = new int[end - start + 1];
                        Array.Copy(arr, start, result, 0, end - start + 1);
                        return result;
                    }


                }
            }
            #endregion
            return null!;
        }
        #region Q11 : Helper
        public static void ReversekElements(Queue<int> queue, int k)
        {
            if (k <= 0 || k >= queue.Count)
            {
                throw new Exception("Invalid value for k ");
            }
            // 1 2 3 4 5
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
            {
                // 1 2 3 
                stack.Push(queue.Dequeue());
            }
            // 4 5 3 2 1 
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            for (int i = 0; i < queue.Count - k; i++)
            {
                // 3 2 1 4 5
                queue.Enqueue(queue.Dequeue());
            }
        }
        #endregion

    }
}
