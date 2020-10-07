namespace TourBookingProgramSDV602
{
    partial class frmAddTour
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
            this.cboSelectTour = new System.Windows.Forms.ComboBox();
            this.lblChooseTourType = new System.Windows.Forms.Label();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboSelectTour
            // 
            this.cboSelectTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectTour.FormattingEnabled = true;
            this.cboSelectTour.Items.AddRange(new object[] {
            "Safari",
            "Tropical",
            "Mountain"});
            this.cboSelectTour.Location = new System.Drawing.Point(12, 25);
            this.cboSelectTour.Name = "cboSelectTour";
            this.cboSelectTour.Size = new System.Drawing.Size(346, 21);
            this.cboSelectTour.TabIndex = 0;
            // 
            // lblChooseTourType
            // 
            this.lblChooseTourType.AutoSize = true;
            this.lblChooseTourType.Location = new System.Drawing.Point(12, 9);
            this.lblChooseTourType.Name = "lblChooseTourType";
            this.lblChooseTourType.Size = new System.Drawing.Size(202, 13);
            this.lblChooseTourType.TabIndex = 2;
            this.lblChooseTourType.Text = "Choose a type of tour from the drop down";
            // 
            // btnAddTour
            // 
            this.btnAddTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTour.Location = new System.Drawing.Point(283, 163);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(75, 23);
            this.btnAddTour.TabIndex = 3;
            this.btnAddTour.Text = "Add Tour";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(364, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 198);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTour);
            this.Controls.Add(this.lblChooseTourType);
            this.Controls.Add(this.cboSelectTour);
            this.Name = "frmAddTour";
            this.Text = "Add tour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectTour;
        private System.Windows.Forms.Label lblChooseTourType;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.Button btnCancel;
    }
}