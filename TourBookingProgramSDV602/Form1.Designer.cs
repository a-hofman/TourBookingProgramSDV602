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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTours = new System.Windows.Forms.ListBox();
            this.lblTourListBox = new System.Windows.Forms.Label();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Tours = new TourBookingProgramSDV602.DataSet_Tours();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toursTableAdapter = new TourBookingProgramSDV602.DataSet_ToursTableAdapters.ToursTableAdapter();
            this.tourUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Tours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(713, 567);
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
            this.lstTours.DataSource = this.toursBindingSource;
            this.lstTours.FormattingEnabled = true;
            this.lstTours.Location = new System.Drawing.Point(12, 290);
            this.lstTours.Name = "lstTours";
            this.lstTours.Size = new System.Drawing.Size(776, 251);
            this.lstTours.TabIndex = 1;
            // 
            // lblTourListBox
            // 
            this.lblTourListBox.AutoSize = true;
            this.lblTourListBox.Location = new System.Drawing.Point(12, 9);
            this.lblTourListBox.Name = "lblTourListBox";
            this.lblTourListBox.Size = new System.Drawing.Size(70, 13);
            this.lblTourListBox.TabIndex = 2;
            this.lblTourListBox.Text = "Booked tours";
            // 
            // btnAddTour
            // 
            this.btnAddTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTour.Location = new System.Drawing.Point(12, 567);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(75, 23);
            this.btnAddTour.TabIndex = 3;
            this.btnAddTour.Text = "Add Tour";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(93, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete tour";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourUIDataGridViewTextBoxColumn,
            this.tourTypeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.numPeopleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 248);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataSetToursBindingSource
            // 
            this.dataSetToursBindingSource.DataSource = this.dataSet_Tours;
            this.dataSetToursBindingSource.Position = 0;
            // 
            // dataSet_Tours
            // 
            this.dataSet_Tours.DataSetName = "DataSet_Tours";
            this.dataSet_Tours.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.dataSetToursBindingSource;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // tourUIDataGridViewTextBoxColumn
            // 
            this.tourUIDataGridViewTextBoxColumn.DataPropertyName = "TourUI";
            this.tourUIDataGridViewTextBoxColumn.HeaderText = "TourUI";
            this.tourUIDataGridViewTextBoxColumn.Name = "tourUIDataGridViewTextBoxColumn";
            this.tourUIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tourTypeDataGridViewTextBoxColumn
            // 
            this.tourTypeDataGridViewTextBoxColumn.DataPropertyName = "TourType";
            this.tourTypeDataGridViewTextBoxColumn.HeaderText = "TourType";
            this.tourTypeDataGridViewTextBoxColumn.Name = "tourTypeDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // numPeopleDataGridViewTextBoxColumn
            // 
            this.numPeopleDataGridViewTextBoxColumn.DataPropertyName = "NumPeople";
            this.numPeopleDataGridViewTextBoxColumn.HeaderText = "NumPeople";
            this.numPeopleDataGridViewTextBoxColumn.Name = "numPeopleDataGridViewTextBoxColumn";
            // 
            // frmMyBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddTour);
            this.Controls.Add(this.lblTourListBox);
            this.Controls.Add(this.lstTours);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMyBookings";
            this.Text = "My Bookings";
            this.Load += new System.EventHandler(this.frmMyBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Tours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTourListBox;
        private System.Windows.Forms.Button btnAddTour;
        public System.Windows.Forms.ListBox lstTours;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetToursBindingSource;
        private DataSet_Tours dataSet_Tours;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private DataSet_ToursTableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPeopleDataGridViewTextBoxColumn;
    }
}

