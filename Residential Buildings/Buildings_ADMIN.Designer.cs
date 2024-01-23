
namespace Residential_Buildings
{
    partial class Buildings_ADMIN
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
            this.BuildData = new System.Windows.Forms.DataGridView();
            this.txtSearchBuild = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFloorsCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuildID = new System.Windows.Forms.TextBox();
            this.txtFamilies = new System.Windows.Forms.MaskedTextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.RemoveBuildBtn = new System.Windows.Forms.Button();
            this.EditBuildBtn = new System.Windows.Forms.Button();
            this.AddBuildBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomCount = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BuildData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildData
            // 
            this.BuildData.AllowUserToAddRows = false;
            this.BuildData.AllowUserToDeleteRows = false;
            this.BuildData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BuildData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuildData.Location = new System.Drawing.Point(53, 76);
            this.BuildData.Name = "BuildData";
            this.BuildData.ReadOnly = true;
            this.BuildData.RowHeadersWidth = 51;
            this.BuildData.RowTemplate.Height = 26;
            this.BuildData.Size = new System.Drawing.Size(633, 387);
            this.BuildData.TabIndex = 36;
            this.BuildData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BuildData_CellMouseDoubleClick);
            // 
            // txtSearchBuild
            // 
            this.txtSearchBuild.BackColor = System.Drawing.Color.White;
            this.txtSearchBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBuild.Font = new System.Drawing.Font("Tahoma", 14.6F);
            this.txtSearchBuild.Location = new System.Drawing.Point(122, 0);
            this.txtSearchBuild.Name = "txtSearchBuild";
            this.txtSearchBuild.Size = new System.Drawing.Size(511, 37);
            this.txtSearchBuild.TabIndex = 16;
            this.txtSearchBuild.TextChanged += new System.EventHandler(this.txtSearchBuild_TextChanged);
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
            // txtFloorsCount
            // 
            this.txtFloorsCount.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFloorsCount.Location = new System.Drawing.Point(858, 251);
            this.txtFloorsCount.Name = "txtFloorsCount";
            this.txtFloorsCount.Size = new System.Drawing.Size(232, 34);
            this.txtFloorsCount.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(747, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Families";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(747, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Floors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(747, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(747, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Building ID";
            // 
            // txtBuildID
            // 
            this.txtBuildID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuildID.Enabled = false;
            this.txtBuildID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtBuildID.Location = new System.Drawing.Point(858, 111);
            this.txtBuildID.Name = "txtBuildID";
            this.txtBuildID.Size = new System.Drawing.Size(232, 34);
            this.txtBuildID.TabIndex = 43;
            // 
            // txtFamilies
            // 
            this.txtFamilies.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFamilies.Location = new System.Drawing.Point(858, 319);
            this.txtFamilies.Name = "txtFamilies";
            this.txtFamilies.Size = new System.Drawing.Size(232, 34);
            this.txtFamilies.TabIndex = 42;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtLocation.Location = new System.Drawing.Point(858, 181);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(232, 34);
            this.txtLocation.TabIndex = 41;
            // 
            // RemoveBuildBtn
            // 
            this.RemoveBuildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.RemoveBuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBuildBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBuildBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBuildBtn.Location = new System.Drawing.Point(498, 502);
            this.RemoveBuildBtn.Name = "RemoveBuildBtn";
            this.RemoveBuildBtn.Size = new System.Drawing.Size(188, 44);
            this.RemoveBuildBtn.TabIndex = 40;
            this.RemoveBuildBtn.Text = "Remove";
            this.RemoveBuildBtn.UseVisualStyleBackColor = false;
            this.RemoveBuildBtn.Click += new System.EventHandler(this.RemoveBuildBtn_Click);
            // 
            // EditBuildBtn
            // 
            this.EditBuildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.EditBuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBuildBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBuildBtn.ForeColor = System.Drawing.Color.White;
            this.EditBuildBtn.Location = new System.Drawing.Point(278, 502);
            this.EditBuildBtn.Name = "EditBuildBtn";
            this.EditBuildBtn.Size = new System.Drawing.Size(188, 44);
            this.EditBuildBtn.TabIndex = 39;
            this.EditBuildBtn.Text = "Edit";
            this.EditBuildBtn.UseVisualStyleBackColor = false;
            this.EditBuildBtn.Click += new System.EventHandler(this.EditBuildBtn_Click);
            // 
            // AddBuildBtn
            // 
            this.AddBuildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.AddBuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBuildBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBuildBtn.ForeColor = System.Drawing.Color.White;
            this.AddBuildBtn.Location = new System.Drawing.Point(54, 502);
            this.AddBuildBtn.Name = "AddBuildBtn";
            this.AddBuildBtn.Size = new System.Drawing.Size(188, 44);
            this.AddBuildBtn.TabIndex = 38;
            this.AddBuildBtn.Text = "Add";
            this.AddBuildBtn.UseVisualStyleBackColor = false;
            this.AddBuildBtn.Click += new System.EventHandler(this.AddBuildBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.txtSearchBuild);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(53, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 38);
            this.panel1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(747, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Rooms";
            // 
            // txtRoomCount
            // 
            this.txtRoomCount.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtRoomCount.Location = new System.Drawing.Point(858, 383);
            this.txtRoomCount.Name = "txtRoomCount";
            this.txtRoomCount.Size = new System.Drawing.Size(232, 34);
            this.txtRoomCount.TabIndex = 49;
            // 
            // Buildings_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoomCount);
            this.Controls.Add(this.BuildData);
            this.Controls.Add(this.txtFloorsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuildID);
            this.Controls.Add(this.txtFamilies);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.RemoveBuildBtn);
            this.Controls.Add(this.EditBuildBtn);
            this.Controls.Add(this.AddBuildBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Buildings_ADMIN";
            this.Size = new System.Drawing.Size(1143, 585);
            this.Load += new System.EventHandler(this.Buildings_ADMIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuildData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BuildData;
        private System.Windows.Forms.TextBox txtSearchBuild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFloorsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuildID;
        private System.Windows.Forms.MaskedTextBox txtFamilies;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button RemoveBuildBtn;
        private System.Windows.Forms.Button EditBuildBtn;
        private System.Windows.Forms.Button AddBuildBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtRoomCount;
    }
}
