using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignement_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            /*
               Create an Enum called "WeekDays" 
               with the days of the week (Monday to Sunday) as its members. 
               Then, write a C# program that prints out all the days of the week using this Enum.
             */
            /*
                 int i = 0;
                foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                {
                    i++;
                    Console.WriteLine($"{i} ) {day}");
                }
            */
            #endregion

            #region Question 02
            /*
             Create an Enum called "Seas on" with the four seasons 
             (Spring, Summer, Autumn, Winter) as its members. 
             Write a C# program that takes a season name as input from the user 
             and displays the corresponding month range for that season. 
             Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
             */
            /*

                 Seasons mySeason = new Seasons();
        bool isParesed;
        Seasons selectedSeason;
        do
        {
            Console.WriteLine("PLease Enter Season Name  :");
            isParesed = Enum.TryParse<Seasons>(Console.ReadLine(), out selectedSeason);
        }
        while (!isParesed);
        switch (selectedSeason)
        {
            case Seasons.Spring:
                Console.WriteLine("Spring: March to May");
                break;
            case Seasons.Summer:
                Console.WriteLine("Summer: June to August");
                break;
            case Seasons.Autumn:
                Console.WriteLine("Autumn: September to November");
                break;
            case Seasons.Winter:
                Console.WriteLine("Winter: December to February");
                break;
            default:
                Console.WriteLine("Unknown season.");
                break;
        }
             */



            #endregion


            #region Question 03
            /*
              Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           
              Create Variable from previous Enum to Add and Remove Permission from variable, 
              check if specific Permission existed inside variable
             */


            /*
                Permissions userPermissions = Permissions.None;
                Console.WriteLine("Enter permissions to add (e.g., Read, Write, Delete, Execute):");
                string input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Permissions parsedPermissions))
                {
                    userPermissions |= parsedPermissions; // Add the permissions
                    Console.WriteLine($"Permissions added! Current Permissions: {userPermissions}");
                }
                else
                {
                    Console.WriteLine("Invalid input. No permissions were added.");
                }
                Console.WriteLine("\nChecking if Write permission exists...");
                if ((userPermissions & Permissions.Write) == Permissions.Write)
                {
                    Console.WriteLine("Write permission exists.");
                }
                else
                {
                    Console.WriteLine("Write permission does not exist.");
                }
                Console.WriteLine("\nRemoving Write permission...");
                userPermissions &= ~Permissions.Write;
                Console.WriteLine($"Current Permissions after removal: {userPermissions}");
             */

            #endregion


            #region Question 04
            /*
                Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
                Write a C# program that takes a color name as input from the user and displays a message 
                indicating whether the input color is a primary color or not.
             */

            colors UserColor;
            Console.WriteLine("Write a color:");

            // Parse input to enum, case-insensitively
            bool isParsed = Enum.TryParse<colors>(Console.ReadLine(), true, out UserColor);

            if (isParsed && (UserColor == colors.Green || UserColor == colors.Red || UserColor == colors.Blue))
            {
                Console.WriteLine($"{UserColor} is a primary color.");
            }
            else
            {
                Console.WriteLine("Input is not a valid primary color.");
            }


            #endregion

            Console.ReadKey();
}
}
}
