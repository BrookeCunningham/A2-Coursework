namespace LakesideEscapesPodBooking
{
    partial class FormViewBookings
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblErrorPodID = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.lblPodID = new System.Windows.Forms.Label();
            this.txtboxPodID = new System.Windows.Forms.TextBox();
            this.pnlBookingID = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtboxBookingID = new System.Windows.Forms.TextBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnBookingID = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.tblBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBookingDataSet = new LakesideEscapesPodBooking.tblBookingDataSet();
            this.tblBookingTableAdapter = new LakesideEscapesPodBooking.tblBookingDataSetTableAdapters.tblBookingTableAdapter();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfOccupantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositPayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendingCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetails.SuspendLayout();
            this.pnlBookingID.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(13, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 32);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDetails.Controls.Add(this.lblErrorPodID);
            this.pnlDetails.Controls.Add(this.dtpEnd);
            this.pnlDetails.Controls.Add(this.dtpStart);
            this.pnlDetails.Controls.Add(this.btnSearchDate);
            this.pnlDetails.Controls.Add(this.lblEnd);
            this.pnlDetails.Controls.Add(this.lblStart);
            this.pnlDetails.Controls.Add(this.btnClear2);
            this.pnlDetails.Controls.Add(this.lblPodID);
            this.pnlDetails.Controls.Add(this.txtboxPodID);
            this.pnlDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDetails.Location = new System.Drawing.Point(136, 160);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(488, 150);
            this.pnlDetails.TabIndex = 97;
            // 
            // lblErrorPodID
            // 
            this.lblErrorPodID.AutoSize = true;
            this.lblErrorPodID.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPodID.Location = new System.Drawing.Point(105, 128);
            this.lblErrorPodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorPodID.Name = "lblErrorPodID";
            this.lblErrorPodID.Size = new System.Drawing.Size(0, 16);
            this.lblErrorPodID.TabIndex = 95;
            this.lblErrorPodID.Visible = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(161, 95);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(135, 23);
            this.dtpEnd.TabIndex = 94;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(161, 62);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(135, 23);
            this.dtpStart.TabIndex = 93;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(361, 80);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(94, 44);
            this.btnSearchDate.TabIndex = 92;
            this.btnSearchDate.Text = "SEARCH";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(82, 94);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(54, 16);
            this.lblEnd.TabIndex = 91;
            this.lblEnd.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(80, 62);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(58, 16);
            this.lblStart.TabIndex = 90;
            this.lblStart.Text = "Start Date";
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(361, 29);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(94, 44);
            this.btnClear2.TabIndex = 3;
            this.btnClear2.Text = "CLEAR";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // lblPodID
            // 
            this.lblPodID.AutoSize = true;
            this.lblPodID.Location = new System.Drawing.Point(79, 31);
            this.lblPodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodID.Name = "lblPodID";
            this.lblPodID.Size = new System.Drawing.Size(42, 16);
            this.lblPodID.TabIndex = 1;
            this.lblPodID.Text = "Pod ID";
            // 
            // txtboxPodID
            // 
            this.txtboxPodID.Location = new System.Drawing.Point(161, 29);
            this.txtboxPodID.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxPodID.Name = "txtboxPodID";
            this.txtboxPodID.Size = new System.Drawing.Size(135, 23);
            this.txtboxPodID.TabIndex = 0;
            // 
            // pnlBookingID
            // 
            this.pnlBookingID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBookingID.Controls.Add(this.btnClear);
            this.pnlBookingID.Controls.Add(this.btnSearch);
            this.pnlBookingID.Controls.Add(this.lblBookingID);
            this.pnlBookingID.Controls.Add(this.lblError);
            this.pnlBookingID.Controls.Add(this.txtboxBookingID);
            this.pnlBookingID.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBookingID.Location = new System.Drawing.Point(136, 160);
            this.pnlBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBookingID.Name = "pnlBookingID";
            this.pnlBookingID.Size = new System.Drawing.Size(488, 150);
            this.pnlBookingID.TabIndex = 96;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(357, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 44);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(357, 84);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(82, 37);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(65, 16);
            this.lblBookingID.TabIndex = 1;
            this.lblBookingID.Text = "Booking ID";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(36, 107);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(55, 19);
            this.lblError.TabIndex = 88;
            this.lblError.Text = "ERROR";
            this.lblError.Visible = false;
            // 
            // txtboxBookingID
            // 
            this.txtboxBookingID.Location = new System.Drawing.Point(164, 35);
            this.txtboxBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxBookingID.Name = "txtboxBookingID";
            this.txtboxBookingID.Size = new System.Drawing.Size(135, 23);
            this.txtboxBookingID.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContainer.Controls.Add(this.btnBookingID);
            this.pnlContainer.Controls.Add(this.btnDetails);
            this.pnlContainer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContainer.Location = new System.Drawing.Point(136, 114);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(488, 51);
            this.pnlContainer.TabIndex = 98;
            // 
            // btnBookingID
            // 
            this.btnBookingID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookingID.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBookingID.FlatAppearance.BorderSize = 0;
            this.btnBookingID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingID.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingID.Location = new System.Drawing.Point(0, 0);
            this.btnBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookingID.Name = "btnBookingID";
            this.btnBookingID.Size = new System.Drawing.Size(171, 51);
            this.btnBookingID.TabIndex = 92;
            this.btnBookingID.Text = "Booking ID";
            this.btnBookingID.UseVisualStyleBackColor = false;
            this.btnBookingID.Click += new System.EventHandler(this.btnBookingID_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Location = new System.Drawing.Point(302, 0);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(186, 51);
            this.btnDetails.TabIndex = 93;
            this.btnDetails.Text = "Pod Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.AutoGenerateColumns = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.bookingStartDateDataGridViewTextBoxColumn,
            this.bookingEndDateDataGridViewTextBoxColumn,
            this.noOfOccupantsDataGridViewTextBoxColumn,
            this.depositPayedDataGridViewTextBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.attendingCourseDataGridViewTextBoxColumn,
            this.podIDDataGridViewTextBoxColumn,
            this.dateBookedDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dgvBooking.DataSource = this.tblBookingBindingSource;
            this.dgvBooking.Location = new System.Drawing.Point(28, 356);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 62;
            this.dgvBooking.RowTemplate.Height = 28;
            this.dgvBooking.Size = new System.Drawing.Size(780, 208);
            this.dgvBooking.TabIndex = 99;
            // 
            // tblBookingBindingSource
            // 
            this.tblBookingBindingSource.DataMember = "tblBooking";
            this.tblBookingBindingSource.DataSource = this.tblBookingDataSet;
            // 
            // tblBookingDataSet
            // 
            this.tblBookingDataSet.DataSetName = "tblBookingDataSet";
            this.tblBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBookingTableAdapter
            // 
            this.tblBookingTableAdapter.ClearBeforeFill = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(265, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(192, 34);
            this.lblHeader.TabIndex = 100;
            this.lblHeader.Text = "View Booking";
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking ID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookingStartDateDataGridViewTextBoxColumn
            // 
            this.bookingStartDateDataGridViewTextBoxColumn.DataPropertyName = "BookingStartDate";
            this.bookingStartDateDataGridViewTextBoxColumn.HeaderText = "Booking Start Date";
            this.bookingStartDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookingStartDateDataGridViewTextBoxColumn.Name = "bookingStartDateDataGridViewTextBoxColumn";
            this.bookingStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingStartDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookingEndDateDataGridViewTextBoxColumn
            // 
            this.bookingEndDateDataGridViewTextBoxColumn.DataPropertyName = "BookingEndDate";
            this.bookingEndDateDataGridViewTextBoxColumn.HeaderText = "Booking End Date";
            this.bookingEndDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookingEndDateDataGridViewTextBoxColumn.Name = "bookingEndDateDataGridViewTextBoxColumn";
            this.bookingEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingEndDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // noOfOccupantsDataGridViewTextBoxColumn
            // 
            this.noOfOccupantsDataGridViewTextBoxColumn.DataPropertyName = "NoOfOccupants";
            this.noOfOccupantsDataGridViewTextBoxColumn.HeaderText = "Number Of Occupants";
            this.noOfOccupantsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noOfOccupantsDataGridViewTextBoxColumn.Name = "noOfOccupantsDataGridViewTextBoxColumn";
            this.noOfOccupantsDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfOccupantsDataGridViewTextBoxColumn.Width = 150;
            // 
            // depositPayedDataGridViewTextBoxColumn
            // 
            this.depositPayedDataGridViewTextBoxColumn.DataPropertyName = "DepositPaid";
            this.depositPayedDataGridViewTextBoxColumn.HeaderText = "Deposit Paid";
            this.depositPayedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.depositPayedDataGridViewTextBoxColumn.Name = "depositPayedDataGridViewTextBoxColumn";
            this.depositPayedDataGridViewTextBoxColumn.ReadOnly = true;
            this.depositPayedDataGridViewTextBoxColumn.Width = 150;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "Guest ID";
            this.guestIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // attendingCourseDataGridViewTextBoxColumn
            // 
            this.attendingCourseDataGridViewTextBoxColumn.DataPropertyName = "AttendingCourse";
            this.attendingCourseDataGridViewTextBoxColumn.HeaderText = "Attending Course";
            this.attendingCourseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attendingCourseDataGridViewTextBoxColumn.Name = "attendingCourseDataGridViewTextBoxColumn";
            this.attendingCourseDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendingCourseDataGridViewTextBoxColumn.Width = 150;
            // 
            // podIDDataGridViewTextBoxColumn
            // 
            this.podIDDataGridViewTextBoxColumn.DataPropertyName = "PodID";
            this.podIDDataGridViewTextBoxColumn.HeaderText = "Pod ID";
            this.podIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.podIDDataGridViewTextBoxColumn.Name = "podIDDataGridViewTextBoxColumn";
            this.podIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.podIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateBookedDataGridViewTextBoxColumn
            // 
            this.dateBookedDataGridViewTextBoxColumn.DataPropertyName = "DateBooked";
            this.dateBookedDataGridViewTextBoxColumn.HeaderText = "Date Booked";
            this.dateBookedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateBookedDataGridViewTextBoxColumn.Name = "dateBookedDataGridViewTextBoxColumn";
            this.dateBookedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateBookedDataGridViewTextBoxColumn.Width = 150;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(838, 596);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlBookingID);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormViewBookings";
            this.Text = "FormViewBookings";
            this.Load += new System.EventHandler(this.FormViewBookings_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlBookingID.ResumeLayout(false);
            this.pnlBookingID.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label lblPodID;
        private System.Windows.Forms.TextBox txtboxPodID;
        private System.Windows.Forms.Panel pnlBookingID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtboxBookingID;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnBookingID;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView dgvBooking;
        private tblBookingDataSet tblBookingDataSet;
        private System.Windows.Forms.BindingSource tblBookingBindingSource;
        private tblBookingDataSetTableAdapters.tblBookingTableAdapter tblBookingTableAdapter;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label lblErrorPodID;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfOccupantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositPayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendingCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBookedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}