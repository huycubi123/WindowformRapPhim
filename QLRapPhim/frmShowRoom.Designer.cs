namespace QLRapPhim
{
    partial class frmShowRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowRoom));
            this.lbCinemaID = new System.Windows.Forms.Label();
            this.cmbCinemaID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCinemaName = new System.Windows.Forms.TextBox();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.txtFilmID = new System.Windows.Forms.TextBox();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.lbRoomIDSearch = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDB = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCinemaID
            // 
            this.lbCinemaID.AutoSize = true;
            this.lbCinemaID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCinemaID.Location = new System.Drawing.Point(245, 121);
            this.lbCinemaID.Name = "lbCinemaID";
            this.lbCinemaID.Size = new System.Drawing.Size(111, 24);
            this.lbCinemaID.TabIndex = 65;
            this.lbCinemaID.Text = "Mã Rạp Phim";
            // 
            // cmbCinemaID
            // 
            this.cmbCinemaID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCinemaID.FormattingEnabled = true;
            this.cmbCinemaID.Location = new System.Drawing.Point(363, 118);
            this.cmbCinemaID.Name = "cmbCinemaID";
            this.cmbCinemaID.Size = new System.Drawing.Size(221, 32);
            this.cmbCinemaID.TabIndex = 67;
            this.cmbCinemaID.SelectedIndexChanged += new System.EventHandler(this.cmbCinemaID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(648, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tên Rạp Phim";
            // 
            // txtCinemaName
            // 
            this.txtCinemaName.Enabled = false;
            this.txtCinemaName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCinemaName.Location = new System.Drawing.Point(784, 115);
            this.txtCinemaName.Name = "txtCinemaName";
            this.txtCinemaName.Size = new System.Drawing.Size(221, 30);
            this.txtCinemaName.TabIndex = 69;
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRoomID.Location = new System.Drawing.Point(245, 198);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(86, 24);
            this.lbRoomID.TabIndex = 68;
            this.lbRoomID.Text = "Mã Phòng";
            // 
            // txtFilmID
            // 
            this.txtFilmID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilmID.Location = new System.Drawing.Point(363, 195);
            this.txtFilmID.Name = "txtFilmID";
            this.txtFilmID.Size = new System.Drawing.Size(221, 30);
            this.txtFilmID.TabIndex = 66;
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(438, 273);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(221, 32);
            this.cmbRoomID.TabIndex = 73;
            // 
            // lbRoomIDSearch
            // 
            this.lbRoomIDSearch.AutoSize = true;
            this.lbRoomIDSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomIDSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRoomIDSearch.Location = new System.Drawing.Point(320, 276);
            this.lbRoomIDSearch.Name = "lbRoomIDSearch";
            this.lbRoomIDSearch.Size = new System.Drawing.Size(86, 24);
            this.lbRoomIDSearch.TabIndex = 74;
            this.lbRoomIDSearch.Text = "Mã Phòng";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAmount.Location = new System.Drawing.Point(648, 198);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(114, 24);
            this.lbAmount.TabIndex = 76;
            this.lbAmount.Text = "Số Lượng Ghế";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(784, 195);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(221, 30);
            this.txtAmount.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 442);
            this.panel1.TabIndex = 77;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 22;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnCancel.Location = new System.Drawing.Point(3, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Hủy";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 22;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnDelete.Location = new System.Drawing.Point(3, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Xóa";
            // 
            // btnChange
            // 
            this.btnChange.BorderRadius = 22;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnChange.Location = new System.Drawing.Point(2, 162);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(175, 40);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Sửa";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 22;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(2, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 40);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(727, 275);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 30);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Tìm Kiếm";
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteDB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnDeleteDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteDB.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDB.Location = new System.Drawing.Point(883, 358);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(122, 32);
            this.btnDeleteDB.TabIndex = 81;
            this.btnDeleteDB.Text = "Xóa";
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnUpdateDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateDB.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDB.Location = new System.Drawing.Point(566, 358);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(122, 32);
            this.btnUpdateDB.TabIndex = 80;
            this.btnUpdateDB.Text = "Sửa";
            // 
            // btnAddDB
            // 
            this.btnAddDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAddDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDB.ForeColor = System.Drawing.Color.White;
            this.btnAddDB.Location = new System.Drawing.Point(249, 358);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(122, 32);
            this.btnAddDB.TabIndex = 79;
            this.btnAddDB.Text = "Thêm";
            // 
            // frmShowRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1064, 442);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lbRoomIDSearch);
            this.Controls.Add(this.cmbRoomID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCinemaName);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.cmbCinemaID);
            this.Controls.Add(this.txtFilmID);
            this.Controls.Add(this.lbCinemaID);
            this.Name = "frmShowRoom";
            this.Text = "ShowRoom";
            this.Load += new System.EventHandler(this.frmShowRoom_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCinemaID;
        private System.Windows.Forms.ComboBox cmbCinemaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCinemaName;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.TextBox txtFilmID;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.Label lbRoomIDSearch;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnDeleteDB;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDB;
        private Guna.UI2.WinForms.Guna2Button btnAddDB;
    }
}