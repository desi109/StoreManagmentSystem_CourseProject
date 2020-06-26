using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManagmentSystem
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////FOR EMPLOYEE////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////

        private void searchEmployeeBtn_Click(object sender, EventArgs e)
        {
            nameEmployeeListB.Items.Clear();

            if (nameForSearchEmployeeTb.Text.Equals(null))
            {
                //search in People.xml and show all employees
                IEnumerable<Person> employees = from employee in XDocument
                                         .Load(Constant.DATA_PATH_PEOPLE)
                                         .Descendants("Person")
                             let employeeId = (string)employee.Element("PersonId")
                             where (employeeId.Contains("e"))
                             select new Employee(
                                 employee.Element("PersonId").Value,
                                 employee.Element("Name").Value,
                                 decimal.Parse(employee.Element("Salary").Value),
                                 int.Parse(employee.Element("WorkHours").Value));

                foreach (Employee employee in employees)
                    nameEmployeeListB.Items.Add(employee.ToStringPerson());
            }
            else
            {
                //search in People.xml for specific name(s) and show the employee(s) 
                var employees = from employee in XDocument
                                         .Load(Constant.DATA_PATH_PEOPLE)
                                         .Descendants("Person")
                             let employeeId = (string)employee.Element("PersonId")
                             let employeeName = (string)employee.Element("Name")
                             where (employeeId.Contains("e") &&
                             (employeeName.ToLower()).Contains(nameForSearchEmployeeTb.Text.ToLower()))
                             select new Employee(
                                    employee.Element("PersonId").Value,
                                    employee.Element("Name").Value,
                                    decimal.Parse(employee.Element("Salary").Value),
                                    int.Parse(employee.Element("WorkHours").Value));

                foreach (var employee in employees)
                    nameEmployeeListB.Items.Add(employee.ToStringPerson());
            }
        }



        private void nameEmployeeListB_DoubleClick(object sender, EventArgs e)
        {
            if (nameEmployeeListB.SelectedItem == null)
            {
                return;
            }

            //double click on employee and get the selected employee
            string[] selected = (nameEmployeeListB.SelectedItem.ToString()
                .Replace("Id: ", "/").Replace(", Name: ", "/").Replace(", Salary: ", "/")
                .Replace(", WorkHours:", "/")).Split('/');

            var employee = new Employee(selected[1], selected[2], decimal.Parse(selected[3]), int.Parse(selected[4]));
            var formEmployee = new FormEmployee();
            formEmployee.Employee = employee;

            if (formEmployee.ShowDialog() == DialogResult.OK)
            {
                searchEmployeeBtn_Click(null, null);
            }
        }



        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (nameEmployeeListB.SelectedItem == null)
            {
                return;
            }

            DialogResult doYouWantToDeleteEmoloyee =
                MessageBox.Show("Do you want to delete the Employee?", "", MessageBoxButtons.OKCancel);

            if (doYouWantToDeleteEmoloyee == DialogResult.Cancel)
            {
                return;
            }
            else if (doYouWantToDeleteEmoloyee == DialogResult.OK)
            {
                //get the selected employee
                string[] selected = (nameEmployeeListB.SelectedItem.ToString()
                    .Replace("Id: ", "/").Replace(", Name: ", "/").Replace(", Salary: ", "/")
                    .Replace(", WorkHours: ", "/")).Split('/');

               var employee = new Employee(selected[1], selected[2], decimal.Parse(selected[3]), int.Parse(selected[4]));

                //remove employee from the nameEmployeeListB
                nameEmployeeListB.Items.Remove(nameEmployeeListB.SelectedItem);
                
                //search for the selected employee in People.xml and delete it
                XDocument xmlDocumentPeople = XDocument.Load(Constant.DATA_PATH_PEOPLE);
                xmlDocumentPeople.Root.Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(employee.Id.ToString()) && 
                    ((string)x.Element("Name")).Equals(employee.Name.ToString()))
                    .Remove();
                xmlDocumentPeople.Save(Constant.DATA_PATH_PEOPLE);


                //add deleted to DeletedPeople.xml
                XDocument xmlDocumentDeletedPeople = XDocument.Load(Constant.DATA_PATH_DELETED_PEOPLE);
                xmlDocumentDeletedPeople.Element("People").Add(
                    new XElement("Person",
                    new XElement("PersonId", employee.Id.ToString()),
                    new XElement("Name", employee.Name.ToString()),
                    new XElement("Salary", employee.Salary),
                    new XElement("WorkHours", employee.WorkHours)
                    ));
                xmlDocumentDeletedPeople.Save(Constant.DATA_PATH_DELETED_PEOPLE);
            }
        }



        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            int idE = int.Parse(
                    string.Join("", (
                    from id in XDocument.Load(Constant.DATA_PATH_IDS)
                    .Element("Ids")
                    .Elements("Id")
                    where (((string)id.Element("Type")).Equals("E"))
                    select id.Element("Value").Value.ToString()).ToList()));

            var formEmployee = new FormEmployee();
            var employee = new Employee(idE.ToString() + "e", "", 0 , 0);
            formEmployee.Employee = employee;

            Constant.IS_EMPLOYEE_NEW = true;
            if (formEmployee.ShowDialog() == DialogResult.OK)
            {
                searchEmployeeBtn_Click(null, null);
                Constant.IS_EMPLOYEE_NEW = false;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////FOR BUYER///////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////

        private void searchBuyerBtn_Click(object sender, EventArgs e)
        { 
            nameBuyerListB.Items.Clear();

            if (nameForSearchBuyerTb.Text.Equals(null))
            {
                //search in People.xml and show all buyers
                var buyers = from buyer in XDocument
                                         .Load(Constant.DATA_PATH_PEOPLE)
                                         .Descendants("Person")
                             let buyerId = (string)buyer.Element("PersonId")
                             where (buyerId.Contains("b"))
                             select new Buyer(
                                 buyer.Element("PersonId").Value,
                                 buyer.Element("Name").Value,
                                 decimal.Parse(buyer.Element("Bill").Value));

                foreach (var buyer in buyers)
                    nameBuyerListB.Items.Add(buyer.ToStringPerson());
            }
            else
            {
                //search in People.xml for specific name(s) and show the buyer(s) 
                IEnumerable<Person> buyers = from buyer in XDocument
                                                .Load(Constant.DATA_PATH_PEOPLE)
                                                .Descendants("Person")
                             let buyerId = (string)buyer.Element("PersonId")
                             let buyerName = (string)buyer.Element("Name")
                             where (buyerId.Contains("b") && 
                             (buyerName.ToLower()).Contains(nameForSearchBuyerTb.Text.ToLower()))
                             select new Buyer(
                                buyer.Element("PersonId").Value,
                                buyer.Element("Name").Value,
                                decimal.Parse(buyer.Element("Bill").Value));

                foreach (Buyer buyer in buyers)
                    nameBuyerListB.Items.Add(buyer.ToStringPerson());
            }
        }


        private void nameBuyerListB_DoubleClick(object sender, EventArgs e)
        {
            if (nameBuyerListB.SelectedItem == null)
            {
                return;
            }

            string[] selected = (nameBuyerListB.SelectedItem.ToString()
                .Replace("Id: ", "/").Replace(", Name:", "/").Replace(", Bill:", "/")).Split('/');

            var buyer = new Buyer(selected[1], selected[2], decimal.Parse(selected[3]));
            var formBuyer = new FormBuyer();
            formBuyer.Buyer = buyer;
            formBuyer.purchasedProductsBuyerListB_Update();

            if (formBuyer.ShowDialog() == DialogResult.OK)
            {
                //update nameBuyerListB
                searchBuyerBtn_Click(null, null);
            }
        }



        private void deleteBuyerBtn_Click(object sender, EventArgs e)
        {
            if (nameBuyerListB.SelectedItem == null)
            {
                return;
            }

            DialogResult doYouWantToDeleteBuyer =
                MessageBox.Show("Do you want to delete the Buyer?", "", MessageBoxButtons.OKCancel);


            if (doYouWantToDeleteBuyer == DialogResult.Cancel)
            {
                return;
            }
            else if (doYouWantToDeleteBuyer == DialogResult.OK)
            {
                //get the selected buyer
                string[] selected = (nameBuyerListB.SelectedItem.ToString()
                .Replace("Id: ", "/").Replace(", Name: ", "/").Replace(", Bill: ", "/")).Split('/');

                var buyer = new Buyer(selected[1], (selected[2]), decimal.Parse(selected[3]));

                //remove buyer from the nameBuyerListB
                nameBuyerListB.Items.Remove(nameBuyerListB.SelectedItem);

                //search for the selected buyer in People.xml and delete it
                XDocument xmlDocumentPeople = XDocument.Load(Constant.DATA_PATH_PEOPLE);
                xmlDocumentPeople.Root.Elements("Person")
                    .Where(x => ((string)x.Element("PersonId")).Equals(buyer.Id.ToString()) &&
                    ((string)x.Element("Name")).Equals(buyer.Name.ToString()))
                    .Remove();
                xmlDocumentPeople.Save(Constant.DATA_PATH_PEOPLE);


                //add deleted to DeletedPeople.xml
                XDocument xmlDocumentDeletedPeople = XDocument.Load(Constant.DATA_PATH_DELETED_PEOPLE);
                xmlDocumentDeletedPeople.Element("People").Add(
                    new XElement("Person",
                    new XElement("PersonId", buyer.Id.ToString()),
                    new XElement("Name", buyer.Name.ToString()),
                    new XElement("Bill", buyer.Bill)
                    ));
                xmlDocumentDeletedPeople.Save(Constant.DATA_PATH_DELETED_PEOPLE);

                //////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////
                
                var itemsToRemove = from item in XDocument
                                                .Load(Constant.DATA_PATH_ITEMS)
                                                .Descendants("Item")
                             where (((string)item.Element("PersonId")).Equals(selected[1].Replace("b", "")))
                             select new Item(
                                (string)item.Element("PersonId").Value,
                                int.Parse(item.Element("ProductId").Value),
                                int.Parse(item.Element("Amount").Value));
 
                foreach (var item in itemsToRemove)
                {
                    string[] selectedItem = (item.ToString().Replace(", ", "/").Replace(", ", "/")).Split('/');

                    XDocument xmlDocumentDeletedItems = XDocument.Load(Constant.DATA_PATH_DELETED_ITEMS);
                    xmlDocumentDeletedItems.Element("Items").Add(
                    new XElement("Item",
                    new XElement("PersonId", selected[1].Replace("b","")),
                    new XElement("ProductId", int.Parse(selectedItem[1])),
                    new XElement("Amount", int.Parse(selectedItem[2]))
                    ));
                    xmlDocumentDeletedItems.Save(Constant.DATA_PATH_DELETED_ITEMS);

                    XDocument xmlDocumentItems = XDocument.Load(Constant.DATA_PATH_ITEMS);
                    xmlDocumentItems.Root.Elements("Item")
                    .Where(x => ((string)x.Element("PersonId")).Equals(selected[1].Replace("b", "")) &&
                    ((string)x.Element("ProductId")).Equals(selectedItem[1]))
                    .Remove();
                    xmlDocumentItems.Save(Constant.DATA_PATH_ITEMS);
                }

            }
        }



        private void addBuyerBtn_Click(object sender, EventArgs e)
        {
            int idB = int.Parse(
                    string.Join("", (
                    from id in XDocument.Load(Constant.DATA_PATH_IDS)
                    .Element("Ids")
                    .Elements("Id")
                    where (((string)id.Element("Type")).Equals("B"))
                    select id.Element("Value").Value.ToString()).ToList()));

            var formBuyer = new FormBuyer();
            var buyer = new Buyer(idB.ToString() + "b", "", 0);
            formBuyer.Buyer = buyer;

            Constant.IS_BUYER_NEW = true;
            if (formBuyer.ShowDialog() == DialogResult.OK)
            {
                searchBuyerBtn_Click(null, null);
                Constant.IS_BUYER_NEW = false;
            }
        }

    }
}
