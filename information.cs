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
    public partial class information : Form
    {
        function fn = new function();
        String query;
        public information()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void information_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {  string register = txtregister.Text;
        query = "select * from newstudents where registrationno = ' " + register + "'";
            DataSet ds = fn.getData(query);
        guna2DataGridView2.DataSource = ds.Tables[0];

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string register = txtregister.Text;
            query = "select * from newstudents where registrationno = '"+register +"'";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        /* string register = txtregister.Text;
query = "select * from newstudents where registrationno = ' " + register + "'";
    DataSet ds = fn.getData(query);
guna2DataGridView2.DataSource = ds.Tables[0];*/
    }
}
