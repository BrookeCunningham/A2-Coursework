namespace LakesideEscapesPodBooking
{
    partial class FormAddBooking
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
            this.lblGuestID = new System.Windows.Forms.Label();
            this.txtboxGuestID = new System.Windows.Forms.TextBox();
            this.lblDepositPaid = new System.Windows.Forms.Label();
            this.cbDeposit = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOccupants = new System.Windows.Forms.Label();
            this.txtboxOccupants = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtPend = new System.Windows.Forms.DateTimePicker();
            this.dtPStart = new System.Windows.Forms.DateTimePicker();
            this.lblPodType = new System.Windows.Forms.Label();
            this.cbPodType = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.ForeColor = System.Drawing.Color.White;
            this.lblGuestID.Location = new System.Drawing.Point(127, 124);
            this.lblGuestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(61, 19);
            this.lblGuestID.TabIndex = 56;
            this.lblGuestID.Text = "GuestID";
            // 
            // txtboxGuestID
            // 
            this.txtboxGuestID.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxGuestID.Location = new System.Drawing.Point(211, 119);
            this.txtboxGuestID.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxGuestID.Name = "txtboxGuestID";
            this.txtboxGuestID.Size = new System.Drawing.Size(52, 26);
            this.txtboxGuestID.TabIndex = 55;
            // 
            // lblDepositPaid
            // 
            this.lblDepositPaid.AutoSize = true;
            this.lblDepositPaid.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositPaid.ForeColor = System.Drawing.Color.White;
            this.lblDepositPaid.Location = new System.Drawing.Point(93, 418);
            this.lblDepositPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositPaid.Name = "lblDepositPaid";
            this.lblDepositPaid.Size = new System.Drawing.Size(94, 19);
            this.lblDepositPaid.TabIndex = 54;
            this.lblDepositPaid.Text = "Deposit Paid";
            // 
            // cbDeposit
            // 
            this.cbDeposit.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeposit.FormattingEnabled = true;
            this.cbDeposit.Location = new System.Drawing.Point(211, 418);
            this.cbDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeposit.Name = "cbDeposit";
            this.cbDeposit.Size = new System.Drawing.Size(176, 27);
            this.cbDeposit.TabIndex = 53;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(35, 20);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 45);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(195, 479);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add Booking";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblOccupants
            // 
            this.lblOccupants.AutoSize = true;
            this.lblOccupants.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupants.ForeColor = System.Drawing.Color.White;
            this.lblOccupants.Location = new System.Drawing.Point(42, 271);
            this.lblOccupants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupants.Name = "lblOccupants";
            this.lblOccupants.Size = new System.Drawing.Size(156, 19);
            this.lblOccupants.TabIndex = 50;
            this.lblOccupants.Text = "Number Of Occupants";
            this.lblOccupants.Click += new System.EventHandler(this.lblOccupants_Click);
            // 
            // txtboxOccupants
            // 
            this.txtboxOccupants.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxOccupants.Location = new System.Drawing.Point(211, 268);
            this.txtboxOccupants.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxOccupants.Name = "txtboxOccupants";
            this.txtboxOccupants.Size = new System.Drawing.Size(176, 26);
            this.txtboxOccupants.TabIndex = 49;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(63, 173);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(135, 19);
            this.lblStartDate.TabIndex = 48;
            this.lblStartDate.Text = "Booking Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(69, 222);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(129, 19);
            this.lblEndDate.TabIndex = 47;
            this.lblEndDate.Text = "Booking End Date";
            // 
            // dtPend
            // 
            this.dtPend.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPend.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPend.Location = new System.Drawing.Point(211, 218);
            this.dtPend.Margin = new System.Windows.Forms.Padding(4);
            this.dtPend.Name = "dtPend";
            this.dtPend.Size = new System.Drawing.Size(176, 26);
            this.dtPend.TabIndex = 46;
            // 
            // dtPStart
            // 
            this.dtPStart.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPStart.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPStart.Location = new System.Drawing.Point(211, 168);
            this.dtPStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtPStart.Name = "dtPStart";
            this.dtPStart.Size = new System.Drawing.Size(176, 26);
            this.dtPStart.TabIndex = 45;
            // 
            // lblPodType
            // 
            this.lblPodType.AutoSize = true;
            this.lblPodType.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodType.ForeColor = System.Drawing.Color.White;
            this.lblPodType.Location = new System.Drawing.Point(127, 369);
            this.lblPodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodType.Name = "lblPodType";
            this.lblPodType.Size = new System.Drawing.Size(71, 19);
            this.lblPodType.TabIndex = 44;
            this.lblPodType.Text = "Pod Type";
            // 
            // cbPodType
            // 
            this.cbPodType.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPodType.FormattingEnabled = true;
            this.cbPodType.Location = new System.Drawing.Point(211, 368);
            this.cbPodType.Margin = new System.Windows.Forms.Padding(4);
            this.cbPodType.Name = "cbPodType";
            this.cbPodType.Size = new System.Drawing.Size(176, 27);
            this.cbPodType.TabIndex = 43;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(290, 31);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(213, 34);
            this.lblHeader.TabIndex = 42;
            this.lblHeader.Text = "Create Booking";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.White;
            this.lblCourse.Location = new System.Drawing.Point(74, 320);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(124, 19);
            this.lblCourse.TabIndex = 58;
            this.lblCourse.Text = "Attending Course";
            // 
            // cbCourse
            // 
            this.cbCourse.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(211, 318);
            this.cbCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(176, 27);
            this.cbCourse.TabIndex = 57;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(462, 439);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 19);
            this.lblError.TabIndex = 59;
            this.lblError.Text = "error";
            this.lblError.Visible = false;
            // 
            // lblInfo1
            // 
            this.lblInfo1.ForeColor = System.Drawing.Color.White;
            this.lblInfo1.Location = new System.Drawing.Point(446, 154);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(299, 63);
            this.lblInfo1.TabIndex = 60;
            this.lblInfo1.Text = "Bookings should be made for 3 days (2 Nights), 5 days (4 Nights), 7 days (6 Night" +
    "s) or 14 days (13 Nights)\r\n";
            // 
            // lblInfo2
            // 
            this.lblInfo2.ForeColor = System.Drawing.Color.White;
            this.lblInfo2.Location = new System.Drawing.Point(446, 233);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(304, 40);
            this.lblInfo2.TabIndex = 61;
            this.lblInfo2.Text = "Pods cannot be booked for between the 20th of December and the 20th of January\r\n\r" +
    "\n\r\n";
            // 
            // lblInfo3
            // 
            this.lblInfo3.ForeColor = System.Drawing.Color.White;
            this.lblInfo3.Location = new System.Drawing.Point(446, 289);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(299, 46);
            this.lblInfo3.TabIndex = 62;
            this.lblInfo3.Text = "Deposits must be paid within 3 days of making the booking or the dates will be re" +
    "leased\r\n\r\n\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 27);
            this.label1.TabIndex = 63;
            this.label1.Text = "Bookings must be made two months in advance\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // FormAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(838, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.txtboxGuestID);
            this.Controls.Add(this.lblDepositPaid);
            this.Controls.Add(this.cbDeposit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblOccupants);
            this.Controls.Add(this.txtboxOccupants);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtPend);
            this.Controls.Add(this.dtPStart);
            this.Controls.Add(this.lblPodType);
            this.Controls.Add(this.cbPodType);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddBooking";
            this.Text = "FormAddBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.TextBox txtboxGuestID;
        private System.Windows.Forms.Label lblDepositPaid;
        private System.Windows.Forms.ComboBox cbDeposit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOccupants;
        private System.Windows.Forms.TextBox txtboxOccupants;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtPend;
        private System.Windows.Forms.DateTimePicker dtPStart;
        private System.Windows.Forms.Label lblPodType;
        private System.Windows.Forms.ComboBox cbPodType;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label label1;
    }
}