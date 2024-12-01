using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEnrollifyCS
{
    public partial class frmView : Form
    {

        List<Ticket> coursesOffered = new List<Ticket>();
       
        public frmView()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
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
            //Update label
           // lblLIS.Text = "Welcome, " + frmLogin.lisname;
            //Connect to the database
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Enrollify.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            // use to fetch rows from demo table
            cmd.CommandText = "Select * from Schedule";


            // to execute the sql statement
            cmd.ExecuteNonQuery();
            // use to read each row in table
            OleDbDataReader datareader = cmd.ExecuteReader();


            int sindex = 0;
            string r, c ="", t, o, md, mt, off = "No";
            short rn = 0, cc = 0;
            const string TAB = "\t";
            const string TAB2 = "\t\t";
            const string TAB3 = "\t\t\t";
            const string TAB4 = "\t\t\t\t";
            string spaces = "";//determine size of course title

        
            // load the list box title

            lstCourses.Items.Add("Course #" + TAB2 + "Title" +  TAB4 + "Days" + TAB2 + "Times" + TAB2 + "Offered"+ "\n");

            while (datareader.Read())
            {
                r = datareader["regNum"].ToString(); // convert to string
                c = datareader["courseCode"].ToString();
                t = datareader["courseTitle"].ToString();
                o = datareader["offered"].ToString();
                md = datareader["meetingday"].ToString();
                mt = datareader["meetingtime"].ToString();                
                
                //convert strings to numbers
                rn = Int16.Parse(r); //convert to short
                cc = Int16.Parse(r); //convert to short
                if (o == "True")
                    off = "Yes";
                else
                    off = "No";

                //Add to the list box (view only)
                    int numspaces = 30 - t.Length;
                    for (int s = 1; s < numspaces; s++)
                    { spaces += " "; }

                if (off == "No") //not offered
                {
                    lstCourses.Items.Add(c + TAB2 + t + spaces + TAB3+ TAB3 + off +"\n");
                }
                else
                {

                    lstCourses.Items.Add(c + TAB2 + t + spaces + TAB2 + md + TAB + mt + TAB + off + "\n");
                }
                spaces = ""; //reset spaces
                sindex++;
            }

            //MessageBox.Show("Schedule data loaded", "Data Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

  

        }
    }
}
