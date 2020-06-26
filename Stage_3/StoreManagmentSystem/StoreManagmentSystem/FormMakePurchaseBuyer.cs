using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManagmentSystem
{
    public partial class FormMakePurchaseBuyer : Form
    {  

        public FormMakePurchaseBuyer()
        {
            InitializeComponent();
        }

        public Item _item;
        public Product _product;
        public Buyer _buyer;

        internal Buyer Buyer
        {
            get { return _buyer; }
            set
            {
                _buyer = value;
            }
        }

        private void searchMakePurchaseBuyerBtn_Click(object sender, EventArgs e)
        {
            productMakePurchaseBuyerListB.Items.Clear();

            if (productForSearchMakePurchaseBuyerTb.Text.Equals(null))
            {
                //search in People.xml and show all products
                var products = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                               select new Product(
                                    int.Parse(product.Element("ProductId").Value),
                                    product.Element("Type").Value,
                                    product.Element("Model").Value,
                                    decimal.Parse(product.Element("Salary").Value));

                foreach (var product in products)
                    productMakePurchaseBuyerListB.Items.Add(product.ToStringProductForBuyer());
            }
            else
            {
                //search in Products.xml for specific product(s) and show the product(s) 
                var products = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                               let productType = (string)product.Element("Type")
                               let productModel = (string)product.Element("Model")
                               where ((productType.ToLower()).Contains(productForSearchMakePurchaseBuyerTb.Text.ToLower()) ||
                               (productModel.ToLower()).Contains(productForSearchMakePurchaseBuyerTb.Text.ToLower()))
                               select new Product(
                                    int.Parse(product.Element("ProductId").Value),
                                    product.Element("Type").Value,
                                    product.Element("Model").Value,
                                    decimal.Parse(product.Element("Price").Value));

                foreach (var product in products)
                    productMakePurchaseBuyerListB.Items.Add(product.ToStringProductForBuyer());
            }
        }

        private void productMakePurchaseBuyerListB_DoubleClick(object sender, EventArgs e)
        {
            amountPurchaseBuyerTb.Text = null;
            selectedProductMakePurchaseTb.Text = null;
            amountMakePurchaseTb.Text = null;

            string[] selected = (productMakePurchaseBuyerListB.SelectedItem.ToString()
                .Replace("Model: ", "").Replace(", Type: ", "/")
                .Replace(", Price: ", "/")).Split('/');

            var productToBuy = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                               let productType = (string)product.Element("Type")
                               let productModel = (string)product.Element("Model")
                               where (productType.Equals(selected[1]) &&
                               productModel.Equals(selected[0]))
                               select product.Element("ProductId").Value;

            string productToBuyId = string.Join("", productToBuy.ToList());

            _product = new Product(int.Parse(productToBuyId), selected[1], selected[0], decimal.Parse(selected[2]));

            typePurchaseBuyerTb.Text = _product.Type + ":";
            modelPurchaseBuyerTb.Text = _product.Model;
            pricePurchaseBuyerTb.Text = _product.Price.ToString();

        }


        private void purchaseOkBtn_Click(object sender, EventArgs e)
        {
            selectedProductMakePurchaseTb.Text = _product.Model;
            amountMakePurchaseTb.Text = amountPurchaseBuyerTb.Text;
        }


        private void buyMakePurchaseBtn_Click(object sender, EventArgs e)
        {
            if (productMakePurchaseBuyerListB.SelectedItem == null || amountPurchaseBuyerTb.Text == null)
            {
                return;
            }

            DialogResult doYouWantToBuyProduct =
                MessageBox.Show("Do you want to buy the Product?", "", MessageBoxButtons.OKCancel);

            if (doYouWantToBuyProduct == DialogResult.Cancel)
            {
                return;
            }
            else if (doYouWantToBuyProduct == DialogResult.OK)
            {
                XDocument xmlDocument = XDocument.Load(Constant.DATA_PATH_ITEMS);
                    xmlDocument.Element("Items").Add(
                new XElement("Item",
                new XElement("PersonId", _buyer.Id.ToString().Replace("b", "")),
                new XElement("ProductId", _product.Id),
                new XElement("Amount", amountPurchaseBuyerTb.Text)
                ));

                xmlDocument.Save(Constant.DATA_PATH_ITEMS);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
