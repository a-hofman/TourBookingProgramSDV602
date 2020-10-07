using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourBookingProgramSDV602
{
    public partial class frmMyBookings : Form
    {
        public frmMyBookings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            frmAddTour frm2 = new frmAddTour();
            if (frm2.ShowDialog(this) == DialogResult.OK)
            {
                lstTours.Items.Add(frm2.getItem());
            }
            else
            {
                MessageBox.Show("error");
            }
            frm2.Close();
            frm2.Dispose();
        }

    }
}
