using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prjEnrollifyCS
{
    public partial class frmNewTick : Form
    {

        List<Ticket> coursesOffered = new List<Ticket>();
       
        public frmNewTick()
        {
            InitializeComponent();
        }
       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmRequest r = new frmRequest();
           r.ShowDialog();
            this.Hide();
        }
        
        private void lblInx_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
          frmDisplayMenu m = new frmDisplayMenu();
             m.ShowDialog(); 
            this.Hide();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            //Connect to the database
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Enrollify.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            // use to fetch rows from demo table
            cmd.CommandText = "";

            

            // to execute the sql statement
            //cmd.ExecuteNonQuery();
            // use to read each row in table
            //OleDbDataReader datareader = cmd.ExecuteReader();


            int sindex = 0;
            string r, c ="", t, o, md, mt, off = "No";
            short rn = 0, cc = 0;
        
            // load the list box title

            

            //MessageBox.Show("Schedule data loaded", "Data Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

  

        }
    }
}
