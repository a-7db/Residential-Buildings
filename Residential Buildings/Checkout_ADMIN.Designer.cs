
namespace Residential_Buildings
{
    partial class Checkout_ADMIN
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
            this.txtSearchDetailas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ForCheckOutData = new System.Windows.Forms.DataGridView();
            this.EditResBtn = new System.Windows.Forms.Button();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ForCheckOutData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.txtSearchDetailas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(29, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 38);
            this.panel1.TabIndex = 30;
            // 
            // txtSearchDetailas
            // 
            this.txtSearchDetailas.BackColor = System.Drawing.Color.White;
            this.txtSearchDetailas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDetailas.Font = new System.Drawing.Font("Tahoma", 14.6F);
            this.txtSearchDetailas.Location = new System.Drawing.Point(122, 0);
            this.txtSearchDetailas.Name = "txtSearchDetailas";
            this.txtSearchDetailas.Size = new System.Drawing.Size(964, 37);
            this.txtSearchDetailas.TabIndex = 16;
            this.txtSearchDetailas.TextChanged += new System.EventHandler(this.txtSearchDetailas_TextChanged);
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
            // ForCheckOutData
            // 
            this.ForCheckOutData.AllowUserToAddRows = false;
            this.ForCheckOutData.AllowUserToDeleteRows = false;
            this.ForCheckOutData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ForCheckOutData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForCheckOutData.Location = new System.Drawing.Point(30, 164);
            this.ForCheckOutData.Name = "ForCheckOutData";
            this.ForCheckOutData.ReadOnly = true;
            this.ForCheckOutData.RowHeadersWidth = 51;
            this.ForCheckOutData.RowTemplate.Height = 26;
            this.ForCheckOutData.Size = new System.Drawing.Size(1085, 391);
            this.ForCheckOutData.TabIndex = 29;
            this.ForCheckOutData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ForCheckOutData_CellMouseDoubleClick);
            // 
            // EditResBtn
            // 
            this.EditResBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.EditResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditResBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditResBtn.ForeColor = System.Drawing.Color.White;
            this.EditResBtn.Location = new System.Drawing.Point(260, 49);
            this.EditResBtn.Name = "EditResBtn";
            this.EditResBtn.Size = new System.Drawing.Size(188, 44);
            this.EditResBtn.TabIndex = 32;
            this.EditResBtn.Text = "Edit";
            this.EditResBtn.UseVisualStyleBackColor = false;
            this.EditResBtn.Click += new System.EventHandler(this.EditResBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.CheckOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.ForeColor = System.Drawing.Color.White;
            this.CheckOutBtn.Location = new System.Drawing.Point(30, 49);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(188, 44);
            this.CheckOutBtn.TabIndex = 31;
            this.CheckOutBtn.Text = "Check Out";
            this.CheckOutBtn.UseVisualStyleBackColor = false;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(845, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "End";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeEnd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(894, 68);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(146, 28);
            this.dateTimeEnd.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(839, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Start";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(894, 23);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(146, 28);
            this.dateTimeStart.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(482, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Reservation ID";
            // 
            // txtResID
            // 
            this.txtResID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResID.Enabled = false;
            this.txtResID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtResID.Location = new System.Drawing.Point(486, 59);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(139, 34);
            this.txtResID.TabIndex = 40;
            // 
            // txtPay
            // 
            this.txtPay.BackColor = System.Drawing.Color.White;
            this.txtPay.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtPay.Location = new System.Drawing.Point(667, 59);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(127, 34);
            this.txtPay.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(663, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Pay";
            // 
            // Checkout_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.EditResBtn);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ForCheckOutData);
            this.Name = "Checkout_ADMIN";
            this.Size = new System.Drawing.Size(1143, 585);
            this.Load += new System.EventHandler(this.ResDetails_ADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ForCheckOutData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchDetailas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ForCheckOutData;
        private System.Windows.Forms.Button EditResBtn;
        private System.Windows.Forms.Button CheckOutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label1;
    }
}
