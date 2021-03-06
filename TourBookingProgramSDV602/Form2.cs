﻿using System;
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

        public Tour getItem()
        {
            string tourType = cboSelectTour.SelectedItem.ToString();
            decimal numPeople = numericUpDown1.Value;
            //Timespan startDate = dateTimePicker1.Value();

            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            TimeSpan tourLengthTimeSpan = (endDate - startDate);
            string tourLength = tourLengthTimeSpan.ToString();

            return new Tour { tourName = tourType, numPeople = numPeople };

            //return "Your holiday:" + tourType + " with " + numPeople + " people, for " + tourLength + "days.";
        }

        private void cboSelectTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectTour.SelectedItem != null)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }
    }
}
