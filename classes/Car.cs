using System.Collections.Generic;

namespace PRG251_ST_Shane_Bekker_.classes
{
    internal interface Cars
    {
        #region Methods

        double CalculateDiscount();

        #endregion Methods
    }

    internal class Car
    {
        #region Fields

        private List<Car> Collection = new List<Car>();
        public string Afforadbility1;
        public double discount;
        public string Name1;
        public double Price1;
        public string type;

        #region 0

        //my pc auto formats my code so i cant get the colums as i want them
        public string Name { get => Name1; set => Name1 = value; }

        public double Price { get => Price1; set => Price1 = value; }
        public string Type { get => type; set => type = value; }

        #endregion 0

        #region 1

        public string Affordability { get => Afforadbility1; set => Afforadbility1 = value; }
        public double Discounted { get => discount; set => discount = value; }

        #endregion 1

        #endregion Fields

        #region Constructors

        // default
        public Car() { }

        public Car(string name, double price)
        {
            this.Name1 = name;
            this.Price1 = price;
        }

        #endregion Constructors



        #region Methods

        public List<Car> additems()
        {
            Collection.Add(new Bus("DAF", 67900.00));
            Collection.Add(new Bus("Man", 40000.00));
            Collection.Add(new Bus("Nissan", 19000.00));
            Collection.Add(new Bus("Scania", 30400.00));

            Collection.Add(new Suv("Benz", 57000.00));
            Collection.Add(new Suv("Nissan", 34000.00));
            Collection.Add(new Suv("Opel", 19000.00));
            Collection.Add(new Suv("Toyata", 25000.00));
            return Collection;
        }

        public virtual double CalculateDiscount()
        {
            return 0;
        }

        #endregion Methods



        #region Methods
    }

    #endregion Methods
}