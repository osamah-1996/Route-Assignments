using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
	internal class HiringDate
	{
		#region attribute
		private int day;
		private int month;
		private int year; 
		#endregion

		#region Constructor
		public HiringDate()
		{

		}
		public HiringDate(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;

		} 
		#endregion
		public int Day
		{
			get { return day; }
			set { this.day = value>0 && value<=31?value:1; }

		}
		public int Month
		{
			get { return month; }
			set { this.month = value>0 && value<=12?value : 1; }
		}
		public int Year
		{
			get { return year; }
			set { this.year = value>2000 && value<=2025?value: 2020; }
		}
		public override string ToString()
		{
			return $"Day={day} , Month={month}, Year= {year}";
		}
	}
}
