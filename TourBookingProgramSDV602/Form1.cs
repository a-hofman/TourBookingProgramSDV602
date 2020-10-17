using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourBookingProgramSDV602
{
    public partial class frmMyBookings : Form
    {
        public static List<Tour> TourList = new List<Tour>();
        public List<Tour> TourList2 = new List<Tour>();

        public frmMyBookings()
        {
            InitializeComponent();
            lstTours.DataSource = TourList2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            frmAddTour frmAddTour = new frmAddTour();
            frmAddTour.ShowDialog();

            //Tour newTour = new Tour("holiday", 7);
            //TourList.Add(newTour);
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

        private void lstTours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
