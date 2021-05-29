using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLifeMathrix
{
    public class Division
    {
        /// <summary>
        /// dividend divided by divisor
        /// return qoutient int
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static int DivideRetInt(int dividend, int divisor)
        {
            return dividend / divisor;
        }
        /// <summary>
        /// dividend divided by divisor
        /// return qoutient double
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static double DivideRetDouble(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        /// <summary> 
        /// dividend divided by divisor
        /// return qoutient decimal
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static decimal DivideRetDouble(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }
    }
}
