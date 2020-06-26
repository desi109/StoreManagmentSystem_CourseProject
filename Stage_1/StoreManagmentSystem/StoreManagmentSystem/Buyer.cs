using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem
{
    public class Buyer : Person
    {
        public Decimal Bill { get; set; }

        public Buyer()
        {
        }

        public Buyer(string id, string name, decimal bill) : base(id, name)
        {
            this.Id = id;
            this.Name = name;
            this.Bill = bill;
        }

        public decimal getNewProduct(decimal newCostPrice)
        {
            decimal currentBill = countBill(this.Bill, newCostPrice);
             
            return currentBill;
        }


        public override string ToStringPerson()
        {
            return string.Format("Id = {0}, Name = {1}, Bill = {2}\n", Id, Name, Bill);
        }

        protected decimal countBill(decimal bill, decimal newProductsPrice) 
        {
            bill += newProductsPrice;
            return bill;
        }
    }
}
