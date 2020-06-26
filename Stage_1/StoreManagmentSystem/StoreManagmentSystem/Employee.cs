using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem
{
    public class Employee : Person
    {

        public decimal Salary { get; set; }
        public int WorkHours { get; set; }

        public Employee()
        {
        }

        public Employee(string id, string name, decimal salary, int workHours) : base(id, name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.WorkHours = workHours;
        }

        public override string ToStringPerson()
        {
            return string.Format("Id = {0}, Name = {1}, Salary = {2}, Work Hours = {3}\n", Id, Name, Salary, WorkHours);
        }
    }
}
