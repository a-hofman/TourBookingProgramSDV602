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
            this.btnBookTour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboSelectTour
            // 
            this.cboSelectTour.FormattingEnabled = true;
            this.cboSelectTour.Items.AddRange(new object[] {
            "Safari",
            "Tropical",
            "Mountain"});
            this.cboSelectTour.Location = new System.Drawing.Point(12, 12);
            this.cboSelectTour.Name = "cboSelectTour";
            this.cboSelectTour.Size = new System.Drawing.Size(121, 21);
            this.cboSelectTour.TabIndex = 0;
            this.cboSelectTour.SelectedIndexChanged += new System.EventHandler(this.cboSelectTour_SelectedIndexChanged);
            // 
            // btnBookTour
            // 
            this.btnBookTour.Location = new System.Drawing.Point(139, 12);
            this.btnBookTour.Name = "btnBookTour";
            this.btnBookTour.Size = new System.Drawing.Size(75, 23);
            this.btnBookTour.TabIndex = 1;
            this.btnBookTour.Text = "Book Tour";
            this.btnBookTour.UseVisualStyleBackColor = true;
            this.btnBookTour.Click += new System.EventHandler(this.btnBookTour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // frmAddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBookTour);
            this.Controls.Add(this.cboSelectTour);
            this.Name = "frmAddTour";
            this.Text = "Add tour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectTour;
        private System.Windows.Forms.Button btnBookTour;
        private System.Windows.Forms.Label label1;
    }
}