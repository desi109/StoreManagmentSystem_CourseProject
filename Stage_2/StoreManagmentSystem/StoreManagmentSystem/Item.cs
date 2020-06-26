using System;

namespace StoreManagmentSystem
{
    public class Item
    {
        public String PersonId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public Item()
        {
        }

        public Item(string personId, int productId, int amount)
        {
            this.PersonId = personId;
            this.ProductId = productId;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", PersonId, ProductId, Amount);
        }
    }
}
