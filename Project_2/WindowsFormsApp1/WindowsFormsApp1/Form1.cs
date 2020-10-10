using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Akoch\Documents\Table.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "Select * from Login Where UserName ='" + textBox1.Text.Trim() + "' and PassWord ='" + textBox2.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Home h = new Home();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("please check your username and password");
                }
            
         
        
        }
    }
}
