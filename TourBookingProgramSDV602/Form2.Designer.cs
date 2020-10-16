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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTour));
            System.Windows.Forms.Label tourUILabel;
            System.Windows.Forms.Label tourTypeLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label numPeopleLabel;
            this.cboSelectTour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblPreview = new System.Windows.Forms.Label();
            this.dataSet_Tours = new TourBookingProgramSDV602.DataSet_Tours();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toursTableAdapter = new TourBookingProgramSDV602.DataSet_ToursTableAdapters.ToursTableAdapter();
            this.tableAdapterManager = new TourBookingProgramSDV602.DataSet_ToursTableAdapters.TableAdapterManager();
            this.toursBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toursBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tourUITextBox = new System.Windows.Forms.TextBox();
            this.tourTypeTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numPeopleTextBox = new System.Windows.Forms.TextBox();
            tourUILabel = new System.Windows.Forms.Label();
            tourTypeLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            numPeopleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Tours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingNavigator)).BeginInit();
            this.toursBindingNavigator.SuspendLayout();
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
            this.cboSelectTour.Location = new System.Drawing.Point(11, 32);
            this.cboSelectTour.Name = "cboSelectTour";
            this.cboSelectTour.Size = new System.Drawing.Size(604, 21);
            this.cboSelectTour.TabIndex = 0;
            this.cboSelectTour.SelectedIndexChanged += new System.EventHandler(this.cboSelectTour_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a type of tour from the drop down";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(460, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(541, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "How many people are going on the tour?";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(12, 78);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(604, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start your tour";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "End your tour";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(426, 131);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2020, 10, 10, 20, 40, 0, 0);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(12, 164);
            this.lblPreview.MaximumSize = new System.Drawing.Size(385, 100);
            this.lblPreview.MinimumSize = new System.Drawing.Size(385, 20);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(385, 20);
            this.lblPreview.TabIndex = 11;
            this.lblPreview.Text = "Tour preview will show here";
            // 
            // dataSet_Tours
            // 
            this.dataSet_Tours.DataSetName = "DataSet_Tours";
            this.dataSet_Tours.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.dataSet_Tours;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ToursTableAdapter = this.toursTableAdapter;
            this.tableAdapterManager.UpdateOrder = TourBookingProgramSDV602.DataSet_ToursTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toursBindingNavigator
            // 
            this.toursBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.toursBindingNavigator.BindingSource = this.toursBindingSource;
            this.toursBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.toursBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.toursBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toursBindingNavigatorSaveItem});
            this.toursBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.toursBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.toursBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.toursBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.toursBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.toursBindingNavigator.Name = "toursBindingNavigator";
            this.toursBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.toursBindingNavigator.Size = new System.Drawing.Size(628, 25);
            this.toursBindingNavigator.TabIndex = 12;
            this.toursBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // toursBindingNavigatorSaveItem
            // 
            this.toursBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toursBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("toursBindingNavigatorSaveItem.Image")));
            this.toursBindingNavigatorSaveItem.Name = "toursBindingNavigatorSaveItem";
            this.toursBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.toursBindingNavigatorSaveItem.Text = "Save Data";
            this.toursBindingNavigatorSaveItem.Click += new System.EventHandler(this.toursBindingNavigatorSaveItem_Click);
            // 
            // tourUILabel
            // 
            tourUILabel.AutoSize = true;
            tourUILabel.Location = new System.Drawing.Point(18, 208);
            tourUILabel.Name = "tourUILabel";
            tourUILabel.Size = new System.Drawing.Size(46, 13);
            tourUILabel.TabIndex = 12;
            tourUILabel.Text = "Tour UI:";
            // 
            // tourUITextBox
            // 
            this.tourUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "TourUI", true));
            this.tourUITextBox.Location = new System.Drawing.Point(92, 205);
            this.tourUITextBox.Name = "tourUITextBox";
            this.tourUITextBox.Size = new System.Drawing.Size(200, 20);
            this.tourUITextBox.TabIndex = 13;
            // 
            // tourTypeLabel
            // 
            tourTypeLabel.AutoSize = true;
            tourTypeLabel.Location = new System.Drawing.Point(18, 234);
            tourTypeLabel.Name = "tourTypeLabel";
            tourTypeLabel.Size = new System.Drawing.Size(59, 13);
            tourTypeLabel.TabIndex = 14;
            tourTypeLabel.Text = "Tour Type:";
            // 
            // tourTypeTextBox
            // 
            this.tourTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "TourType", true));
            this.tourTypeTextBox.Location = new System.Drawing.Point(92, 231);
            this.tourTypeTextBox.Name = "tourTypeTextBox";
            this.tourTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.tourTypeTextBox.TabIndex = 15;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(18, 261);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 16;
            startDateLabel.Text = "Start Date:";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toursBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(92, 257);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 17;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(18, 287);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 18;
            endDateLabel.Text = "End Date:";
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toursBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(92, 283);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 19;
            // 
            // numPeopleLabel
            // 
            numPeopleLabel.AutoSize = true;
            numPeopleLabel.Location = new System.Drawing.Point(18, 312);
            numPeopleLabel.Name = "numPeopleLabel";
            numPeopleLabel.Size = new System.Drawing.Size(68, 13);
            numPeopleLabel.TabIndex = 20;
            numPeopleLabel.Text = "Num People:";
            // 
            // numPeopleTextBox
            // 
            this.numPeopleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "NumPeople", true));
            this.numPeopleTextBox.Location = new System.Drawing.Point(92, 309);
            this.numPeopleTextBox.Name = "numPeopleTextBox";
            this.numPeopleTextBox.Size = new System.Drawing.Size(200, 20);
            this.numPeopleTextBox.TabIndex = 21;
            // 
            // frmAddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 380);
            this.Controls.Add(tourUILabel);
            this.Controls.Add(this.tourUITextBox);
            this.Controls.Add(tourTypeLabel);
            this.Controls.Add(this.tourTypeTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(numPeopleLabel);
            this.Controls.Add(this.numPeopleTextBox);
            this.Controls.Add(this.toursBindingNavigator);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSelectTour);
            this.MinimumSize = new System.Drawing.Size(430, 400);
            this.Name = "frmAddTour";
            this.Text = "Add tour";
            this.Load += new System.EventHandler(this.frmAddTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Tours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingNavigator)).EndInit();
            this.toursBindingNavigator.ResumeLayout(false);
            this.toursBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblPreview;
        private DataSet_Tours dataSet_Tours;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private DataSet_ToursTableAdapters.ToursTableAdapter toursTableAdapter;
        private DataSet_ToursTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator toursBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toursBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tourUITextBox;
        private System.Windows.Forms.TextBox tourTypeTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox numPeopleTextBox;
    }
}