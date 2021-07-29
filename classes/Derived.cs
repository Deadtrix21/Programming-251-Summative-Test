using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG251_ST_Shane_Bekker_.classes
{
    internal class Bus : Car
    {
        #region Constructors

        public Bus()
        {
        }

        public Bus(
            string name,
            double price
         )
        : base(name, price)
        {
            Type = "Bus";
            Discounted = CalculateDiscount();
        }

        #endregion Constructors



        #region Methods

        public override double CalculateDiscount()
        {
            return this.Price * 0.05;
        }

        #endregion Methods
    }

    internal class Suv : Car
    {
        #region Constructors

        public Suv()
        {
        }

        public Suv(
            string name,
            double price
         )
        : base(name, price)
        {
            Type = "Suv";
            Discounted = CalculateDiscount();
        }

        #endregion Constructors



        #region Methods

        public override double CalculateDiscount()
        {
            return this.Price * 0.10;
        }

        #endregion Methods
    }
}