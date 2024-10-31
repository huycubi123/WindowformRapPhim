namespace QLRapPhim
{
    partial class frmCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCinema));
            this.dgvCinema = new System.Windows.Forms.DataGridView();
            this.lbCinemaID = new System.Windows.Forms.Label();
            this.lbCinemaName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtCinemaID = new System.Windows.Forms.TextBox();
            this.txtCinemaName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCinema
            // 
            this.dgvCinema.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCinema.Location = new System.Drawing.Point(0, 0);
            this.dgvCinema.Name = "dgvCinema";
            this.dgvCinema.RowHeadersWidth = 51;
            this.dgvCinema.RowTemplate.Height = 24;
            this.dgvCinema.Size = new System.Drawing.Size(884, 133);
            this.dgvCinema.TabIndex = 1;
            this.dgvCinema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCinema_CellContentClick);
            // 
            // lbCinemaID
            // 
            this.lbCinemaID.AutoSize = true;
            this.lbCinemaID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCinemaID.Location = new System.Drawing.Point(234, 201);
            this.lbCinemaID.Name = "lbCinemaID";
            this.lbCinemaID.Size = new System.Drawing.Size(82, 23);
            this.lbCinemaID.TabIndex = 8;
            this.lbCinemaID.Text = "Mã Rạp";
            // 
            // lbCinemaName
            // 
            this.lbCinemaName.AutoSize = true;
            this.lbCinemaName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCinemaName.Location = new System.Drawing.Point(234, 267);
            this.lbCinemaName.Name = "lbCinemaName";
            this.lbCinemaName.Size = new System.Drawing.Size(84, 23);
            this.lbCinemaName.TabIndex = 9;
            this.lbCinemaName.Text = "Tên Rạp";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddress.Location = new System.Drawing.Point(234, 333);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(82, 23);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Địa Chỉ";
            // 
            // txtCinemaID
            // 
            this.txtCinemaID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCinemaID.Location = new System.Drawing.Point(381, 198);
            this.txtCinemaID.Name = "txtCinemaID";
            this.txtCinemaID.Size = new System.Drawing.Size(220, 30);
            this.txtCinemaID.TabIndex = 14;
            // 
            // txtCinemaName
            // 
            this.txtCinemaName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCinemaName.Location = new System.Drawing.Point(381, 264);
            this.txtCinemaName.Name = "txtCinemaName";
            this.txtCinemaName.Size = new System.Drawing.Size(220, 30);
            this.txtCinemaName.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(381, 330);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 30);
            this.txtAddress.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 442);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnCancel.Location = new System.Drawing.Point(-1, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
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
            this.btnSearch.Location = new System.Drawing.Point(0, 278);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 40);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(0, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 22;
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
            this.btnChange.Location = new System.Drawing.Point(-1, 120);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(175, 40);
            this.btnChange.TabIndex = 21;
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
            this.btnAdd.Location = new System.Drawing.Point(-1, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 40);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.dgvCinema);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(180, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(884, 133);
            this.pnTop.TabIndex = 18;
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1064, 442);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCinemaName);
            this.Controls.Add(this.txtCinemaID);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbCinemaName);
            this.Controls.Add(this.lbCinemaID);
            this.Name = "frmCinema";
            this.Text = "frmCinemacs";
            this.Load += new System.EventHandler(this.frmCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCinema;
        private System.Windows.Forms.Label lbCinemaID;
        private System.Windows.Forms.Label lbCinemaName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtCinemaID;
        private System.Windows.Forms.TextBox txtCinemaName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTop;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}