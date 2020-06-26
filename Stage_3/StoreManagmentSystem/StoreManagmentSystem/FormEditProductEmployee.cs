using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManagmentSystem
{
    public partial class FormEditProductEmployee : Form
    {
        public Product _product = new Product();

        public FormEditProductEmployee()
        {
            InitializeComponent();
        }

        internal Product Product
        {
            get { return _product; }
            set
            {
                _product = value;

                idProductEditTb.Text = _product.Id.ToString();
                typeProductEditTb.Text = _product.Type;
                modelProductEditTb.Text = _product.Model;
                priceProductEditTb.Text = _product.Price.ToString();
            }
        }

        private void saveProductEditBtn_Click(object sender, EventArgs e)
        {
            XDocument xmlDocument = XDocument.Load(Constant.DATA_PATH_PRODUCTS);

            int idP = int.Parse(
                    string.Join("", (
                    from id in XDocument.Load(Constant.DATA_PATH_IDS)
                    .Element("Ids")
                    .Elements("Id")
                    where (((string)id.Element("Type")).Equals("P"))
                    select id.Element("Value").Value.ToString()).ToList()));

            if (Constant.IS_PRODUCT_NEW)
            {
                xmlDocument.Element("Products").Add(
                    new XElement("Product",
                    new XElement("ProductId", idP.ToString()),
                    new XElement("Type", typeProductEditTb.Text),
                    new XElement("Model", modelProductEditTb.Text),
                    new XElement("Price", priceProductEditTb.Text)
                    ));

                XDocument xmlDocumentIds = XDocument.Load(Constant.DATA_PATH_IDS);
                xmlDocumentIds
                    .Element("Ids")
                    .Elements("Id")
                    .Where(x => ((string)x.Element("Type").Value).Equals("P"))
                    .Select(x => x.Element("Value"))
                    .FirstOrDefault()
                    .SetValue(idP + 1);
                xmlDocumentIds.Save(Constant.DATA_PATH_IDS);

            }
            else
            {

                xmlDocument.Element("Products")
                    .Elements("Product")
                    .Where(x => ((string)x.Element("ProductId")).Equals(idProductEditTb.Text))
                    .Select(x => x.Element("Type")).FirstOrDefault().SetValue(typeProductEditTb.Text);

                xmlDocument.Element("Products")
                    .Elements("Product")
                    .Where(x => ((string)x.Element("ProductId")).Equals(idProductEditTb.Text))
                    .Select(x => x.Element("Model")).FirstOrDefault().SetValue(modelProductEditTb.Text);

                xmlDocument.Element("Products")
                    .Elements("Product")
                    .Where(x => ((string)x.Element("ProductId")).Equals(idProductEditTb.Text))
                    .Select(x => x.Element("Price")).FirstOrDefault().SetValue(priceProductEditTb.Text);

            }
            xmlDocument.Save(Constant.DATA_PATH_PRODUCTS);
            DialogResult = DialogResult.OK;
        }
    }
}
