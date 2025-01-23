using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP02
{
	#region enum
	enum Gender
	{
		Male=1,
		Female=2
	}
	[Flags]
	enum SecurityLevel : byte
	{
		Guest=1,
		Developer=2,
		Secrtary=4,
		DBA=8
	}

	#endregion
	internal class Employee  : IComparable
	{
		#region attribute
		private int id;
		private string name;
		private double salary;
		private Gender gender;
		private SecurityLevel securityLevel;
		private HiringDate hiringDate;


        #endregion
        #region Constructor
        public Employee()
        {
            hiringDate = new HiringDate();
        }

        #endregion
        #region Property
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}
		public Gender Gender
		{
			get { return gender; }
			set { gender = value; }
		}
		public SecurityLevel SecurityLevel
		{
			get { return securityLevel; }
			set { securityLevel = value; }
		}
		public HiringDate HiringDate
		{
			get { return hiringDate; }
			set { hiringDate = value; }
		}

		#endregion
		#region tostring
		public override string ToString()
		{
			return
				$"Id= {id} \n Name={name}\n salary={salary}\n Gender= {gender}\n SecurityLevel={securityLevel}\n Hiringdate={hiringDate}";
		}

		#endregion
		#region Create employee
		public static Employee[] Createemployee(int size)
		{
			Employee[] employees = new Employee[size];
			for(int i=0; i<size; i++)
			{
				employees[i]= new Employee();
			}
			return employees;
		}

		#endregion
		#region Insertdata
		public static void Insertdata(Employee[] employee)
		{
			for (int i=0; i< employee.Length; i++)
			{
                Console.WriteLine($"Enter data for employee number {i+1}");
                Console.WriteLine("===========================================");
				bool valid;
				do
				{
					Console.WriteLine(" Id");
					valid = int.TryParse(Console.ReadLine(), out employee[i].id);

				} while (!valid);
				do
				{
                    Console.WriteLine(" name");
					employee[i].name = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(employee[i].name));
				do
				{
					Console.WriteLine(" Salary");
					valid = double.TryParse(Console.ReadLine(), out employee[i].salary);

				} while (!valid);
                Console.WriteLine("Enter 1 for male , 2 For female");
				int gender1;
				do
				{
                    Console.WriteLine(" gender");
					valid= int.TryParse(Console.ReadLine(),out gender1);

                } while (!valid && Enum.IsDefined(typeof(Gender),gender1));
				employee[i].gender =(Gender) gender1;
				Console.WriteLine("Hint: Guest=1 , developer= 2 ,Secretary= 4, DBA=8");
				int sl;
				do
				{
					Console.WriteLine(" Security Level");
					valid = int.TryParse(Console.ReadLine(), out sl);

				} while (!valid || !(sl>0 && sl<=15) );
				employee[i].securityLevel =(SecurityLevel) sl;

				int day, month,year;
				do
				{
                    Console.WriteLine("Day");
					valid= int.TryParse(Console.ReadLine(), out day);

                } while (!valid);
				employee[i].hiringDate.Day = day;
				do
				{
					Console.WriteLine("Month");
					valid = int.TryParse(Console.ReadLine(), out month);

				} while (!valid);
				employee[i].hiringDate.Month = month;
				do
				{
					Console.WriteLine("Year");
					valid = int.TryParse(Console.ReadLine(), out year);

				} while (!valid);
				employee[i].hiringDate.Year = year;
			}
		}

		#endregion
		#region Print
		public static void Print(Employee[] employees )
		{
			for (int i = 0; i < employees.Length; i++) 
			{
                Console.WriteLine($" data of Employe number {i+1}");
                Console.WriteLine("*****************************************");
				Console.WriteLine(employees[i]);
				Console.WriteLine("*****************************************");
			}

		}
		#endregion
		#region Sort
		public static void SortArray(Employee[] employees)
		{
			Array
				.Sort(employees);

		}

		public int CompareTo(object? obj)
		{
			Employee empobj = (Employee)obj;
			if (hiringDate.Year > empobj.hiringDate.Year)
				return 1;
			else if( hiringDate.Year< empobj.hiringDate.Year)
				return -1;
			else
			{
				if (hiringDate.Month > empobj.hiringDate.Month)
					return 1;
				else if (hiringDate.Month < empobj.hiringDate.Month)
					return -1;
				else
				{
					if(hiringDate.Day > empobj.hiringDate.Day)
						return 1;
					else if (hiringDate.Day< empobj.hiringDate.Day)
						return -1;
					else
					{
						return 0;
					}

				}
			}
		}

		#endregion

		#region Compareto

		#endregion

	}

	}
