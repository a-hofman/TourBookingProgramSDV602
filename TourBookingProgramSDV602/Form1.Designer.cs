namespace TourBookingProgramSDV602
{
    partial class frmMyBookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTours = new System.Windows.Forms.ListBox();
            this.lblTourListBox = new System.Windows.Forms.Label();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstTours
            // 
            this.lstTours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTours.FormattingEnabled = true;
            this.lstTours.Location = new System.Drawing.Point(12, 156);
            this.lstTours.Name = "lstTours";
            this.lstTours.Size = new System.Drawing.Size(776, 251);
            this.lstTours.TabIndex = 1;
            // 
            // lblTourListBox
            // 
            this.lblTourListBox.AutoSize = true;
            this.lblTourListBox.Location = new System.Drawing.Point(12, 140);
            this.lblTourListBox.Name = "lblTourListBox";
            this.lblTourListBox.Size = new System.Drawing.Size(70, 13);
            this.lblTourListBox.TabIndex = 2;
            this.lblTourListBox.Text = "Booked tours";
            // 
            // btnAddTour
            // 
            this.btnAddTour.Location = new System.Drawing.Point(12, 415);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(75, 23);
            this.btnAddTour.TabIndex = 3;
            this.btnAddTour.Text = "Add Tour";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // frmMyBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTour);
            this.Controls.Add(this.lblTourListBox);
            this.Controls.Add(this.lstTours);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMyBookings";
            this.Text = "My Bookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTourListBox;
        private System.Windows.Forms.Button btnAddTour;
        public System.Windows.Forms.ListBox lstTours;
    }
}

