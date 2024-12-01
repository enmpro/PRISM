namespace prjEnrollifyCS
{
    partial class frmRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequest));
            this.lblInx = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInx
            // 
            this.lblInx.AutoSize = true;
            this.lblInx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInx.ForeColor = System.Drawing.Color.White;
            this.lblInx.Location = new System.Drawing.Point(275, 38);
            this.lblInx.Name = "lblInx";
            this.lblInx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInx.Size = new System.Drawing.Size(240, 33);
            this.lblInx.TabIndex = 0;
            this.lblInx.Text = "Request Courses";
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(241, 346);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(136, 38);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(430, 346);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(136, 38);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // lstCourses
            // 
            this.lstCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 24;
            this.lstCourses.Items.AddRange(new object[] {
            "Course 1",
            "Course 2",
            "Course 3"});
            this.lstCourses.Location = new System.Drawing.Point(135, 93);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(564, 220);
            this.lstCourses.TabIndex = 3;
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblInx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRequest";
            this.Text = "Request a Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInx;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ListBox lstCourses;
    }
}