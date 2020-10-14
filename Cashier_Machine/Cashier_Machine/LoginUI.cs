using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Machine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string user, pass;
                user = "root";
                pass = "password";

                if ((textUsername.Text == user) && (textPassword.Text == pass))
                {
                    MessageBox.Show("Welcome User");
                    this.Hide();

                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {


                    MessageBox.Show("Wrong user name or password");



                }

            }
        }
    }
}
