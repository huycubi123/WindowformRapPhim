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
    public partial class frmCinema : Form
    {

        DataProcess process = new DataProcess();

        private void LoadData()
        {
            DataTable dt = process.ReadDatabase("Select * From tblCinema");
            dgvCinema.DataSource = dt;
            dgvCinema.Columns["CinemaID"].HeaderText = "Mã Rạp";
            dgvCinema.Columns["CinemaName"].HeaderText = "Tên Rạp";
            dgvCinema.Columns["Address"].HeaderText = "Địa Chỉ";
            foreach (DataGridViewColumn column in dgvCinema.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Cancel()
        {
            txtCinemaID.Text = "";
            txtCinemaName.Text = "";
            txtAddress.Text = "";
            txtCinemaID.Enabled = true;
        }
        public frmCinema()
        {
            InitializeComponent();
        }

        private void frmCinema_Load(object sender, EventArgs e)
        {
            LoadData();
        }





        private void dgvCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCinema.CurrentRow.Index;
            txtCinemaID.Text = dgvCinema.Rows[i].Cells["CinemaID"].Value.ToString();
            txtCinemaName.Text = dgvCinema.Rows[i].Cells["CinemaName"].Value.ToString();
            txtAddress.Text = dgvCinema.Rows[i].Cells["Address"].Value.ToString();
            txtCinemaID.Enabled = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtCinemaID.Text == "" || txtCinemaName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select CinemaID From tblCinema Where CinemaID = '" + txtCinemaID.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    process.ChangeDatabase("insert into tblCinema (CinemaID,CinemaName,Address) values ('" + txtCinemaID.Text + "',N'" + txtCinemaName.Text + "',N'" + txtAddress.Text + "')");
                    LoadData();
                    Cancel();
                }
                else
                {
                    MessageBox.Show("Rạp chiếu phim đã tồn tại", "Thông báo", MessageBoxButtons.OK);

                }
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            if (txtCinemaID.Text == "" || txtCinemaName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thay đổi thông tin rạp " + txtCinemaID.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase("update tblCinema set CinemaName = N'" + txtCinemaName.Text + "', Address = N'" + txtAddress.Text + "' where CinemaID = '" + txtCinemaID.Text + "'");
                    LoadData();
                    Cancel();
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (txtCinemaID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một rạp phim", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa rạp " + txtCinemaID.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase("Delete from tblCinema Where CinemaID = '" + txtCinemaID.Text + "'");
                    LoadData();
                    Cancel();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Cancel();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
