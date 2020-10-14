using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cashier_Machine
{
    public class Items
    {
        public Items(string id, int quantity, double price, string name, string category)
        {
            this.id = id;
            this.quantity = quantity;
            this.price = price;
            this.name = name;
            this.category = category;
        }

        private string id;
        public string Id
        {
            get{
               return id;
                }
            set 
                {
                id = value;
                }

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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Labels
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        #endregion
   
        private void button2_Click(object sender, EventArgs e) // Search button
        {
            StreamReader sr = new StreamReader(File.OpenRead(@"C:\Users\wadef\Desktop\Semester Five\AppDev\AFP_Team2\Cashier_Machine\Cashier_Machine\Storage.txt"));
            
            while(!sr.EndOfStream)
            {
                String [] delimited;
                String sitem = sr.ReadLine();
                delimited = sitem.Split('#');
                int quantity = (int)delimited[2];
                double price = Double.TryParse(delimited[3], price);
                Items item = new Items(delimited[0], quantity, price, delimited[1], delimited[4] );
                textBox1.Text(item.Id + item.Name, + item.Price + item.Quantity);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Add to cart button
        {

        }
    }
}
