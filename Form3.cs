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
    public partial class Form3 : Form
    {
        function fn = new function();
        String query;
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String registration = TextBox4.Text;
            if(checkBox2.Checked)
            {
                Int64 mobno = Int64.Parse(TextBox2.Text);
                query = "update newstudents set mobileno="+mobno+" where registrationno = '"+registration+"'";
                fn.setData(query, "Student mobile number updated  Successfull");

            }
            if (checkBox4.Checked)
            {
                String address = TextBox3.Text;
                query = "update newstudents set adress='" + address + "' where registrationno = '"+registration+"'";
                fn.setData(query, "Student address updated  Successfull");
            }
            if (checkBox3.Checked)
            {
                String mail = TextBox5.Text;
                query = "update newstudents set email='"+mail+"' where registrationno = '"+registration+"'";
                fn.setData(query, "Student Email address updated  Successfull");

            }




        }

        //private long Int64(string v)
        //{
          //  throw new NotImplementedException();
       // }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
