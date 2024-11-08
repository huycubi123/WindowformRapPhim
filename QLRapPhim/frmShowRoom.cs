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
    public partial class frmShowRoom : Form
    {

        private DataProcess process = new DataProcess();
        public frmShowRoom()
        {
            InitializeComponent();
        }

       

        private void LoadData()
        {
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            btnDeleteDB.Enabled = false;

            

        }

        private void frmShowRoom_Load(object sender, EventArgs e)
        {
            cmbCinemaID.Items.Clear();
            DataTable dtc = process.ReadDatabase("Select CinemaID From tblCinema");
            foreach (DataRow dr in dtc.Rows)
            {
                cmbCinemaID.Items.Add(dr["CinemaID"]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmbCinemaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = process.ReadDatabase("Select CinemaName from tblCinema where CinemaID = '" + cmbCinemaID.SelectedItem.ToString() + "'");
            txtCinemaName.Text = dt.Rows[0]["CinemaName"].ToString();

            cmbRoomID.Items.Clear();
            DataTable dtr = process.ReadDatabase("Select RoomID from tblShowRoom where CinemaID = '" + cmbCinemaID.SelectedItem.ToString() + "'");
            foreach (DataRow dr in dtr.Rows)
            {
                cmbRoomID.Items.Add(dr["RoomID"]);
            }
        }
    }
}
