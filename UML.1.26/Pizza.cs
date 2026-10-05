using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UML._1._26
{
    public class Pizza
    {

        private string _name;
        private int _no;
        private string _description;
        private double _price;


        public Pizza(int no, string name, string description, double price)
        {
            _no = no;
            _name = name;
            _description = description;
            _price = price;
        }
        public int Number
        {
            get { return _no; }
            set { _no = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return $"{Number} - {Name} : {Description} ..... {Price}kr";
        }


    }
}
