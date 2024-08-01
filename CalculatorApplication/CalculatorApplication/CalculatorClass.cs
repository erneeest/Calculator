using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    #region -- Calculation --
    public delegate T Formula<T>(T txtBoxInput1, T txtBoxInput2);

    public class CalculatorClass
    {

        public Formula<double>? info;

        public double GetSum(double txtBoxNum1, double txtBoxNum2)
        {
            return txtBoxNum1 + txtBoxNum2;
        }

        public double GetDifference(double txtBoxNum1, double txtBoxNum2)
        {
            return txtBoxNum1 - txtBoxNum2;
        }

        public double GetProduct(double txtBoxNum1, double txtBoxNum2)
        {
            return txtBoxNum1 * txtBoxNum2;
        }

        public double GetQuotient(double txtBoxNum1, double txtBoxNum2)
        {
            if (txtBoxNum2 == 0)
            {
                throw new DivideByZeroException("Division by 0 is undefined.");
            }
            else
            {
                return txtBoxNum1 / txtBoxNum2;
            }
        }

        public event Formula<double> CalculatorEvent
        {
            add
            {
                Console.WriteLine("Added from delegate");
            }

            remove
            {
                Console.WriteLine("Removed from delegate");
            }
        }

    }
    #endregion
}
