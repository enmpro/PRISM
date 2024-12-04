using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace prjEnrollifyCS
{
    public partial class frmNewTick : BaseForm
    {

        List<Ticket> coursesOffered = new List<Ticket>();
       
        public frmNewTick()
        {
            InitializeComponent();

            helpType.Items.AddRange(new string[] { "General", "Networking", "Program" });
            helpType.SelectedIndexChanged += new EventHandler(helpTypeSelectedItem);

            lblProgName.Visible = false;
            lblProgType.Visible = false;
            prgType.Visible = false;
            prgName.Visible = false;

            prgType.Items.AddRange(new string[] { "Documentation", "Creation", 
                "Web Development", "3D Development", "Communication" });

            prgName.Items.AddRange(new string[] { "Microsoft Word", "Microsoft Access",
                 "Microsoft Excel", "Adobe Photoshop", "Adobe Premiere",
                 "Adobe Dreamweaver", "Blender", "Zoom", "Oracle NetBeans",
                 "FL Studio" });
        }



        private void helpTypeSelectedItem(object sender, EventArgs e)
        {
            if (helpType.SelectedItem.ToString() == "General")
            {
                lblProgName.Visible = false;
                lblProgType.Visible = false;
                prgType.Visible = false;
                prgName.Visible = false;
            }
            if (helpType.SelectedItem.ToString() == "Networking")
            {
                lblProgName.Visible = false;
                lblProgType.Visible = false;
                prgType.Visible = false;
                prgName.Visible = false;
            }
            if (helpType.SelectedItem.ToString() == "Program")
            {
                lblProgName.Visible = true;
                lblProgType.Visible = true;
                prgType.Visible = true;
                prgName.Visible = true;
            }
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
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=prismDatabase.accdb");
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
