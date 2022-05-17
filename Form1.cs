using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostel_managmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin")
            {
                if (txtpassword.Text == "ASPKH")
                {
                    this.Hide();
                    Dashboard ds = new Dashboard();
                    ds.Show();
                }
                else
                {
                    txtpassword.Clear();
                    txtusername.Clear();
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtpassword.Text == "root")
                {
                    txtpassword.Clear();
                    txtusername.Clear();
                    MessageBox.Show("Incorrect Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtpassword.Clear();
                    txtusername.Clear();
                    MessageBox.Show("Incorrect Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
