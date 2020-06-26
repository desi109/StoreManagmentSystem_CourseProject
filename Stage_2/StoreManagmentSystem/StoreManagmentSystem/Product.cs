using System;

namespace StoreManagmentSystem
{
    public class Product
    {
        public int Id { get; set; }
        public String Type { get; set; }
        public String Model { get; set; }
        public decimal Price { get; set; }

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

        public override string ToString()
        {
            return string.Format("Id: {0}, Type: {1}, Model: {2}, Price: {3}", Id, Type, Model, Price);
        }

        public string ToStringProductForBuyer()
        {
            return string.Format("Model: {0}, Type: {1}, Price: {2}", Model, Type, Price);
        }

    }
}
