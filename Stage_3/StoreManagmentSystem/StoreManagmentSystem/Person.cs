using System;

namespace StoreManagmentSystem
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
        }

        protected Person(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public virtual string ToStringPerson()
        {
            return string.Format("{0}, {1}", Id, Name);
        }
    }
}
