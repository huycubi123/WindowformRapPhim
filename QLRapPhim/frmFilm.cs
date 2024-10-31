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
    public partial class frmFilm : Form
    {
        private DataProcess process = new DataProcess();
        private string currentID;
        private void LoadData()
        {
            
            DataTable dt = process.ReadDatabase("Select FilmID, Name, Language, Director, ProductionDate, Price From tblFilm");
            dgvFilm.DataSource = dt;
            dgvFilm.Columns["FilmID"].HeaderText = "Mã Nhân Viên";
            dgvFilm.Columns["Name"].HeaderText = "Tên Phim";
            dgvFilm.Columns["Language"].HeaderText = "Ngôn Ngữ";
            dgvFilm.Columns["Director"].HeaderText = "Đạo Diễn";
            dgvFilm.Columns["ProductionDate"].HeaderText = "Ngày Phát Hành";
            dgvFilm.Columns["Price"].HeaderText = "Giá Vé";
            foreach (DataGridViewColumn column in dgvFilm.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public frmFilm()
        {
            InitializeComponent();
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvFilm.CurrentRow.Index;
            currentID = dgvFilm.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvFilm.Rows[i].Cells[1].Value.ToString();
            txtLanguage.Text = dgvFilm.Rows[i].Cells[2].Value.ToString();
            txtDirector.Text = dgvFilm.Rows[i].Cells[3].Value.ToString();
            dtpDate.Text = dgvFilm.Rows[i].Cells[4].Value.ToString();
            txtPrice.Text = dgvFilm.Rows[i].Cells[5].Value.ToString();

        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLanguage.Text == "" || txtDirector.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select * from tblFilm where Name = '" + txtName + "' and ProductionDate = '" + dtpDate.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string query = "Insert into tblFilm (Name, Language, Director, ProductionDate, Price) Values (N'" + txtName.Text + "',N'" + txtLanguage.Text + "',N'" + txtDirector.Text + "','" + dtpDate.Text + "','" + txtPrice.Text + "')";
                    process.ChangeDatabase(query);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Phim đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            string query = "update tblFilm set Name = N'" + txtName.Text + "', Director = N'" + txtDirector.Text + "', Language = N'" + txtLanguage.Text + "', ProductionDate = '" + dtpDate.Text + "', Price = '" + txtPrice.Text + "' where FilmID = '" + currentID + "'";
            process.ChangeDatabase(query);
            LoadData();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string query = "delete from tblFilm where FilmID = '" + currentID + "'";
            process.ChangeDatabase(query);
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
