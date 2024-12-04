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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTick));
            this.lblTickReq = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTicName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.prgType = new System.Windows.Forms.ComboBox();
            this.lblProgType = new System.Windows.Forms.Label();
            this.lblProgName = new System.Windows.Forms.Label();
            this.prgName = new System.Windows.Forms.ComboBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.helpType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTickReq
            // 
            this.lblTickReq.AutoSize = true;
            this.lblTickReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTickReq.Location = new System.Drawing.Point(448, 33);
            this.lblTickReq.Name = "lblTickReq";
            this.lblTickReq.Size = new System.Drawing.Size(301, 37);
            this.lblTickReq.TabIndex = 0;
            this.lblTickReq.Text = "New Ticket Request";
            this.lblTickReq.Click += new System.EventHandler(this.lblInx_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(515, 467);
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
            this.btnGoBack.Location = new System.Drawing.Point(79, 35);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(180, 40);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(485, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 26);
            this.textBox1.TabIndex = 4;
            // 
            // lblTicName
            // 
            this.lblTicName.AutoSize = true;
            this.lblTicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicName.Location = new System.Drawing.Point(480, 140);
            this.lblTicName.Name = "lblTicName";
            this.lblTicName.Size = new System.Drawing.Size(132, 25);
            this.lblTicName.TabIndex = 5;
            this.lblTicName.Text = "Ticket Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(485, 275);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(480, 234);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(120, 25);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Description";
            // 
            // prgType
            // 
            this.prgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prgType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prgType.FormattingEnabled = true;
            this.prgType.Location = new System.Drawing.Point(805, 211);
            this.prgType.Name = "prgType";
            this.prgType.Size = new System.Drawing.Size(180, 28);
            this.prgType.TabIndex = 8;
            // 
            // lblProgType
            // 
            this.lblProgType.AutoSize = true;
            this.lblProgType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgType.Location = new System.Drawing.Point(800, 176);
            this.lblProgType.Name = "lblProgType";
            this.lblProgType.Size = new System.Drawing.Size(147, 25);
            this.lblProgType.TabIndex = 9;
            this.lblProgType.Text = "Program Type";
            // 
            // lblProgName
            // 
            this.lblProgName.AutoSize = true;
            this.lblProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgName.Location = new System.Drawing.Point(800, 270);
            this.lblProgName.Name = "lblProgName";
            this.lblProgName.Size = new System.Drawing.Size(155, 25);
            this.lblProgName.TabIndex = 11;
            this.lblProgName.Text = "Program Name";
            // 
            // prgName
            // 
            this.prgName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prgName.FormattingEnabled = true;
            this.prgName.Location = new System.Drawing.Point(805, 305);
            this.prgName.Name = "prgName";
            this.prgName.Size = new System.Drawing.Size(180, 28);
            this.prgName.TabIndex = 10;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(183, 196);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(170, 25);
            this.lblHelp.TabIndex = 13;
            this.lblHelp.Text = "Type of Request";
            // 
            // helpType
            // 
            this.helpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.helpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpType.FormattingEnabled = true;
            this.helpType.Location = new System.Drawing.Point(188, 231);
            this.helpType.Name = "helpType";
            this.helpType.Size = new System.Drawing.Size(180, 28);
            this.helpType.TabIndex = 12;
            // 
            // frmNewTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1184, 563);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.helpType);
            this.Controls.Add(this.lblProgName);
            this.Controls.Add(this.prgName);
            this.Controls.Add(this.lblProgType);
            this.Controls.Add(this.prgType);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTicName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTickReq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewTick";
            this.Text = "View Course Schedule";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTickReq;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTicName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ComboBox prgType;
        private System.Windows.Forms.Label lblProgType;
        private System.Windows.Forms.Label lblProgName;
        private System.Windows.Forms.ComboBox prgName;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.ComboBox helpType;
    }
}