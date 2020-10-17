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
    public partial class frmAddTour : Form
    {
        public frmAddTour()
        {
            InitializeComponent();
            btnCancel.DialogResult = DialogResult.Cancel;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Enabled = false;
        }

        public string getTourName()
        {
            return cboSelectTour.SelectedItem.ToString();
        }

        public decimal getNumPeople()
        {
            return numericUpDown1.Value;
        }



        private void cboSelectTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectTour.SelectedItem != null)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Tour newTour = new Tour {tourType="holiday", numPeople=7 };
            frmMyBookings.TourList.Add(newTour);

        }
    }
}
