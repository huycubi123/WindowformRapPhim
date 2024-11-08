using QLRapPhim.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRapPhim.Staff
{
    public partial class frmBookTicket : Form
    {
        private string nameStaff;
        DataTable table = new DataTable();
        DataProcess data = new DataProcess();
        public frmBookTicket()
        {
            InitializeComponent();
        }
        public frmBookTicket(string name)
        {
            this.nameStaff = name;
            InitializeComponent();
        }
        private void frmBookTicket_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Tên Phòng Chiếu");
            table.Columns.Add("Tên Phim");
            table.Columns.Add("Giờ Chiếu");
            table.Columns.Add("Ghế trống");
            dgvLichChieu.DataSource = table;
            lblNhanVien.Text += nameStaff;
        }

        private void frmBookTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbbPhim.Items.Clear();
            cbbPhim.SelectedIndex = -1;
            DataTable table = data.ReadDatabase("select f.Name from tblShowtime st join tblFilm f on st.FilmID = f.FilmID where CAST(st.Showtime as date) = '" + dtpNgayChieu.Value.ToString("yyyy-MM-dd") + "'");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbbPhim.Items.Add(table.Rows[i]["Name"]);
            }
        }

        private void cbbPhim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable table = data.ReadDatabase("select st.RoomID, film.Name, CONVERT(time, st.Showtime) as Time, COUNT(SeatID) as Status from tblShowtime st " +
                    "join tblFilm film on film.FilmID = st.FilmID join tblShowRoom sr on sr.RoomID = st.RoomID join dbo.tblSeat s on s.RoomID = sr.RoomID " +
                    "where sr.CinemaID = 'SKPCG' and s.Status = '0' and film.Name = N'" + cbbPhim.Text + "' and CAST(st.Showtime as date) = '" + dtpNgayChieu.Value.ToString("yyyy-MM-dd") + "' group by st.RoomID, film.Name, CONVERT(time, st.Showtime)");
            }
        }
    }
}
