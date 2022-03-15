using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Entities
{
    public class Calculator
    {       
        public static double Sum(params double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public static double Subtraction(params double[] numbers)
        {
            double sub = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sub -= numbers[i];
            }
            return sub;
        }
        public static double Multiplication(params double[] numbers)
        {
            double mult = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                mult *= numbers[i];
            }
            return mult;
        }
        public static double Divison(params double[] numbers)
        {

            return numbers[0] / numbers[1];
        }
    }
}

