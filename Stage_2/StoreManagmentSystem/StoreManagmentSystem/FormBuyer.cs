using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManagmentSystem
{
    public partial class FormBuyer : Form
    {
        public Buyer _buyer = new Buyer();

        public FormBuyer()
        {
            InitializeComponent();
        }

        internal Buyer Buyer {
            get { return _buyer; }
            set
            {
                _buyer = value;

                idBuyerTb.Text = _buyer.Id;
                nameBuyerTb.Text = _buyer.Name;
                billBuyerTb.Text = _buyer.Bill.ToString(); 
            }
        }

        private void buyNewBuyerBtn_Click(object sender, EventArgs e)
        {
            saveBuyerBtn_Click(null, null);
            var formMakePurchaseBuyer = new FormMakePurchaseBuyer();
            formMakePurchaseBuyer.Buyer = _buyer;

            if (formMakePurchaseBuyer.ShowDialog() == DialogResult.OK)
            {
                purchasedProductsBuyerListB_Update();
            }
        }

        private void saveBuyerBtn_Click(object sender, EventArgs e)
        {
            XDocument xmlDocument = XDocument.Load(Constant.DATA_PATH_PEOPLE);

            int idB = int.Parse(
                    string.Join("", (
                    from id in XDocument.Load(Constant.DATA_PATH_IDS)
                    .Element("Ids")
                    .Elements("Id")
                    where (((string)id.Element("Type")).Equals("B"))
                    select id.Element("Value").Value.ToString()).ToList()));

            if (Constant.IS_BUYER_NEW)
            {
                xmlDocument.Element("People").Add(
                    new XElement("Person",
                    new XElement("PersonId", idB.ToString() + "b"),
                    new XElement("Name", nameBuyerTb.Text.Trim()),
                    new XElement("Bill", 0)
                    ));

                XDocument xmlDocumentIds = XDocument.Load(Constant.DATA_PATH_IDS);
                xmlDocumentIds
                    .Element("Ids")
                    .Elements("Id")
                    .Where(x => ((string)x.Element("Type").Value).Equals("B"))
                    .Select(x => x.Element("Value"))
                    .FirstOrDefault()
                    .SetValue(idB + 1);
                xmlDocumentIds.Save(Constant.DATA_PATH_IDS);
            }
            else
            {
                xmlDocument.Element("People")
                    .Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(idBuyerTb.Text))
                    .Select(x => x.Element("Name"))
                    .FirstOrDefault()
                    .SetValue(nameBuyerTb.Text.Trim());

                xmlDocument.Element("People")
                    .Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(idBuyerTb.Text))
                    .Select(x => x.Element("Bill"))
                    .FirstOrDefault()
                    .SetValue(_buyer.Bill);
            }

            xmlDocument.Save(Constant.DATA_PATH_PEOPLE);
            DialogResult = DialogResult.OK;
            purchasedProductsBuyerListB_Update();
        }


        public void purchasedProductsBuyerListB_Update()
        {
            purchasedProductsBuyerListB.Items.Clear();

            var items = from item in XDocument
                                         .Load(Constant.DATA_PATH_ITEMS)
                                         .Descendants("Item")
                            let personId = (string)item.Element("PersonId")
                            where ((personId + "b").Equals(idBuyerTb.Text))
                            select new Item(
                                item.Element("PersonId").Value,
                                int.Parse(item.Element("ProductId").Value),
                                int.Parse(item.Element("Amount").Value));

            _buyer.Bill = 0;

            foreach (var item in items) 
            {
                int itemId = item.ProductId;
                int itemAmount = item.Amount;

                var productCurrType = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                            let productId = (string)product.Element("ProductId")
                            where (productId.Equals(itemId.ToString()))
                            select product.Element("Type").Value;
                string productCurrTypeStr = string.Join("", productCurrType.ToList());
                
                var productCurrModel = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                                      let productId = (string)product.Element("ProductId")
                                      where (productId.Equals(itemId.ToString()))
                                      select product.Element("Model").Value;
                string productCurrModelStr = string.Join("", productCurrModel.ToList());

                string result = "Model: " + productCurrModelStr + ", Type: " + productCurrTypeStr + ", Amount: " + itemAmount;
                purchasedProductsBuyerListB.Items.Add(result);

                var productCurrPrice = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                                      let productId = (string)product.Element("ProductId")
                                      where (productId.Equals(itemId.ToString()))
                                      select product.Element("Price").Value;
                decimal productCurrPriceInt = decimal.Parse(string.Join("", productCurrPrice.ToList()));
                decimal bill = _buyer.Bill;
                _buyer.Bill = Buyer.countBill(bill, (productCurrPriceInt * itemAmount));

                XDocument xmlDocument = XDocument.Load(Constant.DATA_PATH_PEOPLE);
                xmlDocument.Root.Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(_buyer.Id.ToString()))
                    .FirstOrDefault()
                    .SetElementValue("Bill", _buyer.Bill);
                xmlDocument.Save(Constant.DATA_PATH_PEOPLE);
            }

            billBuyerTb.Text = _buyer.Bill.ToString();
        }

        private void deleteSelectedBuyerBtn_Click(object sender, EventArgs e)
        {
            if (purchasedProductsBuyerListB.SelectedItem == null)
            {
                return;
            }

            DialogResult doYouWantToDeletePurchase =
                MessageBox.Show("Do you want to delete the selected Purchase?", "", MessageBoxButtons.OKCancel);

            if (doYouWantToDeletePurchase == DialogResult.Cancel)
            {
                return;
            }
            else if (doYouWantToDeletePurchase == DialogResult.OK)
            {
                string[] selectedPurchase = (purchasedProductsBuyerListB.SelectedItem.ToString()
                .Replace("Model: ", "/").Replace(", Type: ", "/").Replace(", Amount: ", "/")).Split('/');
                
                var selectedPurchaseProductId = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                                                let productType = (string)product.Element("Type")
                                                let productModel = (string)product.Element("Model")
                                                where (productType.Equals(selectedPurchase[2].ToString()) && 
                                                productModel.Equals(selectedPurchase[1].ToString()))
                                                select int.Parse(product.Element("ProductId").Value);
                string selectedPurchaseProductIdStr = string.Join("", selectedPurchaseProductId.ToList());

               var item = new Item(idBuyerTb.Text.Replace("b",""), int.Parse(selectedPurchaseProductIdStr), int.Parse(selectedPurchase[3]));
               purchasedProductsBuyerListB.Items.Add(selectedPurchaseProductIdStr);

                //remove item from the purchasedProductsBuyerListB
                purchasedProductsBuyerListB.Items.Remove(purchasedProductsBuyerListB.SelectedItem);

                //search for the selected item in Items.xml and delete it
                XDocument xmlDocumentItems = XDocument.Load(Constant.DATA_PATH_ITEMS);
                xmlDocumentItems.Root.Elements("Item")
                    .Where(x => ((string)x.Element("PersonId")).Equals(item.PersonId.ToString()) &&
                    ((string)x.Element("ProductId")).Equals(item.ProductId.ToString()) &&
                    ((string)x.Element("Amount")).Equals(item.Amount.ToString()))
                    .Remove();
                xmlDocumentItems.Save(Constant.DATA_PATH_ITEMS);

                purchasedProductsBuyerListB_Update();
            }     
        }
    }
}
