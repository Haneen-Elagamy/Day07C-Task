using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Car:IMovable
    {
        
        #region properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructors
        //default Ctor
        public Car()
        {

        }

        public Car(int id, string brand, decimal price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }

        public Car(int id, string brand) : this(id, brand, 500000M)
        {

        }

        public Car(int id) : this(id, "Toyota", 600000M)
        {

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Car Id is {Id}, Brand is {Brand}, Price is {Price}";
        }

        public void Move()
        {
            Console.WriteLine("The car moves fast");
        }
        #endregion

        

    }
}
