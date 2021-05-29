using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLifeMathrix
{
    public class Addition
    {
        /// <summary>
        /// add val1 and val2, return result int
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static int AddRetInt(int val1, int val2)
        { 
            return val1 + val2;
        }

        /// <summary>
        /// add all number inside the val array int
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int AddArrayRetInt(int[] val)
        {
            int ret = 0;
            for (int i = 0; i < val.Length; i++)
            {
                ret = ret + val[i];
            }
            return ret;
        }
        /// <summary>
        ///  add val1 and val2, return result double
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static double AddRetDouble(double val1, double val2)
        {
            return val1 + val2;
        }
        /// <summary>
        /// add all number inside the val array double
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static double AddArrayRetDouble(double[] val)
        {
            double ret = 0;
            for (int i = 0; i < val.Length; i++)
            {
                ret = ret + val[i];
            }
            return ret;
        }
        /// <summary>
        /// add val1 and val2, return result decimal
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static decimal AddRetDecimal(decimal val1, decimal val2)
        {
            return val1 + val2;
        }
        /// <summary>
        /// add all number inside the val array decimal
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static decimal AddArrayRetDecimal(decimal[] val)
        {
            decimal ret = 0;
            for (int i = 0; i < val.Length; i++)
            {
                ret = ret + val[i];
            }
            return ret;
        }
    }
}
