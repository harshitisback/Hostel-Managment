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
    public partial class Dashboard : Form
    {
        private bool _dragging = false;

        private Point _start_point;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            information info = new information();
            info.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(labelVisible == true)
            {
                hmsLabel.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 ns = new Form2();
            ns.Show();
            this.Location = new Point(350, 170);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            details d = new details();
            d.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(150, 170);
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            deleterecord dl = new deleterecord();
            dl.Show();

        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            //enable draging and get mouse position
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point P = PointToScreen(e.Location);
                Location = new Point(P.X - this._start_point.X, P.Y - this._start_point.Y);
            }
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            //disable dragging
            _dragging = false;
        }
    }
}
