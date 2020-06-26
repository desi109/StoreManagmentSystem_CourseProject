using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManagmentSystem
{
    public partial class FormEmployee : Form
    {
        public Employee _employee;

        public FormEmployee()
        {
            InitializeComponent();
        }

        internal Employee Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;

                idEmployeeTb.Text = _employee.Id;
                nameEmployeeTb.Text = _employee.Name;
                salaryEmployeeTb.Text = _employee.Salary.ToString();
                workHoursEmployeeTb.Text = _employee.WorkHours.ToString();
            }
        }

        private void editCatalogEmployeeBtn_Click(object sender, EventArgs e)
        {
            saveEmployeeBtn_Click(null, null);
            var formEditCatalogEmployee = new FormEditCatalogEmployee();

            if (formEditCatalogEmployee.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void saveEmployeeBtn_Click(object sender, EventArgs e)
        {
            XDocument xmlDocument = XDocument.Load(Constant.DATA_PATH_PEOPLE);

            int idE = int.Parse(
                    string.Join("", (
                    from id in XDocument.Load(Constant.DATA_PATH_IDS)
                    .Element("Ids")
                    .Elements("Id")
                    where (((string)id.Element("Type")).Equals("E"))
                    select id.Element("Value").Value.ToString()).ToList()));

            if (Constant.IS_EMPLOYEE_NEW)
            {
                xmlDocument.Element("People").Add(
                    new XElement("Person", 
                    new XElement("PersonId", (idE.ToString() + "e")),
                    new XElement("Name", nameEmployeeTb.Text.Trim()),
                    new XElement("Salary", salaryEmployeeTb.Text),
                    new XElement("WorkHours", workHoursEmployeeTb.Text)
                    ));

                XDocument xmlDocumentIds = XDocument.Load(Constant.DATA_PATH_IDS);
                xmlDocumentIds
                    .Element("Ids")
                    .Elements("Id")
                    .Where(x => ((string)x.Element("Type").Value).Equals("E"))
                    .Select(x => x.Element("Value"))
                    .FirstOrDefault()
                    .SetValue(idE + 1);
                xmlDocumentIds.Save(Constant.DATA_PATH_IDS);

            }
            else
            {
               xmlDocument.Element("People")
                    .Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(idEmployeeTb.Text))
                    .Select(x => x.Element("Name"))
                    .FirstOrDefault()
                    .SetValue(nameEmployeeTb.Text);

                xmlDocument.Element("People")
                    .Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(idEmployeeTb.Text))
                    .Select(x => x.Element("Salary"))
                    .FirstOrDefault()
                    .SetValue(salaryEmployeeTb.Text);

                xmlDocument.Element("People")
                    .Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(idEmployeeTb.Text))
                    .Select(x => x.Element("WorkHours")).FirstOrDefault()
                    .SetValue(workHoursEmployeeTb.Text);
            }
                xmlDocument.Save(Constant.DATA_PATH_PEOPLE);
                DialogResult = DialogResult.OK;     
        }
    }
}
