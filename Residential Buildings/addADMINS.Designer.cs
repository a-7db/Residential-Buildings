
namespace Residential_Buildings
{
    partial class addADMINS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminData = new System.Windows.Forms.DataGridView();
            this.RemoveCustBtn = new System.Windows.Forms.Button();
            this.EditCustBtn = new System.Windows.Forms.Button();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(446, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 20);
            this.panel1.TabIndex = 24;
            // 
            // AdminData
            // 
            this.AdminData.AllowUserToAddRows = false;
            this.AdminData.AllowUserToDeleteRows = false;
            this.AdminData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminData.Location = new System.Drawing.Point(446, 79);
            this.AdminData.Name = "AdminData";
            this.AdminData.ReadOnly = true;
            this.AdminData.RowHeadersWidth = 51;
            this.AdminData.RowTemplate.Height = 26;
            this.AdminData.Size = new System.Drawing.Size(633, 460);
            this.AdminData.TabIndex = 23;
            this.AdminData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AdminData_CellMouseDoubleClick);
            // 
            // RemoveCustBtn
            // 
            this.RemoveCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.RemoveCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCustBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCustBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveCustBtn.Location = new System.Drawing.Point(210, 495);
            this.RemoveCustBtn.Name = "RemoveCustBtn";
            this.RemoveCustBtn.Size = new System.Drawing.Size(188, 44);
            this.RemoveCustBtn.TabIndex = 27;
            this.RemoveCustBtn.Text = "Remove";
            this.RemoveCustBtn.UseVisualStyleBackColor = false;
            this.RemoveCustBtn.Click += new System.EventHandler(this.RemoveCustBtn_Click);
            // 
            // EditCustBtn
            // 
            this.EditCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.EditCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustBtn.ForeColor = System.Drawing.Color.White;
            this.EditCustBtn.Location = new System.Drawing.Point(210, 410);
            this.EditCustBtn.Name = "EditCustBtn";
            this.EditCustBtn.Size = new System.Drawing.Size(188, 44);
            this.EditCustBtn.TabIndex = 26;
            this.EditCustBtn.Text = "Edit";
            this.EditCustBtn.UseVisualStyleBackColor = false;
            this.EditCustBtn.Click += new System.EventHandler(this.EditCustBtn_Click);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.AddCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustBtn.ForeColor = System.Drawing.Color.White;
            this.AddCustBtn.Location = new System.Drawing.Point(210, 330);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(188, 44);
            this.AddCustBtn.TabIndex = 25;
            this.AddCustBtn.Text = "Add";
            this.AddCustBtn.UseVisualStyleBackColor = false;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // txtAdminID
            // 
            this.txtAdminID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAdminID.Enabled = false;
            this.txtAdminID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtAdminID.Location = new System.Drawing.Point(166, 89);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(232, 34);
            this.txtAdminID.TabIndex = 33;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtPass.Location = new System.Drawing.Point(166, 247);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(232, 34);
            this.txtPass.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Admin Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Admin ID";
            // 
            // txtAdName
            // 
            this.txtAdName.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtAdName.Location = new System.Drawing.Point(166, 170);
            this.txtAdName.Name = "txtAdName";
            this.txtAdName.Size = new System.Drawing.Size(232, 34);
            this.txtAdName.TabIndex = 28;
            // 
            // addADMINS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.txtAdminID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdName);
            this.Controls.Add(this.RemoveCustBtn);
            this.Controls.Add(this.EditCustBtn);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminData);
            this.Name = "addADMINS";
            this.Size = new System.Drawing.Size(1143, 585);
            this.Load += new System.EventHandler(this.addADMINS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView AdminData;
        private System.Windows.Forms.Button RemoveCustBtn;
        private System.Windows.Forms.Button EditCustBtn;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdName;
    }
}
