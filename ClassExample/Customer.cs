using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    class Customer
    {
        public int id;
        public string name;

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name)
            :this(id) //call the Customer constructor with only id paramater
        {
            this.name = name;
        }
    }
}
