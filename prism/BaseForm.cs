using System;
using System.Windows.Forms;

public class BaseForm : Form
{
    private bool formClosed = false;

    public BaseForm()
    {
        this.FormClosing += new FormClosingEventHandler(BaseForm_FormClosing);
    }

    private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (formClosed)
        {
            return; 
        }

        DialogResult result = MessageBox.Show(
            "Are you sure you want to close the application?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            formClosed = true; 
            Application.Exit();
        }
        else
        {
            e.Cancel = true; 
        }
    }
}
