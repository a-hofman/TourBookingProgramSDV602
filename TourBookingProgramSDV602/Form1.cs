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
            frm2.ShowDialog();
            lstTours.Items.Add(frm2.getItem());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstTours);
            selectedItems = lstTours.SelectedItems; 
            
            if (lstTours.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lstTours.Items.Remove(selectedItems[i]);
            }
            else
                MessageBox.Show("Select a tour");
        }
    }
}
