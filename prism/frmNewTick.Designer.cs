namespace prjEnrollifyCS
{
    partial class frmNewTick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTick));
            this.lblTickReq = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.enrollifyScheduleDataSet = new prjEnrollifyCS.EnrollifyScheduleDataSet();
            this.enrollifyScheduleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollifyScheduleDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTickReq
            // 
            this.lblTickReq.AutoSize = true;
            this.lblTickReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTickReq.Location = new System.Drawing.Point(488, 43);
            this.lblTickReq.Name = "lblTickReq";
            this.lblTickReq.Size = new System.Drawing.Size(179, 24);
            this.lblTickReq.TabIndex = 0;
            this.lblTickReq.Text = "New Ticket Request";
            this.lblTickReq.Click += new System.EventHandler(this.lblInx_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(492, 374);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 40);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(48, 35);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(180, 40);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnMain_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // frmNewTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1184, 563);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTickReq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewTick";
            this.Text = "View Course Schedule";
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollifyScheduleDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTickReq;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.BindingSource enrollifyScheduleDataSetBindingSource;
        private EnrollifyScheduleDataSet enrollifyScheduleDataSet;
        private System.Windows.Forms.BindingSource enrollifyScheduleDataSetBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
    }
}