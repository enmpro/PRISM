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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjEnrollifyCS
{
    public partial class frmDisplayMenu : BaseForm
    {
        public int userID { get; set; }
        List<Ticket> ticketList = new List<Ticket>();  
        public frmDisplayMenu()
        {
            InitializeComponent();
            
          // lblLIS.Text = "Welcome " + frmLogin.lis;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        { frmNewTick v = new frmNewTick();
            frmRequest r = new frmRequest();
            if (newTick.Checked)
            {    v.Show();  }
            else
            {   r.Show(); }
            this.Hide();
        }

        private void frmDisplayMenu_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=prismDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            // use to fetch rows from demo table
            cmd.CommandText = "Select * from Ticket Where UserID = ?";
            cmd.Parameters.AddWithValue("?", userID);

            // to execute the sql statement
            cmd.ExecuteNonQuery();
            // use to read each row in table
            OleDbDataReader datareader = cmd.ExecuteReader();

            int ticket_index = 0;
            string tickid, credate, ticket_name, stat, desc, emplid;
            short empl_id, ticket_id = 0;
            DateTime create_date = DateTime.Now;
            
            listTicket.View = View.Details;
            listTicket.Columns.Add("Ticket #");
            listTicket.Columns.Add("Ticket Name", 150);
            listTicket.Columns.Add("Date", 150);
            listTicket.Columns.Add("Status", 150);
            listTicket.Columns.Add("Description", 250);
            while (datareader.Read())
            {
                tickid = datareader["TicketID"].ToString();
                credate = datareader["CreationDate"].ToString();
                ticket_name = datareader["TicketName"].ToString();
                stat = datareader["Status"].ToString();
                desc = datareader["Description"].ToString();
                emplid = datareader["UserID"].ToString();

                ticket_id = Int16.Parse(tickid);
                empl_id = Int16.Parse(emplid);
                create_date = DateTime.Parse(credate);
                //Ticket ticketRec = new Ticket(ticket_id, create_date, fn, ln, stat, desc, empl_id);
                //ticketList.Add(ticketRec);
                listTicket.Items.Add(new ListViewItem(new string[] { tickid, ticket_name, credate, stat, desc }));
                listTicket.GridLines = true;

                ticket_index++;
            }
            con.Close();
        }
    }
}
