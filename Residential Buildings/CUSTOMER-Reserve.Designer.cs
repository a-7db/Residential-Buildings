
namespace Residential_Buildings
{
    partial class CUSTOMER_Reserve
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
            this.RoomData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.ReserveBtn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DoneLine = new System.Windows.Forms.Panel();
            this.lblFund = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomData
            // 
            this.RoomData.AllowUserToAddRows = false;
            this.RoomData.AllowUserToDeleteRows = false;
            this.RoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomData.Location = new System.Drawing.Point(35, 62);
            this.RoomData.Name = "RoomData";
            this.RoomData.ReadOnly = true;
            this.RoomData.RowHeadersWidth = 51;
            this.RoomData.RowTemplate.Height = 26;
            this.RoomData.Size = new System.Drawing.Size(633, 393);
            this.RoomData.TabIndex = 46;
            this.RoomData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomData_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(731, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Pay";
            // 
            // txtPay
            // 
            this.txtPay.BackColor = System.Drawing.Color.White;
            this.txtPay.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtPay.Location = new System.Drawing.Point(735, 256);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(330, 34);
            this.txtPay.TabIndex = 49;
            // 
            // ReserveBtn1
            // 
            this.ReserveBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.ReserveBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveBtn1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBtn1.ForeColor = System.Drawing.Color.White;
            this.ReserveBtn1.Location = new System.Drawing.Point(31, 275);
            this.ReserveBtn1.Name = "ReserveBtn1";
            this.ReserveBtn1.Size = new System.Drawing.Size(188, 44);
            this.ReserveBtn1.TabIndex = 48;
            this.ReserveBtn1.Text = "Reserve";
            this.ReserveBtn1.UseVisualStyleBackColor = false;
            this.ReserveBtn1.Click += new System.EventHandler(this.ReserveBtn1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(35, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 18);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(731, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Customer ID";
            // 
            // txtCustID
            // 
            this.txtCustID.BackColor = System.Drawing.Color.White;
            this.txtCustID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtCustID.Location = new System.Drawing.Point(735, 172);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(330, 34);
            this.txtCustID.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimeEnd);
            this.panel2.Controls.Add(this.dateTimeStart);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ReserveBtn1);
            this.panel2.Location = new System.Drawing.Point(704, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 349);
            this.panel2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(211, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "End";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeEnd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(215, 222);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(146, 28);
            this.dateTimeEnd.TabIndex = 56;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(31, 222);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(146, 28);
            this.dateTimeStart.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(27, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Start";
            // 
            // DoneLine
            // 
            this.DoneLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(198)))), ((int)(((byte)(113)))));
            this.DoneLine.Location = new System.Drawing.Point(704, 97);
            this.DoneLine.Name = "DoneLine";
            this.DoneLine.Size = new System.Drawing.Size(384, 10);
            this.DoneLine.TabIndex = 58;
            this.DoneLine.Visible = false;
            // 
            // lblFund
            // 
            this.lblFund.AutoSize = true;
            this.lblFund.BackColor = System.Drawing.Color.White;
            this.lblFund.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFund.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.lblFund.Location = new System.Drawing.Point(850, 45);
            this.lblFund.Name = "lblFund";
            this.lblFund.Size = new System.Drawing.Size(97, 37);
            this.lblFund.TabIndex = 59;
            this.lblFund.Text = "0 SAR";
            this.lblFund.Visible = false;
            // 
            // CUSTOMER_Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFund);
            this.Controls.Add(this.DoneLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.RoomData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CUSTOMER_Reserve";
            this.Size = new System.Drawing.Size(1146, 508);
            this.Load += new System.EventHandler(this.CUSTOMER_Reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button ReserveBtn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel DoneLine;
        private System.Windows.Forms.Label lblFund;
    }
}
