namespace QLRapPhim
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMNVSearch = new System.Windows.Forms.Label();
            this.dtpWSDate = new System.Windows.Forms.DateTimePicker();
            this.lbWSDate = new System.Windows.Forms.Label();
            this.txtPhoneNB = new System.Windows.Forms.TextBox();
            this.lbNBPhone = new System.Windows.Forms.Label();
            this.cmbBrach = new System.Windows.Forms.ComboBox();
            this.lbBrach = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cmbMNV = new System.Windows.Forms.ComboBox();
            this.pnMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.cmbMNV);
            this.pnMain.Controls.Add(this.btnSearch);
            this.pnMain.Controls.Add(this.lbMNVSearch);
            this.pnMain.Controls.Add(this.panel2);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Controls.Add(this.rdoKhac);
            this.pnMain.Controls.Add(this.dtpWSDate);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Controls.Add(this.lbWSDate);
            this.pnMain.Controls.Add(this.lbPassword);
            this.pnMain.Controls.Add(this.txtPhoneNB);
            this.pnMain.Controls.Add(this.lbStaffID);
            this.pnMain.Controls.Add(this.lbNBPhone);
            this.pnMain.Controls.Add(this.lbBirthday);
            this.pnMain.Controls.Add(this.cmbBrach);
            this.pnMain.Controls.Add(this.lbGender);
            this.pnMain.Controls.Add(this.lbBrach);
            this.pnMain.Controls.Add(this.txtPassword);
            this.pnMain.Controls.Add(this.dtpBirthday);
            this.pnMain.Controls.Add(this.txtStaffID);
            this.pnMain.Controls.Add(this.txtName);
            this.pnMain.Controls.Add(this.rdoNu);
            this.pnMain.Controls.Add(this.rdoNam);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1064, 442);
            this.pnMain.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 442);
            this.panel1.TabIndex = 5;
            // 
            // dgvStaff
            // 
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(884, 133);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 133);
            this.panel2.TabIndex = 6;
            // 
            // lbMNVSearch
            // 
            this.lbMNVSearch.AutoSize = true;
            this.lbMNVSearch.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNVSearch.Location = new System.Drawing.Point(390, 388);
            this.lbMNVSearch.Name = "lbMNVSearch";
            this.lbMNVSearch.Size = new System.Drawing.Size(101, 22);
            this.lbMNVSearch.TabIndex = 58;
            this.lbMNVSearch.Text = "Mã Nhân Viên";
            // 
            // dtpWSDate
            // 
            this.dtpWSDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWSDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWSDate.Location = new System.Drawing.Point(792, 273);
            this.dtpWSDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpWSDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpWSDate.Name = "dtpWSDate";
            this.dtpWSDate.Size = new System.Drawing.Size(210, 30);
            this.dtpWSDate.TabIndex = 56;
            this.dtpWSDate.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // lbWSDate
            // 
            this.lbWSDate.AutoSize = true;
            this.lbWSDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWSDate.Location = new System.Drawing.Point(632, 279);
            this.lbWSDate.Name = "lbWSDate";
            this.lbWSDate.Size = new System.Drawing.Size(86, 24);
            this.lbWSDate.TabIndex = 55;
            this.lbWSDate.Text = "Ngày Sinh";
            // 
            // txtPhoneNB
            // 
            this.txtPhoneNB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNB.Location = new System.Drawing.Point(792, 186);
            this.txtPhoneNB.Name = "txtPhoneNB";
            this.txtPhoneNB.Size = new System.Drawing.Size(210, 30);
            this.txtPhoneNB.TabIndex = 54;
            // 
            // lbNBPhone
            // 
            this.lbNBPhone.AutoSize = true;
            this.lbNBPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNBPhone.Location = new System.Drawing.Point(632, 189);
            this.lbNBPhone.Name = "lbNBPhone";
            this.lbNBPhone.Size = new System.Drawing.Size(111, 24);
            this.lbNBPhone.TabIndex = 53;
            this.lbNBPhone.Text = "Số Điện Thoại";
            // 
            // cmbBrach
            // 
            this.cmbBrach.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrach.FormattingEnabled = true;
            this.cmbBrach.Location = new System.Drawing.Point(792, 233);
            this.cmbBrach.Name = "cmbBrach";
            this.cmbBrach.Size = new System.Drawing.Size(210, 32);
            this.cmbBrach.TabIndex = 52;
            // 
            // lbBrach
            // 
            this.lbBrach.AutoSize = true;
            this.lbBrach.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrach.Location = new System.Drawing.Point(632, 236);
            this.lbBrach.Name = "lbBrach";
            this.lbBrach.Size = new System.Drawing.Size(107, 24);
            this.lbBrach.TabIndex = 51;
            this.lbBrach.Text = "Nơi Làm Việc";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(346, 319);
            this.dtpBirthday.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthday.TabIndex = 50;
            this.dtpBirthday.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhac.Location = new System.Drawing.Point(491, 276);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(68, 28);
            this.rdoKhac.TabIndex = 49;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(422, 277);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(51, 28);
            this.rdoNu.TabIndex = 48;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(349, 276);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(67, 28);
            this.rdoNam.TabIndex = 47;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(346, 233);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 30);
            this.txtName.TabIndex = 46;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(346, 183);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(210, 30);
            this.txtStaffID.TabIndex = 45;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(792, 319);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 30);
            this.txtPassword.TabIndex = 44;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(209, 279);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(76, 24);
            this.lbGender.TabIndex = 43;
            this.lbGender.Text = "Giới Tính";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(209, 324);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(86, 24);
            this.lbBirthday.TabIndex = 41;
            this.lbBirthday.Text = "Ngày Sinh";
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffID.Location = new System.Drawing.Point(208, 189);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(115, 24);
            this.lbStaffID.TabIndex = 40;
            this.lbStaffID.Text = "Mã Nhân Viên";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(632, 325);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(80, 24);
            this.lbPassword.TabIndex = 39;
            this.lbPassword.Text = "Mật Khẩu";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(209, 236);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(89, 24);
            this.lbName.TabIndex = 38;
            this.lbName.Text = "Họ Và Tên";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 22;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnCancel.Location = new System.Drawing.Point(3, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 22;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnDelete.Location = new System.Drawing.Point(3, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.BorderRadius = 22;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnChange.Location = new System.Drawing.Point(2, 122);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(175, 40);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "Sửa";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 22;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(2, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 40);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 22;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(741, 378);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 35);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // cmbMNV
            // 
            this.cmbMNV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMNV.FormattingEnabled = true;
            this.cmbMNV.Location = new System.Drawing.Point(507, 383);
            this.cmbMNV.Name = "cmbMNV";
            this.cmbMNV.Size = new System.Drawing.Size(211, 32);
            this.cmbMNV.TabIndex = 60;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1064, 442);
            this.Controls.Add(this.pnMain);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMNVSearch;
        private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.DateTimePicker dtpWSDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbWSDate;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPhoneNB;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Label lbNBPhone;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.ComboBox cmbBrach;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbBrach;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.ComboBox cmbMNV;
    }
}