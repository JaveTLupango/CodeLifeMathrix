using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLifeMathrix
{
    public class Multiplication
    {
        /// <summary>
        /// multiplicant multiply multiflier
        /// return product int
        /// </summary>
        /// <param name="multiplicant"></param>
        /// <param name="multiflier"></param>
        /// <returns></returns>
        public static int MultiplyRetInt(int multiplicant, int multiflier)
        {
            return multiplicant * multiflier;
        }

        /// <summary>
        /// multiplicant multiply array of multiflier
        /// </summary>
        /// <param name="multiplicant"></param>
        /// <param name="multiflier"></param>
        /// <returns></returns>
        public static int MultiplyArrayRetInt(int multiplicant, int[] multiflier)
        {
            for (int i = 0; i < multiflier.Length; i++)
            {
                multiplicant = multiplicant * multiflier[i];
            }
            return multiplicant;
        }

        /// <summary>
        /// multiplicant multiply multiflier
        /// </summary>
        /// <param name="multiplicant"></param>
        /// <param name="multiflier"></param>
        /// <returns></returns>
        public static double MultiplyRetDouble(double multiplicant, double multiflier)
        {
            return multiplicant * multiflier;
        }

        /// <summary>
        /// multiplicant multiply array of multiflier
        /// return product double
        /// </summary>
        /// <param name="multiplicant"></param>
        /// <param name="multiflier"></param>
        /// <returns></returns>
        public static double MultiplyArrayRetDouble(double multiplicant, double[] multiflier)
        {
            for (int i = 0; i < multiflier.Length; i++)
            {
                multiplicant = multiplicant * multiflier[i];
            }
            return multiplicant; 
        }

        /// <summary>
        /// multiplicant multiply multiflier
        /// return product decimal
        /// </summary>
        /// <param name="multiplicant"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static decimal MultiplyRetDecimal(decimal multiplicant, decimal multiplier)
        {
            return multiplicant * multiplier;
        }

        /// <summary>
        /// multiplicant multiply array multiflier
        /// return product decimal
        /// </summary>
        /// <param name="multiplicant"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static decimal MultiplyArrayRetDecimal(decimal multiplicant, decimal[] multiplier)
        {
            for (int i = 0; i < multiplier.Length; i++)
            {
                multiplicant = multiplicant * multiplier[i];
            }
            return multiplicant;
        }

    }

}
