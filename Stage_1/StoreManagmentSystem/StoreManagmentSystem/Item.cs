using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem
{
    class Item
    {
        public String PersonId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public Item()
        {
        }

        public Item(string personId, int productId, int amount)
        {
            PersonId = personId;
            ProductId = productId;
            Amount = amount;
        }
    }
}
