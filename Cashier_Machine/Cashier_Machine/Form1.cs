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
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            //richTextBox1.Text = "        Till Slip" + "\n";
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
            if(textBox1.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please enter an id");
            }else 
            {
                String [] Storage = File.ReadAllLines(@"C:\Users\wadef\Desktop\Semester Five\AppDev\AFP_Team2\Cashier_Machine\Cashier_Machine\Storage.txt");
            
                for (int i = 0; i < Storage.Length; i++)
			    {
                   StringBuilder b = new StringBuilder(Storage[i]);
                   string a = b.ToString();
                   string [] entry = a.Split(new char [] {'#'});

                   if (entry[0] == textBox1.Text)
	               {
                        label7.Text = entry[3];
                        label6.Text = entry[1];
                        label8.Text = entry[2];
                        label9.Text = entry[4];
                       
	               } 
                }   
            }
        }

        private void button1_Click(object sender, EventArgs e) // Add to cart button
        {

            if(textBox1.Text.Equals(String.Empty))
            { 
                MessageBox.Show("Please select an item first");
            }else 
            {
                richTextBox1.Text += label6.Text + "     " + label8.Text + "HUF" + " \n";
            } 
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
