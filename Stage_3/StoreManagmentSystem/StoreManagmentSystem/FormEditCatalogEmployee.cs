using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManagmentSystem
{
    public partial class FormEditCatalogEmployee : Form
    {
        public FormEditCatalogEmployee()
        {
            InitializeComponent();
        }

        private void addProductEditCatalogBtn_Click(object sender, EventArgs e)
        {
            int idP = int.Parse(
                    string.Join("", (
                    from id in XDocument.Load(Constant.DATA_PATH_IDS)
                    .Element("Ids")
                    .Elements("Id")
                    where (((string)id.Element("Type")).Equals("P"))
                    select id.Element("Value").Value.ToString()).ToList()));

            var formEditProductEmployee = new FormEditProductEmployee();
            var product = new Product(idP, "", "", 0);
            formEditProductEmployee.Product = product;

            Constant.IS_PRODUCT_NEW = true;
            if (formEditProductEmployee.ShowDialog() == DialogResult.OK)
            {
                searchProductEditCatalogBtn_Click(null, null);
                Constant.IS_PRODUCT_NEW = false;
            }
        }

        private void searchProductEditCatalogBtn_Click(object sender, EventArgs e)
        {
            productEditCatalogListB.Items.Clear();

            if (productEditCatalogListB.Text.Equals(null))
            {
                var products = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                               let productId = (string)product.Element("ProductId")
                               let productType = (string)product.Element("Type")
                               let productModel = (string)product.Element("Model")
                               let productPrice = (string)product.Element("Price")
                               select new Product(
                                    int.Parse(product.Element("ProductId").Value),
                                    product.Element("Type").Value,
                                    product.Element("Model").Value,
                                    decimal.Parse(product.Element("Salary").Value));

                foreach (var product in products)
                    productEditCatalogListB.Items.Add(product.ToString());
            }
            else
            {
                var products = from product in XDocument
                                         .Load(Constant.DATA_PATH_PRODUCTS)
                                         .Descendants("Product")
                               let productId = (string)product.Element("ProductId")
                               let productType = (string)product.Element("Type")
                               let productModel = (string)product.Element("Model")
                               let productPrice = (string)product.Element("Price")
                               where ((productType.ToLower()).Contains(productForSearchEditCatalogTb.Text.ToLower()) || 
                               (productModel.ToLower()).Contains(productForSearchEditCatalogTb.Text.ToLower()))
                               select new Product(
                                    int.Parse(product.Element("ProductId").Value),
                                    product.Element("Type").Value,
                                    product.Element("Model").Value,
                                    decimal.Parse(product.Element("Price").Value));

                foreach (var product in products)
                    productEditCatalogListB.Items.Add(product.ToString());
            }
        }

        private void productEditCatalogListB_DoubleClick(object sender, EventArgs e)
        {
            if (productEditCatalogListB.SelectedItem == null)
            {
                return;
            }

            var formEditProductEmployee = new FormEditProductEmployee();
            string[] selected = (productEditCatalogListB.SelectedItem.ToString()
                .Replace("Id: ", "/").Replace(", Type: ", "/").Replace(", Model: ", "/")
                .Replace(", Price: ", "/")).Split('/');

            var product = new Product(int.Parse(selected[1]), selected[2], 
                selected[3], decimal.Parse(selected[4]));

            formEditProductEmployee.Product = product;

            if (formEditProductEmployee.ShowDialog() == DialogResult.OK)
            {
                searchProductEditCatalogBtn_Click(null, null);
            }
        }

        private void deleteProductCatalogBtn_Click(object sender, EventArgs e)
        {
            if (productEditCatalogListB.SelectedItem == null)
            {
                return;
            }

            DialogResult doYouWantToDeleteProduct =
                MessageBox.Show("Do you want to delete the Product?", "", MessageBoxButtons.OKCancel);

            if (doYouWantToDeleteProduct == DialogResult.Cancel)
            {
                return;
            }
            else if (doYouWantToDeleteProduct == DialogResult.OK)
            {
                //get the selected product
                string[] selected = (productEditCatalogListB.SelectedItem.ToString()
                .Replace("Id: ", "/").Replace(", Type: ", "/").Replace(", Model: ", "/")
                .Replace(", Price: ", "/")).Split('/');

                var product = new Product(int.Parse(selected[1]), selected[2], selected[3], decimal.Parse(selected[4]));

                //remove product from the productEditCatalogListB
                productEditCatalogListB.Items.Remove(productEditCatalogListB.SelectedItem);

                //search for the selected product in Products.xml and delete it
                XDocument xmlDocumentProducts = XDocument.Load(Constant.DATA_PATH_PRODUCTS);
                xmlDocumentProducts.Root.Elements("Product")
                    .Where(x => ((string)x.Element("ProductId")).Equals(product.Id.ToString()) && 
                    ((string)x.Element("Model")).Equals(product.Model))
                    .Remove();
                xmlDocumentProducts.Save(Constant.DATA_PATH_PRODUCTS);


                //add deleted to DeletedProducts.xml
                XDocument xmlDocumentDeletedProducts = XDocument.Load(Constant.DATA_PATH_DELETED_PRODUCTS);
                xmlDocumentDeletedProducts.Element("Products").Add(
                    new XElement("Product",
                    new XElement("ProductId", product.Id),
                    new XElement("Type", product.Type),
                    new XElement("Model", product.Model),
                    new XElement("Price", product.Price)
                    ));
                xmlDocumentDeletedProducts.Save(Constant.DATA_PATH_DELETED_PRODUCTS);
            }
        }
    }
}
