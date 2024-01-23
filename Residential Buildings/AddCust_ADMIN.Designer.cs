
namespace Residential_Buildings
{
    partial class HomePage_CUSTOMER
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustData = new System.Windows.Forms.DataGridView();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.EditCustBtn = new System.Windows.Forms.Button();
            this.RemoveCustBtn = new System.Windows.Forms.Button();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.custCountlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.dateBDCust = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.CustData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustData
            // 
            this.CustData.AllowUserToAddRows = false;
            this.CustData.AllowUserToDeleteRows = false;
            this.CustData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustData.Location = new System.Drawing.Point(480, 67);
            this.CustData.Name = "CustData";
            this.CustData.ReadOnly = true;
            this.CustData.RowHeadersWidth = 51;
            this.CustData.RowTemplate.Height = 26;
            this.CustData.Size = new System.Drawing.Size(633, 387);
            this.CustData.TabIndex = 1;
            this.CustData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustData_CellMouseDoubleClick);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.AddCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustBtn.ForeColor = System.Drawing.Color.White;
            this.AddCustBtn.Location = new System.Drawing.Point(480, 487);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(188, 44);
            this.AddCustBtn.TabIndex = 2;
            this.AddCustBtn.Text = "Add";
            this.AddCustBtn.UseVisualStyleBackColor = false;
            this.AddCustBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditCustBtn
            // 
            this.EditCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.EditCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustBtn.ForeColor = System.Drawing.Color.White;
            this.EditCustBtn.Location = new System.Drawing.Point(708, 487);
            this.EditCustBtn.Name = "EditCustBtn";
            this.EditCustBtn.Size = new System.Drawing.Size(188, 44);
            this.EditCustBtn.TabIndex = 3;
            this.EditCustBtn.Text = "Edit";
            this.EditCustBtn.UseVisualStyleBackColor = false;
            this.EditCustBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoveCustBtn
            // 
            this.RemoveCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.RemoveCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCustBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCustBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveCustBtn.Location = new System.Drawing.Point(925, 487);
            this.RemoveCustBtn.Name = "RemoveCustBtn";
            this.RemoveCustBtn.Size = new System.Drawing.Size(188, 44);
            this.RemoveCustBtn.TabIndex = 4;
            this.RemoveCustBtn.Text = "Remove";
            this.RemoveCustBtn.UseVisualStyleBackColor = false;
            this.RemoveCustBtn.Click += new System.EventHandler(this.RemoveCustBtn_Click);
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.BackColor = System.Drawing.Color.White;
            this.txtSearchCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCust.Font = new System.Drawing.Font("Tahoma", 14.6F);
            this.txtSearchCust.Location = new System.Drawing.Point(122, 0);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(511, 37);
            this.txtSearchCust.TabIndex = 16;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.SearchCustBtn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search";
            // 
            // custCountlbl
            // 
            this.custCountlbl.AutoSize = true;
            this.custCountlbl.Font = new System.Drawing.Font("Century Gothic", 25.8F);
            this.custCountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.custCountlbl.Location = new System.Drawing.Point(218, 87);
            this.custCountlbl.Name = "custCountlbl";
            this.custCountlbl.Size = new System.Drawing.Size(47, 52);
            this.custCountlbl.TabIndex = 18;
            this.custCountlbl.Text = "0";
            this.custCountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(271, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Customers";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.txtSearchCust);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(480, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 38);
            this.panel1.TabIndex = 20;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFName.Location = new System.Drawing.Point(178, 261);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(232, 34);
            this.txtFName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtPhone.Location = new System.Drawing.Point(178, 399);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 34);
            this.txtPhone.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Birth Day";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtLName.Location = new System.Drawing.Point(178, 332);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(232, 34);
            this.txtLName.TabIndex = 15;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtCustomerID.Location = new System.Drawing.Point(178, 193);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(232, 34);
            this.txtCustomerID.TabIndex = 21;
            // 
            // dateBDCust
            // 
            this.dateBDCust.Font = new System.Drawing.Font("Tahoma", 13F);
            this.dateBDCust.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBDCust.Location = new System.Drawing.Point(178, 468);
            this.dateBDCust.Name = "dateBDCust";
            this.dateBDCust.Size = new System.Drawing.Size(232, 34);
            this.dateBDCust.TabIndex = 22;
            // 
            // HomePage_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.dateBDCust);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.custCountlbl);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.RemoveCustBtn);
            this.Controls.Add(this.EditCustBtn);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.CustData);
            this.Name = "HomePage_CUSTOMER";
            this.Size = new System.Drawing.Size(1143, 585);
            this.Load += new System.EventHandler(this.AddCust_ADMIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CustData;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Button EditCustBtn;
        private System.Windows.Forms.Button RemoveCustBtn;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label custCountlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DateTimePicker dateBDCust;
    }
}
