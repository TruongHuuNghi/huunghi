namespace asm2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnASC = new System.Windows.Forms.Button();
            this.btnDESC = new System.Windows.Forms.Button();
            this.lbNameofcustomer = new System.Windows.Forms.Label();
            this.lbWarterMeterLastMonth = new System.Windows.Forms.Label();
            this.lbWarterMeterThisMonth = new System.Windows.Forms.Label();
            this.lbSeachofcustomer = new System.Windows.Forms.Label();
            this.lbNumberofpeople = new System.Windows.Forms.Label();
            this.txtNameofcustomer = new System.Windows.Forms.TextBox();
            this.txtWaterMeterLastmonth = new System.Windows.Forms.TextBox();
            this.txtWaterMeterThisMonth = new System.Windows.Forms.TextBox();
            this.txtNumberofpeople = new System.Windows.Forms.TextBox();
            this.txtSeachbyofcustomer = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbTypeofcustomer = new System.Windows.Forms.Label();
            this.btnExportInvoice = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbTypeofcustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(650, 336);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(241, 332);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnASC
            // 
            this.btnASC.Location = new System.Drawing.Point(436, 332);
            this.btnASC.Name = "btnASC";
            this.btnASC.Size = new System.Drawing.Size(75, 23);
            this.btnASC.TabIndex = 1;
            this.btnASC.Text = "ASC";
            this.btnASC.UseVisualStyleBackColor = true;
            // 
            // btnDESC
            // 
            this.btnDESC.Location = new System.Drawing.Point(539, 332);
            this.btnDESC.Name = "btnDESC";
            this.btnDESC.Size = new System.Drawing.Size(75, 23);
            this.btnDESC.TabIndex = 1;
            this.btnDESC.Text = "DESC";
            this.btnDESC.UseVisualStyleBackColor = true;
            // 
            // lbNameofcustomer
            // 
            this.lbNameofcustomer.AutoSize = true;
            this.lbNameofcustomer.Location = new System.Drawing.Point(29, 60);
            this.lbNameofcustomer.Name = "lbNameofcustomer";
            this.lbNameofcustomer.Size = new System.Drawing.Size(116, 16);
            this.lbNameofcustomer.TabIndex = 2;
            this.lbNameofcustomer.Text = "Name of customer";
            // 
            // lbWarterMeterLastMonth
            // 
            this.lbWarterMeterLastMonth.AutoSize = true;
            this.lbWarterMeterLastMonth.Location = new System.Drawing.Point(29, 115);
            this.lbWarterMeterLastMonth.Name = "lbWarterMeterLastMonth";
            this.lbWarterMeterLastMonth.Size = new System.Drawing.Size(151, 16);
            this.lbWarterMeterLastMonth.TabIndex = 2;
            this.lbWarterMeterLastMonth.Text = "Warter Meter Last Month";
            // 
            // lbWarterMeterThisMonth
            // 
            this.lbWarterMeterThisMonth.AutoSize = true;
            this.lbWarterMeterThisMonth.Location = new System.Drawing.Point(29, 163);
            this.lbWarterMeterThisMonth.Name = "lbWarterMeterThisMonth";
            this.lbWarterMeterThisMonth.Size = new System.Drawing.Size(152, 16);
            this.lbWarterMeterThisMonth.TabIndex = 2;
            this.lbWarterMeterThisMonth.Text = "Warter Meter This Month";
            // 
            // lbSeachofcustomer
            // 
            this.lbSeachofcustomer.AutoSize = true;
            this.lbSeachofcustomer.Location = new System.Drawing.Point(238, 64);
            this.lbSeachofcustomer.Name = "lbSeachofcustomer";
            this.lbSeachofcustomer.Size = new System.Drawing.Size(136, 16);
            this.lbSeachofcustomer.TabIndex = 2;
            this.lbSeachofcustomer.Text = "Seach by of customer";
            // 
            // lbNumberofpeople
            // 
            this.lbNumberofpeople.AutoSize = true;
            this.lbNumberofpeople.Location = new System.Drawing.Point(29, 281);
            this.lbNumberofpeople.Name = "lbNumberofpeople";
            this.lbNumberofpeople.Size = new System.Drawing.Size(115, 16);
            this.lbNumberofpeople.TabIndex = 2;
            this.lbNumberofpeople.Text = "Number of people";
            // 
            // txtNameofcustomer
            // 
            this.txtNameofcustomer.Location = new System.Drawing.Point(32, 81);
            this.txtNameofcustomer.Name = "txtNameofcustomer";
            this.txtNameofcustomer.Size = new System.Drawing.Size(159, 22);
            this.txtNameofcustomer.TabIndex = 3;
            // 
            // txtWaterMeterLastmonth
            // 
            this.txtWaterMeterLastmonth.Location = new System.Drawing.Point(32, 134);
            this.txtWaterMeterLastmonth.Name = "txtWaterMeterLastmonth";
            this.txtWaterMeterLastmonth.Size = new System.Drawing.Size(159, 22);
            this.txtWaterMeterLastmonth.TabIndex = 5;
            // 
            // txtWaterMeterThisMonth
            // 
            this.txtWaterMeterThisMonth.Location = new System.Drawing.Point(32, 191);
            this.txtWaterMeterThisMonth.Name = "txtWaterMeterThisMonth";
            this.txtWaterMeterThisMonth.Size = new System.Drawing.Size(159, 22);
            this.txtWaterMeterThisMonth.TabIndex = 6;
            // 
            // txtNumberofpeople
            // 
            this.txtNumberofpeople.Location = new System.Drawing.Point(32, 300);
            this.txtNumberofpeople.Name = "txtNumberofpeople";
            this.txtNumberofpeople.Size = new System.Drawing.Size(159, 22);
            this.txtNumberofpeople.TabIndex = 7;
            // 
            // txtSeachbyofcustomer
            // 
            this.txtSeachbyofcustomer.Location = new System.Drawing.Point(380, 64);
            this.txtSeachbyofcustomer.Name = "txtSeachbyofcustomer";
            this.txtSeachbyofcustomer.Size = new System.Drawing.Size(215, 22);
            this.txtSeachbyofcustomer.TabIndex = 8;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(282, 134);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(506, 179);
            this.dgv.TabIndex = 9;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbTypeofcustomer
            // 
            this.lbTypeofcustomer.AutoSize = true;
            this.lbTypeofcustomer.Location = new System.Drawing.Point(29, 227);
            this.lbTypeofcustomer.Name = "lbTypeofcustomer";
            this.lbTypeofcustomer.Size = new System.Drawing.Size(111, 16);
            this.lbTypeofcustomer.TabIndex = 2;
            this.lbTypeofcustomer.Text = "Type of customer";
            // 
            // btnExportInvoice
            // 
            this.btnExportInvoice.Location = new System.Drawing.Point(60, 361);
            this.btnExportInvoice.Name = "btnExportInvoice";
            this.btnExportInvoice.Size = new System.Drawing.Size(120, 23);
            this.btnExportInvoice.TabIndex = 10;
            this.btnExportInvoice.Text = "Export Invoice";
            this.btnExportInvoice.UseVisualStyleBackColor = true;
            this.btnExportInvoice.Click += new System.EventHandler(this.btnExportInvoice_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbTypeofcustomer
            // 
            this.cbTypeofcustomer.FormattingEnabled = true;
            this.cbTypeofcustomer.Items.AddRange(new object[] {
            "Hộ gia đình",
            "Doanh nghiệp nhỏ",
            "Nhà máy công nghiệp",
            "Cơ sở thương mại"});
            this.cbTypeofcustomer.Location = new System.Drawing.Point(32, 254);
            this.cbTypeofcustomer.Name = "cbTypeofcustomer";
            this.cbTypeofcustomer.Size = new System.Drawing.Size(159, 24);
            this.cbTypeofcustomer.TabIndex = 12;
            this.cbTypeofcustomer.SelectedIndexChanged += new System.EventHandler(this.cbTypeofcustomer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTypeofcustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExportInvoice);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtSeachbyofcustomer);
            this.Controls.Add(this.txtNumberofpeople);
            this.Controls.Add(this.txtWaterMeterThisMonth);
            this.Controls.Add(this.txtWaterMeterLastmonth);
            this.Controls.Add(this.txtNameofcustomer);
            this.Controls.Add(this.lbNumberofpeople);
            this.Controls.Add(this.lbTypeofcustomer);
            this.Controls.Add(this.lbSeachofcustomer);
            this.Controls.Add(this.lbWarterMeterThisMonth);
            this.Controls.Add(this.lbWarterMeterLastMonth);
            this.Controls.Add(this.lbNameofcustomer);
            this.Controls.Add(this.btnDESC);
            this.Controls.Add(this.btnASC);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnASC;
        private System.Windows.Forms.Button btnDESC;
        private System.Windows.Forms.Label lbNameofcustomer;
        private System.Windows.Forms.Label lbWarterMeterLastMonth;
        private System.Windows.Forms.Label lbWarterMeterThisMonth;
        private System.Windows.Forms.Label lbSeachofcustomer;
        private System.Windows.Forms.Label lbNumberofpeople;
        private System.Windows.Forms.TextBox txtNameofcustomer;
        private System.Windows.Forms.TextBox txtWaterMeterLastmonth;
        private System.Windows.Forms.TextBox txtWaterMeterThisMonth;
        private System.Windows.Forms.TextBox txtNumberofpeople;
        private System.Windows.Forms.TextBox txtSeachbyofcustomer;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbTypeofcustomer;
        private System.Windows.Forms.Button btnExportInvoice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbTypeofcustomer;
    }
}

