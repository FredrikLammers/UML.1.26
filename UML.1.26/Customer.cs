using System;
using System.Collections.Generic;
using System.Text;

namespace UML._1._26
{
    public class Customer
    {

        private string _name;
        private int _tlf;
        private string _address;
        private int _table; // Table 0 mean that the Pizza is to go or delivered

        public Customer(string name,int tlf, string address, int table)
        {
            _name = name;
            _tlf = tlf;
            _address = address;
            _table = table;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Table
        {
            get { return _table; }
            set { _table = value; }
        }


        public override string ToString()
        {
            return $"Name: {Name}, Tlf: {Tlf}, Address: {Address}, Table: {Table}";
        }


    }
}
