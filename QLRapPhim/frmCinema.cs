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
            cmbCinemaID.Items.Clear();

            txtCinemaID.Text = "";
            txtCinemaName.Text = "";
            txtAddress.Text = "";
            cmbCinemaID.Text = "";
            txtAmount.Text = "";

            DataTable dt = process.ReadDatabase("Select * From tblCinema");
            dgvCinema.DataSource = dt;
            dgvCinema.Columns["CinemaID"].HeaderText = "Mã Rạp";
            dgvCinema.Columns["CinemaName"].HeaderText = "Tên Rạp";
            dgvCinema.Columns["Address"].HeaderText = "Địa Chỉ";
            foreach (DataGridViewColumn column in dgvCinema.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            DataTable dtc = process.ReadDatabase("Select CinemaID From tblCinema");

            foreach (DataRow row in dtc.Rows)
            {
                cmbCinemaID.Items.Add(row["CinemaID"].ToString());
            }
        }

        private void Cancel()
        {
            txtCinemaID.Text = "";
            txtCinemaName.Text = "";
            txtAddress.Text = "";
            cmbCinemaID.Text = "";
            txtAmount.Text = "";
        }
        public frmCinema()
        {
            InitializeComponent();
        }

        private void frmCinema_Load(object sender, EventArgs e)
        {
            txtCinemaID.Enabled = false;
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            btnDeleteDB.Enabled = false;
            btnSearch.Enabled = true;
            cmbCinemaID.Enabled = true;
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
            Cancel();

            txtCinemaID.Enabled = true;
            btnAddDB.Enabled = true;
            btnUpdateDB.Enabled = false;
            btnDeleteDB.Enabled = false;
            btnSearch.Enabled = false;
            cmbCinemaID.Enabled = false;
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            txtCinemaID.Enabled = false;
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = true;
            btnDeleteDB.Enabled = false;
            btnSearch.Enabled = true;
            cmbCinemaID.Enabled = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            txtCinemaID.Enabled=false;
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            btnDeleteDB.Enabled = true;
            btnSearch.Enabled = true;
            cmbCinemaID.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCinema.ClearSelection();
            if(cmbCinemaID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một rạp chiếu phim", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select * From tblCinema Where CinemaID = '" + cmbCinemaID.Text + "'");
                DataTable dtam = process.ReadDatabase("Select Count(RoomID) as amount From tblShowRoom where CinemaID = '" + cmbCinemaID.SelectedItem.ToString() + "'");
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Rạp phim không tồn tại", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    foreach (DataGridViewRow row in dgvCinema.Rows)
                    {
                        if (row.Cells["CinemaID"].Value.ToString() == cmbCinemaID.Text)
                        {
                            row.Selected = true;
                            dgvCinema.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }

                    txtCinemaID.Text = dt.Rows[0]["CinemaID"].ToString();
                    txtCinemaName.Text = dt.Rows[0]["CinemaName"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtAmount.Text = dtam.Rows[0]["amount"].ToString();
                }
            }    
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Cancel();

            txtCinemaID.Enabled = false;
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            btnDeleteDB.Enabled = false;
            btnSearch.Enabled = true;
            cmbCinemaID.Enabled = true;

        }


        private void btnAdđB_Click(object sender, EventArgs e)
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
                    for (int i = 1; i <= Convert.ToInt32(txtAmount.Text); i++)
                    {
                        string room = txtCinemaID.Text + i.ToString().PadLeft(2,'0');
                        process.ChangeDatabase("insert into tblShowRoom (RoomID, CinemaID) values ('" + room + "','" + txtCinemaID.Text + "')");
                    }
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Rạp chiếu phim đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
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
                }
            }
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
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
                }
            }
        }
    }
}
