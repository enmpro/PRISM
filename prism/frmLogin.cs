using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace prjEnrollifyCS
{
    public partial class frmLogin : BaseForm
    {
        List<Employee> employees = new List<Employee>();
        string lisname = "";
        short user_id = 0;
        public frmLogin()
        {
            InitializeComponent();

        }

        public void frmLogin_Load(object sender, EventArgs e)
        {
            //Connect to the database
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Enrollify.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            // use to fetch rows from demo table
            cmd.CommandText = "Select * from Employee";
            

            // to execute the sql statement
            cmd.ExecuteNonQuery();
            // use to read each row in table
            OleDbDataReader datareader = cmd.ExecuteReader();


            int employee_index = 0;
            string uid, un, pw, dp, fn, ln;
            short uid2 = 0;
            // for one by one reading row
            while (datareader.Read())
            {
                uid = datareader["UserID"].ToString(); // convert to string
                un = datareader["Username"].ToString();
                pw = datareader["Password"].ToString();
                dp = datareader["Department"].ToString(); 
                fn = datareader["FirstName"].ToString();
                ln = datareader["LastName"].ToString();

                //convert strings to numbers
                uid2 = Int16.Parse(uid); //convert to short
                //Add to the vector
                Employee emplyrec = new Employee(uid2, un, pw, dp, fn, ln);
                employees.Add(emplyrec);
                employee_index++;
            }

           // MessageBox.Show("Student file data loaded", "Data Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            con.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string entUser = "", entPass = "";
            bool loginOK = false;

            entUser = txtUser.Text;
            entPass = txtPass.Text;

            for (int u = 0; u < employees.Count; u++)
            {

                if (entUser == employees[u].username && entPass == employees[u].password)
                { 
                    loginOK = true;
                    lisname = employees[u].username;
                    user_id = employees[u].userID;
                  //  MessageBox.Show("Login Successful, " + lisname, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txtUser.Text = "";
            txtPass.Text = "";

            if (loginOK)
            {
                //open Display Menu
                //pass student vector & index of logged in user

                frmDisplayMenu d = new frmDisplayMenu();
                d.UserID = user_id;
                d.lblLIS.Text = "Welcome to PRISM, " + lisname;
                d.lblLIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                d.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Login UnSuccessful", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
