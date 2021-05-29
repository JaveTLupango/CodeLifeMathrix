using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLifeMathrix
{
    public class Subtraction
    {
        /// <summary>
        /// minuend subtract subtrahend
        /// return result int
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static int SubtractRetInt(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        /// <summary>
        /// minuend subtracted the value of array subtrahend
        /// retun int value
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static int SubtractArrayRetInt(int minuend, int[] subtrahend)
        {
            for (int i = 0; i < subtrahend.Length; i++)
            {
                minuend = minuend - subtrahend[i];
            }
            return minuend;
        }

        /// <summary>
        /// minuend subtract subtrahend
        /// return result double
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static double SubtractRetDouble(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        /// <summary>
        /// minuend subtracted the value of array subtrahend
        /// return result double
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static double SubtractArrayRetDouble(double minuend, double[] subtrahend)
        {
            for (int i = 0; i < subtrahend.Length; i++)
            {
                minuend = minuend - subtrahend[i];
            }
            return minuend;
        }
        /// <summary>
        /// minuend subtract subtrahend
        /// return result decimal
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static decimal SubtractRetDecimal(decimal minuend, decimal subtrahend)
        {
            return minuend - subtrahend;
        }
        /// <summary>
        /// minuend subtracted the value of array subtrahend
        /// return result decimal
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static decimal SubtractArrayRetDecimal(decimal minuend, decimal[] subtrahend)
        {
            for (int i = 0; i < subtrahend.Length; i++)
            {
                minuend = minuend - subtrahend[i];
            }
            return minuend;
        }
    }
}
