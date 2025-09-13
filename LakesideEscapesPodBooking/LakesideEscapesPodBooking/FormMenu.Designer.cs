namespace LakesideEscapesPodBooking
{
    partial class FormMenu
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
            System.Windows.Forms.PictureBox pbMain;
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlPods = new System.Windows.Forms.Panel();
            this.btnEditPod = new System.Windows.Forms.Button();
            this.btnViewPod = new System.Windows.Forms.Button();
            this.btnPods = new System.Windows.Forms.Button();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pnlGuest = new System.Windows.Forms.Panel();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.btnViewGuest = new System.Windows.Forms.Button();
            this.btnCreateGuest = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbTop = new System.Windows.Forms.PictureBox();
            pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbMain)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlPods.SuspendLayout();
            this.pnlBooking.SuspendLayout();
            this.pnlGuest.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            pbMain.Image = global::LakesideEscapesPodBooking.Properties.Resources.pbMain;
            pbMain.Location = new System.Drawing.Point(140, 125);
            pbMain.Margin = new System.Windows.Forms.Padding(2);
            pbMain.Name = "pbMain";
            pbMain.Size = new System.Drawing.Size(566, 333);
            pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbMain.TabIndex = 0;
            pbMain.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.pnlContainer.Controls.Add(pbMain);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContainer.Location = new System.Drawing.Point(270, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(839, 625);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.pnlSideBar.Controls.Add(this.btnReports);
            this.pnlSideBar.Controls.Add(this.pnlPods);
            this.pnlSideBar.Controls.Add(this.btnPods);
            this.pnlSideBar.Controls.Add(this.pnlBooking);
            this.pnlSideBar.Controls.Add(this.btnBooking);
            this.pnlSideBar.Controls.Add(this.pnlGuest);
            this.pnlSideBar.Controls.Add(this.btnGuest);
            this.pnlSideBar.Controls.Add(this.btnExit);
            this.pnlSideBar.Controls.Add(this.pnlTop);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(259, 625);
            this.pnlSideBar.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LightGray;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(0, 619);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(259, 50);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlPods
            // 
            this.pnlPods.Controls.Add(this.btnEditPod);
            this.pnlPods.Controls.Add(this.btnViewPod);
            this.pnlPods.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPods.Location = new System.Drawing.Point(0, 527);
            this.pnlPods.Name = "pnlPods";
            this.pnlPods.Size = new System.Drawing.Size(259, 92);
            this.pnlPods.TabIndex = 12;
            // 
            // btnEditPod
            // 
            this.btnEditPod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditPod.FlatAppearance.BorderSize = 0;
            this.btnEditPod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPod.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPod.Location = new System.Drawing.Point(0, 45);
            this.btnEditPod.Name = "btnEditPod";
            this.btnEditPod.Size = new System.Drawing.Size(259, 45);
            this.btnEditPod.TabIndex = 6;
            this.btnEditPod.Text = "Add or Edit Pod";
            this.btnEditPod.UseVisualStyleBackColor = false;
            this.btnEditPod.Click += new System.EventHandler(this.btnEditPod_Click);
            // 
            // btnViewPod
            // 
            this.btnViewPod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewPod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewPod.FlatAppearance.BorderSize = 0;
            this.btnViewPod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPod.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPod.Location = new System.Drawing.Point(0, 0);
            this.btnViewPod.Name = "btnViewPod";
            this.btnViewPod.Size = new System.Drawing.Size(259, 45);
            this.btnViewPod.TabIndex = 5;
            this.btnViewPod.Text = "View Pod";
            this.btnViewPod.UseVisualStyleBackColor = false;
            this.btnViewPod.Click += new System.EventHandler(this.btnViewPod_Click);
            // 
            // btnPods
            // 
            this.btnPods.BackColor = System.Drawing.Color.LightGray;
            this.btnPods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPods.FlatAppearance.BorderSize = 0;
            this.btnPods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPods.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPods.ForeColor = System.Drawing.Color.Black;
            this.btnPods.Location = new System.Drawing.Point(0, 477);
            this.btnPods.Name = "btnPods";
            this.btnPods.Size = new System.Drawing.Size(259, 50);
            this.btnPods.TabIndex = 11;
            this.btnPods.Text = "Pods";
            this.btnPods.UseVisualStyleBackColor = false;
            this.btnPods.Click += new System.EventHandler(this.btnPods_Click);
            // 
            // pnlBooking
            // 
            this.pnlBooking.Controls.Add(this.btnEditBooking);
            this.pnlBooking.Controls.Add(this.btnViewBooking);
            this.pnlBooking.Controls.Add(this.btnAddBooking);
            this.pnlBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBooking.Location = new System.Drawing.Point(0, 339);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(259, 138);
            this.pnlBooking.TabIndex = 10;
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditBooking.FlatAppearance.BorderSize = 0;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.Location = new System.Drawing.Point(0, 90);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(259, 45);
            this.btnEditBooking.TabIndex = 5;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewBooking.FlatAppearance.BorderSize = 0;
            this.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooking.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.Location = new System.Drawing.Point(0, 45);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(259, 45);
            this.btnViewBooking.TabIndex = 4;
            this.btnViewBooking.Text = "View Booking";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBooking.FlatAppearance.BorderSize = 0;
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.Location = new System.Drawing.Point(0, 0);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(259, 45);
            this.btnAddBooking.TabIndex = 3;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.LightGray;
            this.btnBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.Location = new System.Drawing.Point(0, 289);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(259, 50);
            this.btnBooking.TabIndex = 9;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // pnlGuest
            // 
            this.pnlGuest.Controls.Add(this.btnEditGuest);
            this.pnlGuest.Controls.Add(this.btnViewGuest);
            this.pnlGuest.Controls.Add(this.btnCreateGuest);
            this.pnlGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGuest.Location = new System.Drawing.Point(0, 149);
            this.pnlGuest.Name = "pnlGuest";
            this.pnlGuest.Size = new System.Drawing.Size(259, 140);
            this.pnlGuest.TabIndex = 8;
            // 
            // btnEditGuest
            // 
            this.btnEditGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditGuest.FlatAppearance.BorderSize = 0;
            this.btnEditGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGuest.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGuest.Location = new System.Drawing.Point(0, 90);
            this.btnEditGuest.Name = "btnEditGuest";
            this.btnEditGuest.Size = new System.Drawing.Size(259, 48);
            this.btnEditGuest.TabIndex = 9;
            this.btnEditGuest.Text = "Edit Guest";
            this.btnEditGuest.UseVisualStyleBackColor = false;
            this.btnEditGuest.Click += new System.EventHandler(this.btnEditGuest_Click);
            // 
            // btnViewGuest
            // 
            this.btnViewGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewGuest.FlatAppearance.BorderSize = 0;
            this.btnViewGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGuest.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGuest.Location = new System.Drawing.Point(0, 45);
            this.btnViewGuest.Name = "btnViewGuest";
            this.btnViewGuest.Size = new System.Drawing.Size(259, 45);
            this.btnViewGuest.TabIndex = 10;
            this.btnViewGuest.Text = "View Guest";
            this.btnViewGuest.UseVisualStyleBackColor = false;
            this.btnViewGuest.Click += new System.EventHandler(this.btnViewGuest_Click);
            // 
            // btnCreateGuest
            // 
            this.btnCreateGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateGuest.FlatAppearance.BorderSize = 0;
            this.btnCreateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGuest.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGuest.Location = new System.Drawing.Point(0, 0);
            this.btnCreateGuest.Name = "btnCreateGuest";
            this.btnCreateGuest.Size = new System.Drawing.Size(259, 45);
            this.btnCreateGuest.TabIndex = 2;
            this.btnCreateGuest.Text = "Create Guest";
            this.btnCreateGuest.UseVisualStyleBackColor = false;
            this.btnCreateGuest.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.LightGray;
            this.btnGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuest.FlatAppearance.BorderSize = 0;
            this.btnGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.Color.Black;
            this.btnGuest.Location = new System.Drawing.Point(0, 99);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(259, 50);
            this.btnGuest.TabIndex = 7;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 580);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(259, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.pnlTop.Controls.Add(this.pbTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(259, 99);
            this.pnlTop.TabIndex = 1;
            // 
            // pbTop
            // 
            this.pbTop.Image = global::LakesideEscapesPodBooking.Properties.Resources.pbHeader1;
            this.pbTop.Location = new System.Drawing.Point(33, 8);
            this.pbTop.Margin = new System.Windows.Forms.Padding(2);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(195, 76);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTop.TabIndex = 0;
            this.pbTop.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1109, 625);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(pbMain)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlPods.ResumeLayout(false);
            this.pnlBooking.ResumeLayout(false);
            this.pnlGuest.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlGuest;
        private System.Windows.Forms.Panel pnlBooking;
        public System.Windows.Forms.Button btnViewBooking;
        public System.Windows.Forms.Button btnAddBooking;
        public System.Windows.Forms.Button btnCreateGuest;
        public System.Windows.Forms.Button btnGuest;
        public System.Windows.Forms.Button btnViewGuest;
        public System.Windows.Forms.Button btnEditGuest;
        public System.Windows.Forms.Button btnBooking;
        public System.Windows.Forms.Button btnEditBooking;
        public System.Windows.Forms.Button btnPods;
        private System.Windows.Forms.Panel pnlPods;
        public System.Windows.Forms.Button btnViewPod;
        public System.Windows.Forms.Button btnEditPod;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbTop;
        public System.Windows.Forms.Button btnReports;
    }
}

