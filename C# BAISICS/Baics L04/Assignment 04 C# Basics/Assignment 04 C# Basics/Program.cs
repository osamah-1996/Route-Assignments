using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int number;
            //bool userInput;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    userInput = int.TryParse(Console.ReadLine(), out number);

            //} while (!userInput);
            //for (int i = 1; i < number; i++)
            //    Console.Write(i + " ");
            #endregion

            #region 2- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.

            //int number;
            //bool userInput;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    userInput = int.TryParse(Console.ReadLine(), out number);

            //} while (!userInput);

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{number}*{i} ={number * i}   ");

            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //int number;
            //bool userINput;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    userINput = int.TryParse(Console.ReadLine(), out number);

            //} while (!userINput);

            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");

            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //bool userInput1, userInput2;
            //int number1, power;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    userInput1 = int.TryParse(Console.ReadLine(), out number1);
            //    Console.Write("Enter Power :");
            //    userInput2 = int.TryParse(Console.ReadLine(), out power);

            //} while (!(userInput1 && userInput2));
            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= number1;
            //}

            //Console.WriteLine(result);

            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] arr = new int[5];
            //int total = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool userinput;
            //    do
            //    {
            //        Console.Write($"Enter The Value of Subject No.{i + 1}:");
            //        userinput = int.TryParse(Console.ReadLine(), out arr[i]);

            //    } while (!userinput);

            //    total += arr[i];

            //}
            //Console.WriteLine($"Total of subjects = {total}");
            //double average = total / 5.0;
            //Console.WriteLine($"Average = {average}");
            //double percentage = total / 500.0 * 100;
            //Console.WriteLine($"Percentage = {percentage}%");

            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter Word : ");
            //string word = Console.ReadLine();
            //Console.Write("Word after reversing : ");
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}

            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //bool userInput;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    userInput = int.TryParse(Console.ReadLine(), out number);

            //} while (!userInput);

            //int rem = 0, reversed = 0; ;
            //while (number > 0)
            //{
            //    rem = number % 10;
            //    reversed = (reversed * 10) + rem;
            //    number = number / 10;

            //}
            //Console.WriteLine($"Number after reversing = {reversed}");
            #endregion

            #region 8 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            //bool userInput1, userInput2;
            //int start, end;
            //do
            //{
            //    Console.Write("Enter start : ");
            //    userInput1 = int.TryParse(Console.ReadLine(), out start);
            //    Console.Write("Enter End :");
            //    userInput2 = int.TryParse(Console.ReadLine(), out end);

            //} while (!(userInput1 && userInput2));
            //bool flag3 = true;

            //for (int i = start; i <= end; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            flag3 = false;
            //            break;
            //        }
            //    }
            //    if (flag3 && i != 1)
            //        Console.WriteLine($"{i} is Prime Number");

            //    flag3 = true;
            //}

            #endregion

            #region 9-Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //bool UserINput;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    UserINput = int.TryParse(Console.ReadLine(), out number);

            //} while (!UserINput);
            //string result = string.Empty;
            //while (number > 0)
            //{
            //    int rem = number % 2;
            //    result = rem + result;
            //    number = number / 2;


            //}

            //Console.WriteLine(result);



            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //bool userInput01, userInput02;
            //int x1, y1, x2, y2, x3, y3;
            //do
            //{
            //    Console.Write("Enter Point  [x1]:");
            //    userInput01 = int.TryParse(Console.ReadLine(), out x1);
            //    Console.Write("Enter Point  [y1]:");
            //    userInput02 = int.TryParse(Console.ReadLine(), out y1);
            //} while (!(userInput01 && userInput02));

            //do
            //{
            //    Console.Write("Enter Point  [x2]:");
            //    userInput01 = int.TryParse(Console.ReadLine(), out x2);
            //    Console.Write("Enter Point  [y2]:");
            //    userInput02 = int.TryParse(Console.ReadLine(), out y2);
            //} while (!(userInput01 && userInput02));

            //do
            //{
            //    Console.Write("Enter Point  [x3]:");
            //    userInput01 = int.TryParse(Console.ReadLine(), out x3);
            //    Console.Write("Enter Point  [y3]:");
            //    userInput02 = int.TryParse(Console.ReadLine(), out y3);
            //} while (!(userInput01 && userInput02));

            //int slope1 = (y2 - y1) / (x2 - x1);
            //int slope2 = (y3 - y2) / (x3 - x2);
            //if (slope1 == slope2)
            //    Console.WriteLine("All Points on same straight line");
            //else
            //    Console.WriteLine("All Points on different points on the line");
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //bool userINput;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    userINput = int.TryParse(Console.ReadLine(), out number);
            //} while (!userINput);
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= number; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine($"Sum of array elements = {sum}");
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 1, 3, 2, 5, 4 };
            //int[] arr2 = { 9, 7, 8, 10, 6 };
            //int[] arr3 = new int[10];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr3[i] = arr1[i];
            //}
            //int j = 0;
            //for (int i = 5; i < arr3.Length; i++)
            //{
            //    arr3[i] = arr2[j];
            //    j++;

            //}
            //int temp = 0;
            //for (int i = 0; i < arr3.Length-1; i++)
            //{
            //    for(int c=i+1; c<arr3.Length;c++)
            //    {
            //        if (arr3[i] > arr3[c])
            //        {
            //            temp = arr3[i];
            //            arr3[i] = arr3[c];
            //            arr3[c] = temp;

            //        }
            //    }

            //}

            //Console.WriteLine("After Merging and sorting");

            //foreach (int i in arr3)
            //{
            //    Console.WriteLine(i + " ");



            //}
            #endregion

            #region 14 - Write a program in C# Sharp to count the frequency of each element of an array.
            //int size;
            //bool userINput;
            //do
            //{
            //    Console.Write("Enter size of array : ");
            //    userINput = int.TryParse(Console.ReadLine(), out size);

            //} while (!userINput);

            //int[] arr = new int[size];
            //int[] freq = new int[size];
            //bool flagArr;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter Element No.{i + 1}:");
            //        flagArr = int.TryParse(Console.ReadLine(), out arr[i]);
            //        freq[i] = -1;

            //    } while (!flagArr);

            //}
            //int counter = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    counter = 1;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            counter++;
            //            freq[j] = 0;

            //        }
            //    }

            //    if (freq[i] != 0)
            //    {
            //        freq[i] = counter;
            //    }

            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (freq[i] != 0)
            //    {
            //        Console.WriteLine($"The value {arr[i]} in array is repeated {freq[i]} times");
            //    }
            //}





            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //int size;
            //bool userINput;
            //do
            //{
            //    Console.Write("Enter size of array : ");
            //    userINput = int.TryParse(Console.ReadLine(), out size);

            //} while (!userINput);


            //int[] arr = new int[size];
            //bool flagArr;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter element No.{i + 1}:");
            //        flagArr = int.TryParse(Console.ReadLine(), out arr[i]);

            //    } while (!flagArr);

            //}
            //int max = arr[0], min = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];

            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine($"Max element in array = {max}");
            //Console.WriteLine($"Min element in array = {min}");

            #endregion

            #region  16 - Write a program in C# Sharp to find the second largest element in an array.

            //int size;
            //bool userInput;
            //do
            //{
            //    Console.Write("Enter size of array : ");
            //    userInput = int.TryParse(Console.ReadLine(), out size);
            //} while (!userInput);
            //int[] arr = new int[size];
            //bool flagArr;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter element No.{i + 1}:");
            //        flagArr = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flagArr);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            (arr[i], arr[j]) = (arr[j], arr[i]);
            //        }
            //    }
            //}

            //Console.WriteLine($"The second Max element = {arr[1]}");

            #endregion

            #region  17 -.Consider an Array of Integer values with size N, having values as in this Example
            //int size;
            //bool userINput;
            //do
            //{
            //    Console.Write("Enter size of array : ");
            //    userINput = int.TryParse(Console.ReadLine(), out size);
            //} while (!userINput);

            //int[] arr = new int[size];
            //int distance = 0;
            //bool flag2;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter element No.{i + 1}:");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flag2);

            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            if (distance < j - i - 1)
            //            {
            //                distance = j - i - 1;
            //            }
            //        }

            //    }
            //}

            //Console.Write($"Max distance = {distance}");


            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.

            //Console.Write("Enter words : ");
            //string words=Console.ReadLine();    


            //string result=string.Empty;
            //string[] strings = words.Split(" ");
            //for (int i = strings.Length - 1; i >= 0; i--)
            //{
            //    result += strings[i]+" ";
            //}

            //Console.Write(result);


            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //int sizefRows, sizeOfCols;
            //bool userINput01, userINput02;

            //do
            //{
            //    Console.Write("Enter size of rows : ");
            //    userINput01 = int.TryParse(Console.ReadLine(), out sizefRows);
            //    Console.Write("Enter size of Coloumns : ");
            //    userINput02 = int.TryParse(Console.ReadLine(), out sizeOfCols);
            //} while (!(userINput01 && userINput02));

            //int[,] arr = new int[sizefRows, sizeOfCols];
            //int[,] arr2 = new int[sizefRows, sizeOfCols];

            //bool userINput03;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter the values  row No. {i + 1} : ");
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        do
            //        {
            //            Console.Write($"Enter value of col No.{j + 1}:");
            //            userINput03 = int.TryParse(Console.ReadLine(), out arr[i, j]);
            //        } while (!userINput03);

            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr2[i, j] = arr[i, j];
            //    }

            //}

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The values In Row No.{i + 1}:");
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order
            //int size;
            //bool userInput;
            //do
            //{
            //    Console.Write("Enter size of array : ");
            //    userInput = int.TryParse(Console.ReadLine(), out size);
            //} while (!userInput);
            //int[] arr = new int[size];
            //bool flagArr;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter element No.{i + 1}:");
            //        flagArr = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flagArr);
            //}

            //Console.WriteLine("The array in reversed order : ");
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion









        }
    }
}
