using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace OOP02
{
	#region  Q1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
	struct Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
        public Person(string  name, int age)
        {
            Name = name;
			Age = age;
        }
		public override string ToString()
		{
			return $"Name={Name}\n Age={Age}";
		}
	}
	#endregion
	#region Q2.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
	struct Point
	{
		public double X { get; set; }
		public double Y { get; set; }
        public Point(int x, int y)
        {
			X = x;
			Y = y;
        }
		public override string ToString()
		{
			return $" X={X} Y={Y}";
		}
	}
	#endregion
	#region Q3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.



	#endregion
	internal class Program
	{



		#region Q2.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
		#region Create Point
		static Point CreatPoint()
		{
			Point point = new Point();
            Console.WriteLine("Enter X");
			point.X= double.Parse(Console.ReadLine());
			Console.WriteLine("Enter Y");
			point.Y = double.Parse(Console.ReadLine());
			return point ;

		}
		#endregion
		#region Distance
		static double Distance(Point P1, Point P2)
		{
			return Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
		}
		#endregion
		#endregion
		static void Main(string[] args)
		{

			#region Q1.
			//Define a struct "Person" with properties "Name" and "Age".
			//Create an array of three "Person" objects and populate it with data.Then,
			//write a C# program to display the details of all the persons in the array.
			//Person[] person =
			//{
			//	new Person("ahmed",25),
			//	new Person(" ali", 30),
			//	new Person("mona", 40),


			//};
			//foreach (var p in person)
			//{
			//             Console.WriteLine(p);
			//         }

			#endregion
			#region Q2.
			//Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
			//Write a C# program that takes two points as input from the user and calculates
			//the distance between them.
			//         Console.WriteLine(" Enter data of first Point");
			//Point P1= CreatPoint();
			//Console.WriteLine(" Enter data of secound Point");
			//Point P2 = CreatPoint();

			//         Console.WriteLine($" Distance= {Distance(P1,P2)}");

			#endregion
			#region Q3.
			//Create a struct called "Person" with properties "Name" and "Age".
			//Write a C# program that takes details of 3 persons as input from the user and
			//displays the name and age of the oldest person.
			Person[] person = new Person[3];
			for (int i = 0; i < 3; i++)
			{
				string name;
				do
				{
					Console.WriteLine($"Enter name of person {i + 1}");
					name = Console.ReadLine();

				} while ((string.IsNullOrWhiteSpace(name)));
				person[i].Name = name;

				int age;
				bool flag;
				do
				{
					Console.WriteLine($"Enter age of person {i + 1}");
					flag = int.TryParse(Console.ReadLine(), out age);

				} while (!flag);
				person[i].Age = age;
			}
			Person oldest = person[0];
			for (int i = 0; i < 3; i++)
			{
				if (person[i].Age > oldest.Age)
				{
					oldest = person[i];
				}
			}
			Console.WriteLine(oldest);


			#endregion

			//Employee[] employees = Employee.Createemployee(2); 
			//Employee.Insertdata(employees);

			//Console.Clear();
			//Employee.Print(employees);
			//         Console.WriteLine(" After sort");
			//Employee.SortArray(employees);
			//Employee.Print(employees);



		}
	}
}
