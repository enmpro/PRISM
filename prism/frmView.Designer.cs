namespace prjEnrollifyCS
{
    partial class frmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView));
            this.lblInx = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblLIS = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.enrollifyScheduleDataSet = new prjEnrollifyCS.EnrollifyScheduleDataSet();
            this.enrollifyScheduleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollifyScheduleDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInx
            // 
            this.lblInx.AutoSize = true;
            this.lblInx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInx.Location = new System.Drawing.Point(281, 53);
            this.lblInx.Name = "lblInx";
            this.lblInx.Size = new System.Drawing.Size(204, 24);
            this.lblInx.TabIndex = 0;
            this.lblInx.Text = "View Course Schedule";
            this.lblInx.Click += new System.EventHandler(this.lblInx_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(165, 381);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(180, 40);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request a Course";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(430, 381);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(180, 40);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblLIS
            // 
            this.lblLIS.AutoSize = true;
            this.lblLIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLIS.ForeColor = System.Drawing.Color.White;
            this.lblLIS.Location = new System.Drawing.Point(322, 19);
            this.lblLIS.Name = "lblLIS";
            this.lblLIS.Size = new System.Drawing.Size(128, 24);
            this.lblLIS.TabIndex = 4;
            this.lblLIS.Text = "Welcome, LIU";
            this.lblLIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(59, 103);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(697, 238);
            this.lstCourses.TabIndex = 5;
            // 
            // enrollifyScheduleDataSet
            // 
            this.enrollifyScheduleDataSet.DataSetName = "EnrollifyScheduleDataSet";
            this.enrollifyScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollifyScheduleDataSetBindingSource
            // 
            this.enrollifyScheduleDataSetBindingSource.DataSource = this.enrollifyScheduleDataSet;
            this.enrollifyScheduleDataSetBindingSource.Position = 0;
            // 
            // enrollifyScheduleDataSetBindingSource1
            // 
            this.enrollifyScheduleDataSetBindingSource1.DataSource = this.enrollifyScheduleDataSet;
            this.enrollifyScheduleDataSetBindingSource1.Position = 0;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lblLIS);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblInx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmView";
            this.Text = "View Course Schedule";
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInx;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblLIS;
        private System.Windows.Forms.BindingSource enrollifyScheduleDataSetBindingSource;
        private EnrollifyScheduleDataSet enrollifyScheduleDataSet;
        public System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.BindingSource enrollifyScheduleDataSetBindingSource1;
    }
}