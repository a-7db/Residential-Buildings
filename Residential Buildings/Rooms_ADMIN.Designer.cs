
namespace Residential_Buildings
{
    partial class Rooms_ADMIN
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
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomData = new System.Windows.Forms.DataGridView();
            this.RemoveRoomBtn = new System.Windows.Forms.Button();
            this.EditRoomBtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.CBoxBuldID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.txtSearchRoom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(37, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 38);
            this.panel1.TabIndex = 22;
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.BackColor = System.Drawing.Color.White;
            this.txtSearchRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchRoom.Font = new System.Drawing.Font("Tahoma", 14.6F);
            this.txtSearchRoom.Location = new System.Drawing.Point(122, 0);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(511, 37);
            this.txtSearchRoom.TabIndex = 16;
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
            // RoomData
            // 
            this.RoomData.AllowUserToAddRows = false;
            this.RoomData.AllowUserToDeleteRows = false;
            this.RoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomData.Location = new System.Drawing.Point(37, 67);
            this.RoomData.Name = "RoomData";
            this.RoomData.ReadOnly = true;
            this.RoomData.RowHeadersWidth = 51;
            this.RoomData.RowTemplate.Height = 26;
            this.RoomData.Size = new System.Drawing.Size(633, 387);
            this.RoomData.TabIndex = 21;
            this.RoomData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomData_CellMouseDoubleClick);
            // 
            // RemoveRoomBtn
            // 
            this.RemoveRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.RemoveRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRoomBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveRoomBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveRoomBtn.Location = new System.Drawing.Point(482, 493);
            this.RemoveRoomBtn.Name = "RemoveRoomBtn";
            this.RemoveRoomBtn.Size = new System.Drawing.Size(188, 44);
            this.RemoveRoomBtn.TabIndex = 25;
            this.RemoveRoomBtn.Text = "Remove";
            this.RemoveRoomBtn.UseVisualStyleBackColor = false;
            this.RemoveRoomBtn.Click += new System.EventHandler(this.RemoveRoomBtn_Click);
            // 
            // EditRoomBtn
            // 
            this.EditRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.EditRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRoomBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoomBtn.ForeColor = System.Drawing.Color.White;
            this.EditRoomBtn.Location = new System.Drawing.Point(262, 493);
            this.EditRoomBtn.Name = "EditRoomBtn";
            this.EditRoomBtn.Size = new System.Drawing.Size(188, 44);
            this.EditRoomBtn.TabIndex = 24;
            this.EditRoomBtn.Text = "Edit";
            this.EditRoomBtn.UseVisualStyleBackColor = false;
            this.EditRoomBtn.Click += new System.EventHandler(this.EditRoomBtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.AddRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoomBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoomBtn.Location = new System.Drawing.Point(38, 493);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(188, 44);
            this.AddRoomBtn.TabIndex = 23;
            this.AddRoomBtn.Text = "Add";
            this.AddRoomBtn.UseVisualStyleBackColor = false;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtCost.Location = new System.Drawing.Point(842, 267);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(232, 34);
            this.txtCost.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(731, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Building ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(731, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(731, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Floor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(731, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Room ID";
            // 
            // txtRoomID
            // 
            this.txtRoomID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRoomID.Enabled = false;
            this.txtRoomID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtRoomID.Location = new System.Drawing.Point(842, 127);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(232, 34);
            this.txtRoomID.TabIndex = 29;
            // 
            // txtFloor
            // 
            this.txtFloor.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFloor.Location = new System.Drawing.Point(842, 197);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(232, 34);
            this.txtFloor.TabIndex = 26;
            // 
            // CBoxBuldID
            // 
            this.CBoxBuldID.DisplayMember = "2";
            this.CBoxBuldID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.CBoxBuldID.FormattingEnabled = true;
            this.CBoxBuldID.Location = new System.Drawing.Point(841, 335);
            this.CBoxBuldID.Name = "CBoxBuldID";
            this.CBoxBuldID.Size = new System.Drawing.Size(232, 35);
            this.CBoxBuldID.TabIndex = 36;
            this.CBoxBuldID.ValueMember = "2";
            // 
            // Rooms_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.CBoxBuldID);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.RemoveRoomBtn);
            this.Controls.Add(this.EditRoomBtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RoomData);
            this.Name = "Rooms_ADMIN";
            this.Size = new System.Drawing.Size(1143, 585);
            this.Load += new System.EventHandler(this.Rooms_ADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RoomData;
        private System.Windows.Forms.Button RemoveRoomBtn;
        private System.Windows.Forms.Button EditRoomBtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.ComboBox CBoxBuldID;
    }
}
