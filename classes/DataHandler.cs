using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG251_ST_Shane_Bekker_.classes
{
    internal class DataHandler
    {
        #region Fields

        private Car __Car__ = new Car();
        private Car a = new Car();
        private List<Car> abuse_bus = new List<Car>();
        private List<Car> abuse_suv = new List<Car>();
        private List<Car> origin = new List<Car>();

        #endregion Fields

        #region Constructors

        public DataHandler()
        {
            populate();
        }

        internal List<Car> Abuse_bus { get => abuse_bus; set => abuse_bus = value; }
        internal List<Car> Abuse_suv { get => abuse_suv; set => abuse_suv = value; }
        internal List<Car> Origin { get => origin; set => origin = value; }

        #endregion Constructors



        #region Methods

        public void populate()
        {
            foreach (Car item in __Car__.additems())
            {
                Origin.Add(item);
                if (item is Bus) { Abuse_bus.Add(item); }
                if (item is Suv) { Abuse_suv.Add(item); }
            }
        }

        public override string ToString()
        {
            return "";
        }

        #endregion Methods
    }
}