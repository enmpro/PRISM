namespace prjEnrollifyCS
{
    partial class frmDisplayMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnSubmit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplayMenu));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.optRequest = new System.Windows.Forms.RadioButton();
            this.optView = new System.Windows.Forms.RadioButton();
            this.lblLIS = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listTickets = new System.Windows.Forms.ListBox();
            btnSubmit = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSubmit.ForeColor = System.Drawing.Color.Black;
            btnSubmit.Location = new System.Drawing.Point(516, 322);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(114, 35);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(274, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(245, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Employee Menu";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.optRequest);
            this.grpOptions.Controls.Add(this.optView);
            this.grpOptions.Location = new System.Drawing.Point(469, 191);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(225, 119);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // optRequest
            // 
            this.optRequest.AutoSize = true;
            this.optRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRequest.Location = new System.Drawing.Point(23, 69);
            this.optRequest.Name = "optRequest";
            this.optRequest.Size = new System.Drawing.Size(179, 28);
            this.optRequest.TabIndex = 1;
            this.optRequest.TabStop = true;
            this.optRequest.Text = "Request a Course";
            this.optRequest.UseVisualStyleBackColor = true;
            // 
            // optView
            // 
            this.optView.AutoSize = true;
            this.optView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optView.Location = new System.Drawing.Point(23, 19);
            this.optView.Name = "optView";
            this.optView.Size = new System.Drawing.Size(156, 28);
            this.optView.TabIndex = 0;
            this.optView.TabStop = true;
            this.optView.Text = "View Schedule";
            this.optView.UseVisualStyleBackColor = true;
            // 
            // lblLIS
            // 
            this.lblLIS.AutoSize = true;
            this.lblLIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLIS.ForeColor = System.Drawing.Color.White;
            this.lblLIS.Location = new System.Drawing.Point(281, 71);
            this.lblLIS.Name = "lblLIS";
            this.lblLIS.Size = new System.Drawing.Size(233, 26);
            this.lblLIS.TabIndex = 3;
            this.lblLIS.Text = "Welcome to PRISM, LIU";
            this.lblLIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(97)))));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 108);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(807, 353);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // listTickets
            // 
            this.listTickets.FormattingEnabled = true;
            this.listTickets.Location = new System.Drawing.Point(34, 171);
            this.listTickets.Name = "listTickets";
            this.listTickets.Size = new System.Drawing.Size(361, 186);
            this.listTickets.TabIndex = 7;
            // 
            // frmDisplayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTickets);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(this.lblLIS);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDisplayMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrolliify Display Menu";
            this.Load += new System.EventHandler(this.frmDisplayMenu_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton optRequest;
        private System.Windows.Forms.RadioButton optView;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label lblLIS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listTickets;
    }
}