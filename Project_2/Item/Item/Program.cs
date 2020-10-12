using System;
using System.Collections.Generic;

namespace Item
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
    class Item
    {
        private int quantity;
        private double price;
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
        public Item(int quantity,double price)
        {
            
            this.quantity = quantity;
            this.price = price;
        }

        //the sold items
        public bool Item_Sold()
        {
            int item_sold = 0;
            if (quantity == quantity - item_sold)
            {
                return true;
            }
          else return false;
        }

    }
    class Cashier // container class,it contains items
    {
        List<Item> items = new List<Item>();

        //method that adds items to the Cashier
        public void Add_item(Item e) 
        { 
            items.Add(e); 
        }

        //method that removes items from the store
        public void Remove()
        {
            for (int i = 0; i <items.Count; i++)
            {
                if (items[i].Item_Sold())
                {
                    items.RemoveAt(i);
                    items[i].Quantity--; 
                }
                
            }
        }
    }
}
