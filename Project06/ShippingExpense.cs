using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project06
{
    class ShippingExpense
    {
        //Private fields
        private double Standard;
        private double Express;
        private double SameDay;

        /// <summary>
        /// Set Standard
        /// </summary>
        /// <param name="value"></param>
        public void SetStandard(double value)
        {
            //Set standard equal to value
            Standard = value;
        }

        /// <summary>
        /// Set Express
        /// </summary>
        /// <param name="value"></param>
        public void SetExpress(double value)
        {
            //Set equal to value
            Express = value;
        }

        /// <summary>
        /// Set Same Day
        /// </summary>
        /// <param name="value"></param>
        public void SetSameDay(double value)
        {
            //SetExpress equal to value
            SameDay = value;
        }

        /// <summary>
        /// Get Standard
        /// </summary>
        /// <returns></returns>
        public double GetStandard()
        {
            //return standard
            return Standard;
        }

        /// <summary>
        /// Get Express
        /// </summary>
        /// <returns></returns>
        public double GetExpress()
        {
            //return express
            return Express;
        }

        /// <summary>
        /// Get Same Day
        /// </summary>
        /// <returns></returns>
        public double GetSameDay()
        {
            //return Same Day
            return SameDay;
        }
    }
}
