using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRapPhim.Classes;

namespace QLRapPhim
{
    public partial class frmStaff : Form
    {
        private DataProcess process = new DataProcess();
        public frmStaff()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dt = process.ReadDatabase(@"Select StaffID, Name, Gender, BirthDay, NumberPhone, WorkStartDate, Password, CinemaID  
                                   From tblStaff
                                   Where Type_Account = '" +"Staff"+"'");
            dgvStaff.DataSource = dt;
            dgvStaff.Columns["StaffID"].HeaderText = "ID";
            dgvStaff.Columns["Name"].HeaderText = "Họ Và Tên";
            dgvStaff.Columns["Gender"].HeaderText = "Giới Tính";
            dgvStaff.Columns["BirthDay"].HeaderText = "Ngày Sinh";
            dgvStaff.Columns["NumberPhone"].HeaderText = "Số Điện Thoại";
            dgvStaff.Columns["WorkStartDate"].HeaderText = "Ngày Vào Làm";
            dgvStaff.Columns["Password"].HeaderText = "Mật Khẩu";
            dgvStaff.Columns["CinemaID"].HeaderText = "Cơ Sở";
            foreach (DataGridViewColumn column in dgvStaff.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataTable dtnv = process.ReadDatabase(@"Select ")
        }

        private void Cancel()
        {
            txtStaffID.Enabled = true;
            txtName.Text = "";
            txtPhoneNB.Text = "";
            txtPassword.Text = "";
            txtStaffID.Text = "";
            cmbBrach.Text = "";
            cmbMNV.Text = "";
            rdoKhac.Checked = false;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadData();
            DataTable dt = process.ReadDatabase("Select CinemaID From tblCinema");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbBrach.Items.Add(dt.Rows[i]["CinemaID"]);
            }
        }
        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStaffID.Enabled = false;
            int i = dgvStaff.CurrentRow.Index;
            txtStaffID.Text = dgvStaff.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvStaff.Rows[i].Cells[1].Value.ToString();
            if(dgvStaff.Rows[i].Cells[2].Value.ToString() == "Nam") rdoNam.Checked = true;
            if(dgvStaff.Rows[i].Cells[2].Value.ToString() == "Nữ") rdoNu.Checked = true;
            else rdoKhac.Checked = true;
            dtpBirthday.Text = dgvStaff.Rows[i].Cells[3].Value.ToString();
            txtPhoneNB.Text = dgvStaff.Rows[i].Cells[4].Value.ToString();
            dtpWSDate.Text = dgvStaff.Rows[i].Cells[5].Value.ToString();
            txtPassword.Text = dgvStaff.Rows[i].Cells[6].Value.ToString();
            cmbBrach.Text = dgvStaff.Rows[i].Cells[7].Value.ToString();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "" || txtName.Text == "" || txtPhoneNB.Text == "" || txtPassword.Text == "" || cmbBrach.Text == "" || dtpBirthday.Text == "" || dtpWSDate.Text == "" || (rdoKhac.Checked == false && rdoNam.Checked == false && rdoNu.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select StaffID From tblStaff where StaffID = '" + txtStaffID.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string gender = "";
                    if (rdoKhac.Checked == true) gender = "Khác";
                    if (rdoNam.Checked == true) gender = "Name";
                    if (rdoNu.Checked == true) gender = "Nữ";
                    string query = @"Insert into tblStaff (StaffID, Name, Gender, BirthDay, NumberPhone, WorkStartDate, Password, Type_Account, CinemaID)
                                     Values ('" + txtStaffID.Text + "',N'" + txtName.Text + "',N'" + gender + "','" + dtpBirthday.Text + "','" + txtPhoneNB.Text + "','" + dtpWSDate.Text + "','" + txtPassword.Text + "','" + "Staff" + "','" + cmbBrach.Text + "')";
                    process.ChangeDatabase(query);
                    LoadData();
                    Cancel();
                }
                else
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhoneNB.Text == "" || txtPassword.Text == "" || cmbBrach.Text == "" || dtpBirthday.Text == "" || dtpWSDate.Text == "" || (rdoKhac.Checked == false && rdoNam.Checked == false && rdoNu.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string gender = "";
                if (rdoKhac.Checked == true) gender = "Khác";
                if (rdoNam.Checked == true) gender = "Nam";
                if (rdoNu.Checked == true) gender = "Nữ";
                string query = @"update tblStaff set Name = N'" + txtName.Text + "', Gender = N'" + gender + "', BirthDay = '" + dtpBirthday.Text + "', NumberPhone = '" + txtPhoneNB.Text + "', WorkStartDate = '" + dtpWSDate.Text + "', Password = '" + txtPassword.Text + "', CinemaID = '" + cmbBrach.Text + "' where StaffID = '" + txtStaffID.Text + "'";

                if (MessageBox.Show("Bạn có muốn thay đổi thông tin nhân viên " + dgvStaff.Rows[dgvStaff.CurrentRow.Index].Cells[1].Value.ToString(), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase(query);
                    LoadData();
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string ID = dgvStaff.Rows[dgvStaff.CurrentRow.Index].Cells[0].Value.ToString();
            if (txtStaffID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string query = "delete from tblStaff where StaffID = '" + ID + "'";
                if (MessageBox.Show("Bạn có chắc chắc muốn xóa " + dgvStaff.Rows[dgvStaff.CurrentRow.Index].Cells[1].Value.ToString() + " ra khỏi danh sách nhân viên?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase(query);
                    LoadData();
                    Cancel();
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Cancel();
            LoadData();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if(cmbMNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một nhân viên", "Thông báo", MessageBoxButtons.OK);
            }    
            string query = @"Select StaffID, Name, Gender, BirthDay, NumberPhone, WorkStartDate, Password, tblCinema.CinemaName  
                                   From tblStaff inner join tblCinema on tblStaff.CinemaID = tblCinema.CinemaID
                                   Where Type_Account = '" + "Staff" + "' and Name = N'" + cmbMNV.Text + "'";
            DataTable dt = process.ReadDatabase(query);
            dgvStaff.DataSource = dt;
        }
    }
}
