using System;

namespace StoreManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = "1e";
            employee1.Name = "Ivan Ivanov";
            employee1.Salary = 1500;
            employee1.WorkHours = 40;

            Employee employee2 = new Employee("2e", "Bojidar Petrov", 1000, 20);

            Console.WriteLine(employee1.ToStringPerson());
            Console.WriteLine(employee2.ToStringPerson());

        ///////////////////////////////////////////////////////////////////////////////////////

            Buyer buyer1 = new Buyer();
            buyer1.Id = "1b";
            buyer1.Name = "Marina Marinova";
            buyer1.Bill = 0;

            Buyer buyer2 = new Buyer("2b", "Georgi Georgiev", 0);

            Console.WriteLine(buyer1.ToStringPerson());
            Console.WriteLine(buyer2.ToStringPerson());

            ///////////////////////////////////////////////////////////////////////////////////////

            Product product1 = new Product();
            product1.Id = 1;
            product1.Type = "Phone";
            product1.Model = "SONY Xperia";
            product1.Price = 400;

            Product product2 = new Product(2, "TV", "Samsung LED", 850);

            Console.WriteLine(product1.ToStringProduct());
            Console.WriteLine(product2.ToStringProduct());

            ///////////////////////////////////////////////////////////////////////////////////////

            buyer1.Bill = buyer1.getNewProduct(product1.Price);
            buyer2.Bill = buyer2.getNewProduct(product2.Price);

            ///////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(buyer1.ToStringPerson());
            Console.WriteLine(buyer2.ToStringPerson());

            Console.ReadKey();
        }
    }
}
