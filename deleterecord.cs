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
    public partial class deleterecord : Form
    {
        function fn = new function();
        public string query;
        public deleterecord()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String registration = TextBox1.Text;
            
            MessageBox.Show("Are you sure you want to delete the record","Delete the record ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            query = "select roomno from newstudents where registrationno ='"+registration+"'";
            DataSet ds = fn.getData(query);
            Int64 roomno = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            query = "select roomsleft from rooms where roomno = "+roomno+"";
            DataSet ds1 = fn.getData(query);
            Int64 bedleft = Int64.Parse(ds1.Tables[0].Rows[0][0].ToString());
           ++bedleft;
            
            query = "update rooms set roomsleft="+bedleft+" where roomno ="+roomno+"";
            fn.setData(query, "Updating Database");
            if (bedleft != 0)
            {
                query = "update rooms set roomstatus= 'Y' where roomno ="+roomno+"";
            }
           query ="DELETE FROM newstudents WHERE registrationno ='"+registration+"'";
           fn.setData(query, "Student Record Deleted  SUccessfull");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
