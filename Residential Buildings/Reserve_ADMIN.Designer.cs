
namespace Residential_Buildings
{
    partial class Reserve_ADMIN
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
            this.txtSearchReserve = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReserveData = new System.Windows.Forms.DataGridView();
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustData = new System.Windows.Forms.DataGridView();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuldID = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReserveData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.txtSearchReserve);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 38);
            this.panel1.TabIndex = 22;
            // 
            // txtSearchReserve
            // 
            this.txtSearchReserve.BackColor = System.Drawing.Color.White;
            this.txtSearchReserve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchReserve.Font = new System.Drawing.Font("Tahoma", 14.6F);
            this.txtSearchReserve.Location = new System.Drawing.Point(122, 0);
            this.txtSearchReserve.Name = "txtSearchReserve";
            this.txtSearchReserve.Size = new System.Drawing.Size(964, 37);
            this.txtSearchReserve.TabIndex = 16;
            this.txtSearchReserve.TextChanged += new System.EventHandler(this.txtSearchReserve_TextChanged);
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
            // ReserveData
            // 
            this.ReserveData.AllowUserToAddRows = false;
            this.ReserveData.AllowUserToDeleteRows = false;
            this.ReserveData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReserveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReserveData.Location = new System.Drawing.Point(27, 334);
            this.ReserveData.Name = "ReserveData";
            this.ReserveData.ReadOnly = true;
            this.ReserveData.RowHeadersWidth = 51;
            this.ReserveData.RowTemplate.Height = 26;
            this.ReserveData.Size = new System.Drawing.Size(1085, 215);
            this.ReserveData.TabIndex = 21;
            this.ReserveData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ReserveData_CellMouseDoubleClick);
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.ReserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBtn.ForeColor = System.Drawing.Color.White;
            this.ReserveBtn.Location = new System.Drawing.Point(862, 215);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(179, 44);
            this.ReserveBtn.TabIndex = 23;
            this.ReserveBtn.Text = "Reserve";
            this.ReserveBtn.UseVisualStyleBackColor = false;
            this.ReserveBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.txtSearchCust);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(26, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 38);
            this.panel2.TabIndex = 25;
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.BackColor = System.Drawing.Color.White;
            this.txtSearchCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCust.Font = new System.Drawing.Font("Tahoma", 14.6F);
            this.txtSearchCust.Location = new System.Drawing.Point(122, 0);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(370, 37);
            this.txtSearchCust.TabIndex = 16;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search";
            // 
            // CustData
            // 
            this.CustData.AllowUserToAddRows = false;
            this.CustData.AllowUserToDeleteRows = false;
            this.CustData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustData.Location = new System.Drawing.Point(27, 60);
            this.CustData.Name = "CustData";
            this.CustData.ReadOnly = true;
            this.CustData.RowHeadersWidth = 51;
            this.CustData.RowTemplate.Height = 26;
            this.CustData.Size = new System.Drawing.Size(492, 215);
            this.CustData.TabIndex = 24;
            this.CustData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustData_CellMouseDoubleClick);
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtCustID.Location = new System.Drawing.Point(582, 47);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(168, 34);
            this.txtCustID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(578, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(858, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Room ID";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtRoomID.Location = new System.Drawing.Point(862, 47);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(168, 34);
            this.txtRoomID.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(858, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Building ID";
            // 
            // txtBuldID
            // 
            this.txtBuldID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtBuldID.Location = new System.Drawing.Point(862, 139);
            this.txtBuldID.Name = "txtBuldID";
            this.txtBuldID.Size = new System.Drawing.Size(168, 34);
            this.txtBuldID.TabIndex = 30;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(582, 132);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(146, 28);
            this.dateTimeStart.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(578, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(578, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "End";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeEnd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(582, 221);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(146, 28);
            this.dateTimeEnd.TabIndex = 34;
            // 
            // Reserve_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuldID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustData);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReserveData);
            this.Name = "Reserve_ADMIN";
            this.Size = new System.Drawing.Size(1143, 585);
            this.Load += new System.EventHandler(this.Reserve_ADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReserveData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchReserve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ReserveData;
        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustData;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuldID;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
    }
}
