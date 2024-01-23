
namespace Residential_Buildings
{
    partial class CUSTOMER_OResv
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForCheckOutData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ForCheckOutData)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "Reservation ID";
            // 
            // txtResID
            // 
            this.txtResID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResID.Enabled = false;
            this.txtResID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtResID.Location = new System.Drawing.Point(52, 163);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(219, 34);
            this.txtResID.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(48, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "End";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeEnd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(52, 348);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(197, 28);
            this.dateTimeEnd.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(48, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Start";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimeStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(52, 266);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(197, 28);
            this.dateTimeStart.TabIndex = 46;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(542, 437);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(188, 44);
            this.EditBtn.TabIndex = 45;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.CheckOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.ForeColor = System.Drawing.Color.White;
            this.CheckOutBtn.Location = new System.Drawing.Point(321, 437);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(188, 44);
            this.CheckOutBtn.TabIndex = 44;
            this.CheckOutBtn.Text = "Check Out";
            this.CheckOutBtn.UseVisualStyleBackColor = false;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(320, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 12);
            this.panel1.TabIndex = 43;
            // 
            // ForCheckOutData
            // 
            this.ForCheckOutData.AllowUserToAddRows = false;
            this.ForCheckOutData.AllowUserToDeleteRows = false;
            this.ForCheckOutData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ForCheckOutData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ForCheckOutData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForCheckOutData.Location = new System.Drawing.Point(321, 42);
            this.ForCheckOutData.Name = "ForCheckOutData";
            this.ForCheckOutData.ReadOnly = true;
            this.ForCheckOutData.RowHeadersWidth = 51;
            this.ForCheckOutData.RowTemplate.Height = 26;
            this.ForCheckOutData.Size = new System.Drawing.Size(790, 368);
            this.ForCheckOutData.TabIndex = 42;
            this.ForCheckOutData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ForCheckOutData_CellMouseDoubleClick);
            // 
            // CUSTOMER_OResv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ForCheckOutData);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.Name = "CUSTOMER_OResv";
            this.Size = new System.Drawing.Size(1146, 508);
            this.Load += new System.EventHandler(this.CUSTOMER_OResv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForCheckOutData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CheckOutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ForCheckOutData;
    }
}
