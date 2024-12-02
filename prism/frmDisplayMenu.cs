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
    public partial class frmDisplayMenu : BaseForm
    {
        public int UserID { get; set; }
        List<Ticket> ticketList = new List<Ticket>();  
        public frmDisplayMenu()
        {
            InitializeComponent();
            
          // lblLIS.Text = "Welcome " + frmLogin.lis;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        { frmView v = new frmView();
            frmRequest r = new frmRequest();
            if (optView.Checked)
            {    v.Show();  }
            else
            {   r.Show(); }
            this.Hide();
        }

        private void frmDisplayMenu_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Enrollify.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            // use to fetch rows from demo table
            cmd.CommandText = "Select * from Ticket";


            // to execute the sql statement
            cmd.ExecuteNonQuery();
            // use to read each row in table
            OleDbDataReader datareader = cmd.ExecuteReader();

            int ticket_index = 0;
            string tickid, credate, fn, ln, stat, desc, emplid;
            short empl_id, ticket_id = 0;
            DateTime create_date = DateTime.Now;
            const string TAB = "\t";
            const string TAB2 = "\t";
            const string TAB3 = "\t";
            const string TAB4 = "\t";
            string spaces = "";

            listTickets.Items.Add("Ticket #" + TAB2 + "Ticket Name" + TAB4 + "Date" + TAB2 + "Status" + TAB2 + "Description" + "\n");

            while (datareader.Read())
            {
                tickid = datareader["TicketID"].ToString();
                credate = datareader["CreationDate"].ToString();
                fn = datareader["FirstName"].ToString();
                ln = datareader["LastName"].ToString();
                stat = datareader["Status"].ToString();
                desc = datareader["Description"].ToString();
                emplid = datareader["UserID"].ToString();

                ticket_id = Int16.Parse(tickid);
                empl_id = Int16.Parse(emplid);
                create_date = DateTime.Parse(credate);
                //Ticket ticketRec = new Ticket(ticket_id, create_date, fn, ln, stat, desc, empl_id);
                //ticketList.Add(ticketRec);

                listTickets.Items.Add(ticket_id + credate + fn + ln + stat + desc);

                ticket_index++;
            }
            con.Close();
        }
    }
}
