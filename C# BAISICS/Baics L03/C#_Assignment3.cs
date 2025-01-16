using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }

        }
        static void Main()
        {

            #region Assignment3 : Q1
            //Write a program that allows the user to enter a number then print it.
            /*
            Console.WriteLine("Please Enter a Number :");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("**************************************************");
            Console.WriteLine($"The Number you have Entered is {userNumber
            */
            #endregion


            #region Assignment3: Q2 
            /*
             * Write C# program that converts a string to an integer, 
             * but the string contains non-numeric characters. And mention what will happen
             */

            #endregion


            #region Assignment3: Q3
            /*
             *Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
             */
            /*
             Console.WriteLine("Please Enter the First Number:");
             float FirstNumber = float.Parse(Console.ReadLine());
             Console.WriteLine("Please Enter the Second Number:");
             float SecondtNumber = float.Parse(Console.ReadLine());
             float ResultsSubtract = FirstNumber - SecondtNumber;
             float ResultsAddiation = FirstNumber + SecondtNumber;
             float ResultsMultiplication = FirstNumber + SecondtNumber;
             float ResultsDivition = FirstNumber + SecondtNumber;
             Console.WriteLine("**************************************");
             Console.WriteLine($"{FirstNumber} -  {SecondtNumber} = {ResultsSubtract}");
             Console.WriteLine(FirstNumber + "+" + SecondtNumber + "=" + ResultsAddiation);
             */
            #endregion

            #region Assignment3: Q4
            //Write C# program that Extract a substring from a given string.
            /*
             Console.WriteLine("************************************");
             string MyString = "Osamah Ebrahim Mohammed Shweesh";
             string FirstName = MyString.Substring(0, 6);
             string MidleName = MyString.Substring(7, 7);
             string LastName = MyString.Substring(15);
             Console.WriteLine($"First Name is {FirstName}");
             Console.WriteLine($"Midle Name is{MidleName}");
             Console.WriteLine($"Surname is {LastName}");
             */
            #endregion

            #region Assignment3: Q5
            /*
                Write C# program that Assigning one value type variable to another
                and modifying the value of one variable and mention what will happen
             */
            /*
              int FirstNumber = 10;
             int SecondNumber = FirstNumber;
             Console.WriteLine("Results of the Two Varibales before Modifications");
             Console.WriteLine($"Value of First Number is {FirstNumber}");
             Console.WriteLine($"Value of the Second Number {SecondNumber}");
             Console.WriteLine("***************************************************");
             SecondNumber = 20;
             Console.WriteLine($"Results of the Two Varibales After Modifications");
             Console.WriteLine($"Value of First Number is {FirstNumber}");
             Console.WriteLine($"Value of Second Number is {SecondNumber}");
             Console.WriteLine("We can Observe from the Abouve Code that \n " +
                              "the first part of the code both varibles have the same values.\n " +
                              " whereas the second part wont have same values."); 
             */
            #endregion

            #region Assignment3: Q6
            /*
             * Write C# program that Assigning one reference type variable to another 
             * and modifying the object through one variable and mention what will happen
             */
            /*
             Person firstPerson = new Person();
             firstPerson.Name = "Osamah";
             Person secondPerson = firstPerson;
             Console.WriteLine($"Initial value of firstPerson.Name: {firstPerson.Name}");
             Console.WriteLine($"Initial value of secondPerson.Name: {secondPerson.Name}");
             secondPerson.Name = "Ali";
             Console.WriteLine("\nAfter modifying secondPerson.Name:");
             Console.WriteLine($"Value of firstPerson.Name: {firstPerson.Name}");
             Console.WriteLine($"Value of secondPerson.Name: {secondPerson.Name}");
             */

            #endregion


            #region Assignment3: Q7
            /*
             *  rite C# program that take two string variables and print them as one variable 
             */
            /*
             Console.WriteLine("What is your First Name:");
             string firstName = Console.ReadLine();
             Console.WriteLine("What is your Last Name:");
             string lastName = Console.ReadLine();
             string fullName = string.Concat(firstName, " ", lastName);
             Console.WriteLine($"Full Name is {fullName}");
             */
            #endregion


            #region Assignment3: Q8
            /*
                  Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
                Note : The formula for simple interest is Interest = (principal * rate * time ) /100.

             */
            /*
            Console.WriteLine("Please Write the principal amount :");
            float principalAmount = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please Write the rate of interest :");
            float rateOfInterest = float.Parse(Console.ReadLine());
            float simpleInterest = (principalAmount * rateOfInterest) / 100;
            Console.WriteLine($"The simple Interest is {simpleInterest}");
             */
            #endregion

            #region Assignment3: Q9
            /*
             * Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
             * Note :The formula for BMI is BMI = (Weight)/(Height*Height)
             */
            /*
                Console.WriteLine("Please Write the Weight in kilograms :");
                float weight = float.Parse(Console.ReadLine());
                Console.WriteLine("Please Write the Height in Meters :");
                float height = float.Parse(Console.ReadLine());
                float BMI = (weight / (height*weight));
                Console.WriteLine($"The BMI is {BMI} ");
             */
            #endregion

            #region Assignment3: Q10
            /*
             * Write a program that uses the ternary operator to check if the temperature is too hot, 
             * too cold, or just good. Assign the result in a variable then display the result. 
             * Note : 
                 * that below 10 degrees is "Just Cold"
                 * above 30 degrees is "Just Hot"
                 * anything else is "Just Good"
             */
            /*
             Console.WriteLine("What is the temperature Todat?");
             float temperature = float.Parse(Console.ReadLine());
             string Results = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";
             Console.WriteLine(Results);
             */
            #endregion

            #region Assignment3: Q11
            /*
             * .Write a program that takes the date from the user and displays 
             * it in various formats using string interpolation.
                - Ex :
                  - Today’s date : 20 , 11 , 2001
                  - Today's date : 20 / 11 / 2001
                  - Today's date : 20 – 11 – 2001
             */
            /*
             Console.WriteLine("Please enter the day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nToday's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} – {month} – {year}");
             */
            #endregion

            #region Assignment3: Q12
            /*
             *Write a program that takes a number from the user then 
             *print yes if that number can be divided by 3 and 4 otherwise print no.
             *Example (1)
                - Input: 12 
                - Output: Yes
                - Example (2)
                - Input: 9 
                - Output: No
             */
            /*
                Console.WriteLine("Please enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (number % 3 == 0 && number % 4 == 0)
                {
                Console.WriteLine("Yes");
                }
                else
                {
                Console.WriteLine("No");
                }
             */
            #endregion
            #region Assignment3: Q13
            /*
             * Write a program that allows the user to insert an integer 
             * then print negative if it is negative number otherwise print positive.
             * Example (1)
               - Input: -5
               - Output: negative
               - Example (2)
               - Input: 10
               - Output: positive
             */
            /*
              Console.WriteLine("Please Enter a Number:");
              string number =  Console.ReadLine();
               if (number.StartsWith("-"))
               {
                   Console.WriteLine("Negative");
               }
               else
               {
                   Console.WriteLine("Positive");
               }
             */
            #endregion
            #region Assignment3: Q14
            /*
             *Write a program that takes 3 integers from the user
             *then prints the max element and the min element.
                - Example (1)
                    - Input:7,8,5
                    - Output:
                    - max element = 8
                    - min element = 5
                - Example (2)
                    - Input: 3 6 9
                    - Outputs:
                    - Max element = 9
                    - Min element = 3
             */
            /*
              Console.WriteLine("Please Write the First Integer:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Write the Second Integer:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Write the Third Integer:");
            int thirdNumber = int.Parse(Console.ReadLine());

            // Determine the max and min
            int maxElement = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            int minElement = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));

            // Output the result
            Console.WriteLine($"Max Element = {maxElement}");
            Console.WriteLine($"Min Element = {minElement}");
             */

            #endregion

            #region Assignment3: Q15
            /*
              * Write a program that allows the user to insert 
              * an integer number then check If a number is even or odd.
             */
            /*
             Console.WriteLine("Please Enter a Number :");
            int Number = int.Parse(Console.ReadLine());
            int results = Number % 2;
            if (results == 1)
            {
                Console.WriteLine("It's an Enven Number");

            }
            else
            {
                Console.WriteLine("It is an Odd Number");
            }
             */
            #endregion

            #region Assignment3: Q16
            /*
             * Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) 
             * then print (vowel) otherwise print (consonant).
                - Example (1)
                    - Input: O
                    - Output: vowel
                    - Example (2)
                    - Input: b
                    - Output: Consonant
             * */
            /*
             Console.WriteLine("Please Write a Char (a, e, i, o, u):");
            char userChar = char.Parse(Console.ReadLine());
            switch (userChar)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default: Console.WriteLine("Consonant");
                    break;
            }
             */
            #endregion

            #region Assignment3: Q17
            /*
             *  Write a program to input the month number and print the number of days in that month.
                - Example
                    - Input: Month Number: 1
                    - Output: Days in Month: 31
             */

            Console.WriteLine("Enter the month number (1-12):");
            int month = int.Parse(Console.ReadLine());
            int year = 0;
            int daysInMonth;

            if (month == 2)
            {
                Console.WriteLine("Enter the year:");
                year = int.Parse(Console.ReadLine());

                 bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                daysInMonth = isLeapYear ? 29 : 28;
            }
            else
            {
                // Days in other months
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        daysInMonth = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        daysInMonth = 30;
                        break;
                    default:
                        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                        return;
                }
            }
            Console.WriteLine($"The number of days in month {month} is {daysInMonth}.");
            #endregion













            Console.ReadKey();
}
}
}
