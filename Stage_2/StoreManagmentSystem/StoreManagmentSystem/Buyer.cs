using System;

namespace StoreManagmentSystem
{
    public class Buyer : Person
    {
        public decimal Bill { get; set; }

        public Buyer()
        {
        }

        public Buyer(string id, string name, decimal bill) : base(id, name)
        {
            this.Id = id;
            this.Name = name;
            this.Bill = bill;
        }

        public override string ToStringPerson()
        {
            return string.Format("Id: {0}, Name: {1}, Bill: {2}", Id, Name, Bill);
        }


        //protected
        public decimal countBill(decimal bill, decimal newProductPrice) 
        {
            bill += newProductPrice;
            return bill;
        }
    }
}
