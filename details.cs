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
    public partial class details : Form
    {
        public details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            infra infrastructure = new infra();
            infrastructure.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            food fd = new food();
            fd.Show();
            this.Hide();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gym gy = new gym();
            gy.Show();
            this.Hide();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            security sc = new security();
            sc.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            hospital hs = new hospital();
            hs.Show();
            this.Hide();        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            @event ev = new @event();
            ev.Show();
            this.Hide();
    }
    }
}
