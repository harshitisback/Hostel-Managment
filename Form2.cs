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
    public partial class Form2 : Form
    {
        private bool _dragging = false;
        
        private Point _start_point;
        function fn = new function();
        public string query;
       // public Int64 bed;
       // public int bedleft;
       
        public Form2()
        {
            InitializeComponent();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtmobile.Text);
            Int64 roomno = Int64.Parse(txtroomno.SelectedItem.ToString());
            String sname = txtsname.Text;
            String fname = txtfname.Text;
            String mname = txtmname.Text;
            String registration = txtregister.Text;
            String address = txtaddress.Text;
            String email = txtmail.Text;
            query  = "select roomsleft from rooms where roomno = " + roomno + "";
            DataSet ds = fn.getData(query);
            Int64 bedleft = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
             query = "INSERT INTO newstudents(sname,registrationno,mobileno,fname,mname,adress,email,roomno) values('" + sname + "','" + registration + "'," + mobile + ",'" + fname + "','" + mname + "','" + address + " ','" + email +"'," + roomno + ")";
             fn.setData(query, "Student Reigstration SUccessfull");
            Int64 v = bedleft - 1;
            bedleft = v;
             query = "update rooms set roomsleft=" + bedleft + " where roomno = "+roomno+ "";
             if (bedleft == 0)
             {
                 query = "update rooms set roomstatus= 'N' where roomno = " + roomno + "";
             }
             fn.setData(query, "Student Reigstration SUccessfull");
             //this.Close();*/

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtmobile.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtaddress.Clear();
            txtmail.Clear();
           txtregister.Clear();
            txtsname.Clear();
            txtroomno.SelectedIndex = -1;



        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = checkBox1.Checked;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Once hostel is booked no refund policy is formulated in case of voluntary leaving of hostel", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // bed = Int64.Parse(radioButton1.Text);
            query = "select roomno from rooms where ((roomstatus = 'Y') AND (beded = 6 ))";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                txtroomno.Items.Add(room);
            }


        }//bed = 6;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //int bed;
            // bed = 4;
            query = "select roomno from rooms where ((roomstatus = 'Y') AND (beded = 4))";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                txtroomno.Items.Add(room);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            query = "select roomno from rooms where ((roomstatus = 'Y') AND (beded = 2 ))";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                txtroomno.Items.Add(room);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }
        
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {     //enable draging and get mouse position
            _dragging = true;
            _start_point = new Point(e.X, e.Y);

        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {//check if able to move
            
            

        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {//disable dragging
            _dragging = false;
        }

        private void Form2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point P = PointToScreen(e.Location);
                Location = new Point(P.X - this._start_point.X, P.Y - this._start_point.Y);
            }

        }
    }
}
