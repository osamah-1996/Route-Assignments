using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign04.Classes
{
    internal class Calculator
    {

        #region Methods Calculator
        public int AddNumbers(int number1 , int number2)  
        {
            return number1 + number2;
        }

        public int AddNumbers(int number1 , int number2 , int number3) 
        {
            return number1 + number2 + number3;
        }

        public double AddNumbers(double number1 , double number2)
        {
            return number1 + number2;
        }
        #endregion
    }
}
