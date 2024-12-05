using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prjEnrollifyCS
{
    public partial class frmNewTick : BaseForm
    {

       
        public frmNewTick()
        {
            InitializeComponent();

            MessageBox.Show(EmployeeData.employees[2].firstName + " name" );

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


        //hides the text box whether the type is relevant
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
            requestTicket();
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
            MessageBox.Show(EmployeeData.listIndex.ToString());

        }

        private void requestTicket()
        {
            string query = "INSERT INTO Ticket (TicketName, CreationDate, FirstName, LastName, Status, Type, Description, UserID) " +
                           "VALUES (@tick, @creadate, @fn, @ln, @stat, @type, @desc, @userid)";

            // Connect to the database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=prismDatabase.accdb";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    string createDate = DateTime.Now.ToString("MM/dd/yyyy");

                    // Add parameters and display their values
                    cmd.Parameters.AddWithValue("@tick", ticketName.Text);
                    cmd.Parameters.AddWithValue("@creadate", createDate);
                    cmd.Parameters.AddWithValue("@fn", EmployeeData.employees[10].firstName);
                    cmd.Parameters.AddWithValue("@ln", EmployeeData.employees[EmployeeData.listIndex - 1].lastName);
                    cmd.Parameters.AddWithValue("@stat", "Open");
                    cmd.Parameters.AddWithValue("@type", helpType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@desc", ticketDesc.Text);
                    cmd.Parameters.AddWithValue("@userid", EmployeeData.employees[EmployeeData.listIndex - 1].userID);

                    // Display parameter values for debugging
                    MessageBox.Show($"TicketName: {ticketName.Text}\nCreationDate: {createDate}\nFirstName: {EmployeeData.employees[10].firstName}\nLastName: {EmployeeData.employees[EmployeeData.listIndex - 1].lastName}\nStatus: Open\nType: {helpType.SelectedItem.ToString()}\nDescription: {ticketDesc.Text}\nUserID: {EmployeeData.employees[EmployeeData.listIndex - 1].userID}");

                    try
                    {
                        con.Open();
                        MessageBox.Show("Connection opened successfully.");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted.");

                        con.Close();
                        MessageBox.Show("Connection closed.");

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ticket added successfully.");
                            
                        }
                        else
                        {
                            MessageBox.Show("No rows inserted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }



        private void clearTextSelection()
        {
            helpType.SelectedItem = null;
            prgType.SelectedItem = null;
            prgName.SelectedItem = null;    
            ticketName.Clear();
            ticketDesc.Clear();
        }
    }
}
