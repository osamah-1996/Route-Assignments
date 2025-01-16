using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_C__Basics
{
    public class Program
    {
        #region Methods For Question 01
        //public static void Swap(int X, int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        //public static void Swap(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        //static void IncreaseNumberWithRef(ref int Number)
        //{
        //    Number++;
        //    Console.WriteLine("Number inside the method: " + Number);
        //}
        #endregion

        #region Methods For Question 02
        //public static void IncreaseArrayElement(int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        Arr[0]++;
        //        Console.WriteLine("Array Element inside the method: " + Arr[0]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Array is Null");
        //    }


        //}

        //static void IncreaseArrayElementWithRef(ref int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        Arr[0]++;
        //        Console.WriteLine("Array Element inside the method: " + Arr[0]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Array is Null");
        //    }
        //}

        //static void ChangeArray(int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        Arr = [100, 200, 300];
        //    }
        //}

        //static void ChangeArray(ref int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        Arr = [100, 200, 300];
        //    }
        //}
        #endregion

        #region Method For Question 03

        //public static void getSumSub(int Num1, int Num2, out int Sum, out int Sub)
        //{

        //    Sum = Num1 + Num2;
        //    Sub = Num1 - Num2;

        //}

        #endregion

        #region Method For Question 04

        //public static int SumOfDigits(int Number)
        //{
        //    int Sum = 0;
        //    while (Number > 0)
        //    {
        //        Sum += Number % 10;
        //        Number /= 10;
        //    }
        //    return Sum;
        //}

        #endregion

        #region Method For Question 05

        //public static bool IsPrime(int Number)
        //{
        //    if (Number < 2)
        //        return false;


        //    if (Number == 2)
        //        return true;

        //    if (Number % 2 == 0)
        //        return false;

        //    for (int i = 3; i <= Number - 1; i += 2)
        //    {
        //        if (Number % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        #endregion

        #region Method For Question 06

        //public static void MinMaxArray(int[] Arr, ref int Min, ref int Max)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] < Min)
        //            {
        //                Min = Arr[i];
        //            }
        //            if (Arr[i] > Max)
        //            {
        //                Max = Arr[i];
        //            }
        //        }
        //    }
        //}

        #endregion

        #region Method For Question 07

        //public static void CalculateFactorial(int Number, ref int Factorial)

        //{

        //    for (int i = 1; i <= Number; i++)
        //    {
        //        Factorial *= i;
        //    }

        //}


        #endregion

        #region Method For Question 08

        //public static void ChangeChar(ref string Str, int Index, char NewChar)
        //{

        //    if (Str is not null)
        //    {
        //        char[] CharArray = Str.ToCharArray();
        //        CharArray[Index] = NewChar;
        //        Str = new string(CharArray);
        //    }
        //    else
        //    {
        //        Console.WriteLine("String is Null");
        //    }


        //}
        #endregion

        static void Main(string[] args)
        {
            #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.


            // 1. ValuType Parameters
            // 1.1 Passing by Value
            // General : any ParameterType when not specified as ref or out is passed by value
            // when passing by value in a ValueType parameter, a copy of the value is passed to the method not the actual variable \ value
            // The value passed behaves as input parameter to the method
            // any changes made to the value inside the method will not affect the original value
            // The Copy of the values is changing inside the method but , the actual values remain the same

            // Check Function (IncreaseNumber)

            // NOTE : UNCOMMENT HERE

            //Console.WriteLine("======== ValueType ========");
            //Console.WriteLine("======== Passing By Value ========");
            //int X = 5, Y = 10;
            //Console.WriteLine($"Numbers before swapping: {X} , {Y}");
            //Swap(X , Y ); 
            //Console.WriteLine($"Numbers after swapping: {X} , {Y}");


            // 1.2 Passing by Ref
            // When passing be ref , the actual variable is passed to the method with an alias name
            // The value passed behaves as input and output parameter to the method
            // any changes made to the value inside the method will affect the original value
            // The actual value is changing inside the method and the actual values will change

            // Check Function (IncreaseNumberWithRef)

            // NOTE : UNCOMMENT HERE
            //Console.WriteLine("======== ValueType ========");
            //Console.WriteLine("======== Passing By Value ========");
            //int X = 5, Y = 10;
            //Console.WriteLine($"Numbers before swapping: {X} , {Y}");
            //Swap(ref X, ref Y);
            //Console.WriteLine($"Numbers after swapping: {X} , {Y}");

            #endregion

            #region 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            // 2. ReferenceTypeParameter
            // 2.1 Passing By Value
            // when passing be value in a ReferenceType parameter, we pass the address of the object in the memory to the method
            // in the method , there is a temporary reference (object) to the object in the memory
            // The object is pointing to the same original object in the memory
            // any changes made to the object inside the method will affect the original object => because we have the actual address of the object
            // The Value Passed Behaves as input parameter to the method
            // We must ensure that the oject is refrencing an address [Not Null]


            // Check Function (IncreaseArrayElement)
            // NOTE : UNCOMMENT HERE


            //Console.WriteLine("======== ReferenceType ========");
            //Console.WriteLine("======== Passing By Value ========");
            //int[] Arr = [10, 20];
            //Console.WriteLine("Array Element before the method: " + Arr[0]); // 10
            //IncreaseArrayElement(Arr); // Array Element inside the method: 11
            //Console.WriteLine("Array Element after the method: " + Arr[0]); // 11

            //// Change the object itself effect

            //ChangeArray(Arr); // The array will not change
            //Console.WriteLine(Arr[0]); // 11





            // 2.2 Passing By Ref
            // when passing be ref , we pass the actual object to the method with an alias name
            // in the method , we have the actual object
            // any changes made to the object inside the method will affect the original object => because we have the actual object
            // The Value Passed Behaves as input and output parameter to the method
            // The output will be refrencing a new object in the memory

            // Check Function (IncreaseArrayElementWithRef)
            // NOTE : UNCOMMENT HERE


            ////Console.WriteLine("======== Passing By Ref ========");
            //int[] Arr2 = [10, 20];
            //Console.WriteLine("Array Element before the method: " + Arr2[0]); // 10
            //IncreaseArrayElementWithRef(ref Arr2); // Array Element inside the method: 11
            //Console.WriteLine("Array Element after the method: " + Arr2[0]); // 11 

            //// Change the object itself effect

            //ChangeArray(ref Arr2); // The array will change
            //Console.WriteLine(Arr2[0]); // 100






            #endregion

            #region 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int Num1, Num2, Sum, Sub;

            //do
            //{
            //    Console.Write("Enter Number 1: ");
            //} while (!int.TryParse(Console.ReadLine(), out Num1));

            //do
            //{
            //    Console.Write("Enter Number 2: ");
            //} while (!int.TryParse(Console.ReadLine(), out Num2));

            //getSumSub(Num1, Num2, out Sum, out Sub);

            //Console.WriteLine("The Sum of the Numbers is: " + Sum);
            //Console.WriteLine("The Sub of the Numbers is: " + Sub);
            #endregion

            #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //int Number;

            //do {
            //    Console.Write("Enter a number: ");
            //} while (!int.TryParse(Console.ReadLine(), out Number) || Number == 0);

            //Console.WriteLine("The sum of the digits of the number " + Number + " is: " + SumOfDigits(Number));

            #endregion

            #region 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not

            //int Number;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //} while (!int.TryParse(Console.ReadLine(), out Number));

            //string Result = IsPrime(Number) ? "Prime" : "Not Prime";

            //Console.WriteLine($"The Number {Number} is {Result}");

            #endregion

            #region 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] Arr = [22, 50, 13, 5, 7, 9, 11, 15, 17, 19];
            //int Min = Arr[0];
            //int Max = Arr[0]; // Can use int.MinValue

            //MinMaxArray(Arr, ref Min, ref Max);

            //Console.WriteLine("The Minimum Value in the Array is: " + Min);
            //Console.WriteLine("The Maximum Value in the Array is: " + Max);

            #endregion

            #region 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //int Number , Factorial = 1;

            //do
            //{
            //    Console.Write("Enter a number: ");

            //} while (!int.TryParse(Console.ReadLine(), out Number) || Number < 0);

            //CalculateFactorial(Number , ref Factorial);

            //Console.WriteLine($"The Factorial of {Number} is = {Factorial}");

            #endregion

            #region 8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //string Str;

            //Console.Write("Enter A string: ");

            //Str = Console.ReadLine()?? "No string";

            //int Index;

            //do
            //{
            //    Console.Write("Enter the Index: ");

            //} while (!int.TryParse(Console.ReadLine(), out Index) || Index < 0 || Index >= Str?.Length);

            //char NewChar;

            //do
            //{
            //    Console.Write("Enter the New Char: ");

            //} while (!char.TryParse(Console.ReadLine(), out NewChar));

            //ChangeChar(ref Str, Index, NewChar);

            //Console.WriteLine("The New String is: " + Str);





            #endregion
        }
    }
}
