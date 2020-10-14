using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Machine
{
    class Items
    {
        public Items(int quantity, double price, string name, string category)
        {

            this.quantity = quantity;
            this.price = price;
            this.name = name;
            this.category = category;
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        private string category;
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

    }
}
