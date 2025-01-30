namespace Advance_OOP_L02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //int[] nums = { 1, 2, 3, 4, 5 };
            //int numOfQuery = 3;
            //Helper.ChecKQuery(nums, numOfQuery); 
            #endregion



            #region 2.Given a number N and an array of N numbers.Determine if it's palindrome or not.
            //int[] nums = { 1, 2, 3, 2, 3 };
            //int n = nums.Length;

            //bool result = Helper.IsPalindrome(nums, n);
            //Console.WriteLine($"Is the Array is palindrome ? ==> {result}"); 
            #endregion





            #region  3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue queue = new Queue();

            //for (int i = 1; i <= 10; i++)
            //{
            //    queue.Enqueue(i);
            //}

            //queue = Helper.RevQueue(queue);
            //Console.WriteLine("Queue After reverse");

            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion



            #region 4.Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //string exp = "[()[{}";
            //bool result = Helper.AreBalanced(exp);
            //Console.WriteLine($"Is the string is Balanced ? ==> {result}");

            //5.Given an array, implement a function to remove duplicate elements from an array.
            //int[] nums = { 1, 2, 3, 2, 4 };

            //nums = Helper.RemoveDuplicate(nums);
            //foreach (var item in nums)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion




            #region 6. Given an array list , implement a function to remove all odd numbers from it.
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Helper.RemoveoddNumber(list);
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion

         

            #region 8.Create a function that pushes a series of integers onto a stack.Then, search for a target integer in the stack.If the target is found, print a message indicating that the target was found how many elements were checked before finding the target(“Target was found successfully and the count = 5”).If the target is not found, print a message indicating that the target was not found(“Target was not found”).

            //Helper.CreateQ();

            //Stack<int> stack = new Stack<int>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    stack.Push(i);
            //}
            //int target;
            //do
            //{
            //    Console.WriteLine("Please enter your target");
            //}
            //while (!int.TryParse(Console.ReadLine(), out target));

            //Helper.SearchTargetInStack(stack, target); 
            #endregion





            #region  9.Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
            //int[] num1 = { 1, 2, 3, 4, 4 };
            //int[] num2 = { 10, 4, 4 };

            //int[] res = Helper.Intersection(num1, num2);

            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion


            #region  10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
            //ArrayList list = new ArrayList() { 1, 2, 3, 7, 5 };
            //int target = 12;
            //int[] res = Helper.FindTarget(list, target);

            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion

            #region  11.Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order

            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= 5; i++)
                queue.Enqueue(i);
            int k = 3;
            Helper.ReversekElements(queue, k);
            Console.WriteLine($"Queue after reverse first {k} elements");
            foreach (int i in queue)
                Console.Write(i + " ");
            #endregion
        }
    }
}
