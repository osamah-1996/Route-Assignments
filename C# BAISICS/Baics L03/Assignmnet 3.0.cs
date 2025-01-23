using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;


namespace ConsoleApp1
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {



            #region Q 1.0 : Write a program that allows the user to enter a number then print it.

            //Console.Write("Please Enter a Number :");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //Console.WriteLine($"The Number you Have Entered is {userInput}");
            //Console.WriteLine("Thank You");
            //Console.WriteLine("Press Any Key to Exite.........");

            #endregion


            #region Q 2.0 : Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //bool isInt = true;
            //Console.Write("Please Enter a numerical Number :");

            //if (int.TryParse(Console.ReadLine(), out int userInput))
            //{
            //    Console.WriteLine($"The Number you have Entered is {userInput}");
            //}
            //else
            //{
            //    Console.WriteLine("Soory, the number can not be converted");
            //}
            #endregion

            #region Q 3.0 : Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //Console.Write("Enter Number 1 :");
            //float numberOne  = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number 2 :");
            //float numberTwo = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Binary Oprator :");
            //string operation = Console.ReadLine();
            //switch (operation)
            //{
            //    case "+":
            //        float Result;
            //        Result = numberOne + numberTwo;
            //        Console.WriteLine(string.Format("{0}  + {1}  = {2}", numberOne, numberTwo, Result));
            //        break;
            //    case "-":
            //        Result = numberOne - numberTwo;
            //        Console.WriteLine(string.Format("{0}  -  {1}  = {2}", numberOne, numberTwo, Result));
            //        break;
            //    case "/":
            //        Result = numberOne / numberTwo;
            //        Console.WriteLine(string.Format("{0}  /  {1}  = {2}", numberOne, numberTwo, Result));
            //        break;
            //    case "*":
            //        Result = numberOne * numberTwo;
            //        Console.WriteLine(string.Format("{0}  *  {1}  = {2}", numberOne, numberTwo, Result));
            //        break;
            //    case "%":
            //        Result = numberOne % numberTwo;
            //        Console.WriteLine(string.Format("{0}  %  {1}  = {2}", numberOne, numberTwo, Result));
            //        break;
            //    default:
            //        Console.WriteLine("Sorry, Invalid Operator!");
            //        break;
            //}

            #endregion

            #region Q 4.0  Write C# program that Extract a substring from a given string.
            //Console.Write("What is Your Name :");
            //string userName = Console.ReadLine();
            //Console.WriteLine(userName);
            //Console.WriteLine(userName.Substring(0, 2));
            #endregion

            #region Q 5.0 Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //Console.Write("Write an Integer Numner :");
            //int userInput =int.Parse(Console.ReadLine());
            //Console.WriteLine(userInput);
            ////Assign to another vribel
            //float y = userInput;
            //Console.WriteLine(y.GetType());
            #endregion

            #region Q 6.0 : Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Console.Write("What is your Name :");
            //string userInput = (Console.ReadLine());
            //Console.WriteLine(userInput);
            ////Assign to another vribel
            //string y = userInput;
            //Console.WriteLine(y.GetType());
            #endregion

            #region Q 7.0 : Write C# program that take two string variables and print them as one variable 
            //Console.Write("What is your First Name :");
            //string fName = Console.ReadLine();
            //Console.Write("What is your Last Name :");
            //string lName = Console.ReadLine();
            //Console.Write($"Full Name  : {fName}   {lName}");
            #endregion

            #region Q 8.0 : Write a program that calculates the simple interest given the principal amount, rate of interest, and time.  Note: The formula for simple interest is Interest = (principal * rate * time) / 100.
            //Console.Write("Please Enter the principal amount : ");
            //float.TryParse(Console.ReadLine(), out var principalAmount);
            //Console.Write("Please Enter the Rate of Interest : ");
            //float.TryParse(Console.ReadLine(), out var rateOfInterest);
            //Console.Write("Please Enter the Rate of Time : ");
            //float.TryParse(Console.ReadLine(), out var time);
            //float simpleInterest = (principalAmount * rateOfInterest * time) / 100;
            //Console.WriteLine($"The Simple Intrest is {simpleInterest}");

            #endregion

            #region Q 9.0 : Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters.   Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.Write("PLease Enter the Weight(kilograms) :");
            //float.TryParse(Console.ReadLine(), out var userWeight);
            //Console.Write("PLease Enter the Height(Meters) :");
            //float.TryParse(Console.ReadLine(), out var userHight);
            //float BMI = (userWeight) / (userWeight + userHight);
            //Console.Write($"The BMI for the detailes you Have Entered is {BMI}");
            #endregion

            #region Q 10.0 : Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            /* Note:
              -  that below 10 degrees is "Just Cold"
              - above 30 degrees is "Just Hot"
              - anything else is "Just Good"
            */
            //Console.Write("Please Enter the Weather :");
            //int weather = int.Parse(Console.ReadLine());
            //string resut =  (weather < 10)? "Just Cold" : (weather > 30)? "Just Hot" : "Just Good";
            //Console.Write(resut);
            #endregion

            #region Q 11. 0 : Write a program that takes the date from the user and displays it in various formats using string interpolation.


            #endregion

            #region Q 12.0 : Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Console.Write("Please Enter an Integer Number :");
            //int.TryParse(Console.ReadLine(), out int userInout);
            //int divide = userInout % 3;
            //int divie2 = userInout % 4;
            //if (divide == 0 && divie2 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region  Q 13.0 : Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("PLease Enter an Integer Number :");
            //string userInput = Console.ReadLine();
            //if (userInput.StartsWith("-"))
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}
            #endregion

            #region Q 14.0 : Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.Write("Enter the First Number :");
            //int.TryParse(Console.ReadLine(), out int fNumber);
            //Console.Write("Enter the Second Number :");
            //int.TryParse(Console.ReadLine(), out int sNumber);
            //Console.Write("Enter the Thired Number :");
            //int.TryParse(Console.ReadLine(), out int tNumber);

            //int maxElement = Math.Max(fNumber, Math.Max(sNumber, tNumber));
            //int minElemnt = Math.Min(fNumber, Math.Min(sNumber, tNumber));
            //Console.WriteLine($"The Max Element is {maxElement}");
            //Console.WriteLine($"The Min Element is {minElemnt}");
            #endregion

            #region Q 15.0 :  Write a program that allows the user to insert an integer number then check If a number is even or odd
            //Console.Write("PLease Enter an INteger Number :");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //if (userInput % 2 == 0)
            //{
            //    Console.WriteLine($"{userInput} is an Even Number");
            //}
            //else
            //{
            //    Console.WriteLine($"{userInput} is an Odd Number");

            //}
            #endregion


            #region Q 16.0 : Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Please Write a Chracter :");
            //string myChar = Console.ReadLine();
            //switch (myChar)
            //{
            //    case "a":
            //    case "e":
            //    case "i":
            //    case "o":
            //    case "u":
            //    case "A":
            //    case "E":
            //    case "I":
            //    case "O":
            //    case "U":
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}

            #endregion

            #region Q 17.0 : Write a program to input the month number and print the number of days in that month.
            //Console.Write("Please Enter the Month Number :");
            //int.TryParse(Console.ReadLine(), out int myMonth);
            //switch (myMonth)
            //{
            //    case 1:
            //        Console.WriteLine("January has 31 Days");
            //        break;
            //    case 2:
            //        Console.WriteLine("Febaruary has 28 Days");
            //        break;
            //    case 3:
            //        Console.WriteLine("March has 31 Days");
            //        break;
            //    case 4:
            //        Console.WriteLine("Aprial has 30 Days");
            //        break;
            //    case 5:
            //        Console.WriteLine("May has 31 Days");
            //        break;
            //    case 6:
            //        Console.WriteLine("June has 30 Days");
            //        break;
            //    case 7:
            //        Console.WriteLine("Julay has 31 Days");
            //        break;
            //    case 8:
            //        Console.WriteLine("Agust  has 31 Days");
            //        break;
            //    case 9:
            //        Console.WriteLine("Septemeber has 30 Days");
            //        break;
            //    case 10:
            //        Console.WriteLine("October has 31 Days");
            //        break;
            //    case 11:
            //        Console.WriteLine("November has 30 Days");
            //        break;
            //    case 31:
            //        Console.WriteLine("Decmber has 31 Days");
            //        break;
            //}
            #endregion


            StringBuilder message = new StringBuilder("Hi");
            Console.WriteLine(message);
            Console.Clear();
            message.Append("Route");
            Console.WriteLine(message);
            




















            Console.ReadKey();
        }
    }
}
