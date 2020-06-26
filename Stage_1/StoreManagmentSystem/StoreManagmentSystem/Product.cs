using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem
{
    class Product
    {
        public int Id { get; set; }
        public String Type { get; set; }
        public String Model { get; set; }
        public Decimal Price { get; set; }

        public Product()
        {
        }

        public Product(int id, string type, string model, decimal price)
        {
            this.Id = id;
            this.Type = type;
            this.Model = model;
            this.Price = price;
        }

        public string ToStringProduct()
        {
            return string.Format(" Id = {0}, Type = {1}, Model = {2}, Price = {3}\n", Id, Type, Model, Price);
        }

    }
}
