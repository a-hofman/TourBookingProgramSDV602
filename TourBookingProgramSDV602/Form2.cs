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
            btnAddTour.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
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

       private void btnBookTour_Click(object sender, EventArgs e)
       {
           
        //    label1.Text = TourTypeString();
        //    this.Close();
       }

       private void cboSelectTour_SelectedIndexChanged(object sender, EventArgs e)
       {

       }
    }
}
