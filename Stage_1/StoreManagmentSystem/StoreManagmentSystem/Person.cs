using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
        }

        public Person(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual string ToStringPerson()
        {
            return string.Format("Id = {0}, Name = {1}", Id, Name);
        }
    }
}
