using System;
using System.Collections.Generic;
using System.Text;

namespace UML._1._26
{
    public class Order
    {

        public Customer Customer { get; }

        public Pizza Pizza { get; }
        private int _tableNo;

        private string _orderDate;

        public Order(Customer customer, Pizza pizza, string orderDate, int tableNo, bool deliver)
        {
            Customer = customer;
            Pizza = pizza;
            _tableNo = tableNo;
            Deliver = deliver;
            _orderDate = orderDate;
        }

        public bool Deliver
        {
            get;
            set;
        }
  
        public int TableNo
        {
            get { return _tableNo; }
            set { _tableNo = value; }
        }

        public string OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        public double CalculateTotalPrice()
        {
            if (Deliver == true)
            {
                return (Pizza.Price * 1.25) + 40;
            }
            return (Pizza.Price * 1.25);
        }

        public override string ToString()
        {
            Console.WriteLine("------------------------------ Order Recipt ------------------------------------");
            Console.WriteLine($"Customer name: {Customer.Name}");
            Console.WriteLine($"Customers address: {Customer.Address}");
            Console.WriteLine($"Customer tlf: {Customer.Tlf}");
            Console.WriteLine();
            Console.WriteLine($"Table {Customer.Table}");
            Console.WriteLine();
            Console.WriteLine($"{Pizza.Number} {Pizza.Name} - {Pizza.Description} * * * {Pizza.Price}kr");
            Console.WriteLine();
            Console.WriteLine($"Total pirce with moms (+ 40kr delivery): {CalculateTotalPrice()}");
            Console.WriteLine();
            Console.WriteLine($"Date: {OrderDate}");
            Console.WriteLine("-------------------------------------------------------------------------------");
            string emptyText = "";

            return $"Customer name: {Customer.Name}, Customer address: {Customer.Address}, Customer tlf {Customer.Tlf}, Pizza number: {Pizza.Number}, Pizza name {Pizza.Name}, Table: {TableNo}, Total price: {CalculateTotalPrice()}kr, Order Date: {OrderDate}";
        }
    }
}
