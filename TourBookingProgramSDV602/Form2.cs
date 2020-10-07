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
            //btnAddTour.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            CheckSelectionMade();
        }

        private void CheckSelectionMade()
        {
            if (TourTypeString() == null)
            {
                btnAddTour.DialogResult = DialogResult.Cancel;
            }
            else
            {
                btnAddTour.DialogResult = DialogResult.OK;
            }
                    
        }

        public string getItem()
        {
            return cboSelectTour.SelectedItem.ToString();
        }

       public string TourTypeString()
       {
            string tourType = cboSelectTour.SelectedItem.ToString();
            return tourType;
       }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
        //    if (getItem() == null)
        //    {
        //        MessageBox.Show("Select a tour type");
        //    }
        //    else
        //    {
        //        MessageBox.Show(getItem());
        //    }
        }
    }
}
