namespace LakesideEscapesPodBooking
{
    partial class FormViewPod
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnViewPod = new System.Windows.Forms.Button();
            this.cbPodID = new System.Windows.Forms.ComboBox();
            this.lblPodID = new System.Windows.Forms.Label();
            this.dgvPod = new System.Windows.Forms.DataGridView();
            this.podIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTblPodDataSet = new LakesideEscapesPodBooking.ViewTblPodDataSet();
            this.tblPodTableAdapter = new LakesideEscapesPodBooking.ViewTblPodDataSetTableAdapters.tblPodTableAdapter();
            this.dgvPodDescription = new System.Windows.Forms.DataGridView();
            this.podTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podDesriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxOccupancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPodDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPodDescriptionDataSet = new LakesideEscapesPodBooking.tblPodDescriptionDataSet();
            this.tblPodDescriptionTableAdapter = new LakesideEscapesPodBooking.tblPodDescriptionDataSetTableAdapters.tblPodDescriptionTableAdapter();
            this.dgvAllPod = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTblPodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodDescriptionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPod)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(321, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(136, 34);
            this.lblHeader.TabIndex = 44;
            this.lblHeader.Text = "View Pod";
            // 
            // btnViewPod
            // 
            this.btnViewPod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPod.Location = new System.Drawing.Point(273, 174);
            this.btnViewPod.Name = "btnViewPod";
            this.btnViewPod.Size = new System.Drawing.Size(95, 33);
            this.btnViewPod.TabIndex = 62;
            this.btnViewPod.Text = "VIEW";
            this.btnViewPod.UseVisualStyleBackColor = true;
            this.btnViewPod.Click += new System.EventHandler(this.btnAddPod_Click);
            // 
            // cbPodID
            // 
            this.cbPodID.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPodID.FormattingEnabled = true;
            this.cbPodID.Location = new System.Drawing.Point(346, 122);
            this.cbPodID.Name = "cbPodID";
            this.cbPodID.Size = new System.Drawing.Size(121, 24);
            this.cbPodID.TabIndex = 65;
            // 
            // lblPodID
            // 
            this.lblPodID.AutoSize = true;
            this.lblPodID.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodID.ForeColor = System.Drawing.Color.White;
            this.lblPodID.Location = new System.Drawing.Point(269, 122);
            this.lblPodID.Name = "lblPodID";
            this.lblPodID.Size = new System.Drawing.Size(54, 19);
            this.lblPodID.TabIndex = 64;
            this.lblPodID.Text = "Pod ID";
            // 
            // dgvPod
            // 
            this.dgvPod.AutoGenerateColumns = false;
            this.dgvPod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.podIDDataGridViewTextBoxColumn,
            this.podTypeDataGridViewTextBoxColumn});
            this.dgvPod.DataSource = this.tblPodBindingSource;
            this.dgvPod.Location = new System.Drawing.Point(194, 355);
            this.dgvPod.Name = "dgvPod";
            this.dgvPod.ReadOnly = true;
            this.dgvPod.RowHeadersWidth = 62;
            this.dgvPod.Size = new System.Drawing.Size(363, 163);
            this.dgvPod.TabIndex = 66;
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
            // podTypeDataGridViewTextBoxColumn
            // 
            this.podTypeDataGridViewTextBoxColumn.DataPropertyName = "PodType";
            this.podTypeDataGridViewTextBoxColumn.HeaderText = "Pod Type";
            this.podTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.podTypeDataGridViewTextBoxColumn.Name = "podTypeDataGridViewTextBoxColumn";
            this.podTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.podTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblPodBindingSource
            // 
            this.tblPodBindingSource.DataMember = "tblPod";
            this.tblPodBindingSource.DataSource = this.viewTblPodDataSet;
            // 
            // viewTblPodDataSet
            // 
            this.viewTblPodDataSet.DataSetName = "ViewTblPodDataSet";
            this.viewTblPodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPodTableAdapter
            // 
            this.tblPodTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPodDescription
            // 
            this.dgvPodDescription.AutoGenerateColumns = false;
            this.dgvPodDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodDescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.podTypeDataGridViewTextBoxColumn1,
            this.podDesriptionDataGridViewTextBoxColumn,
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn,
            this.maxOccupancyDataGridViewTextBoxColumn});
            this.dgvPodDescription.DataSource = this.tblPodDescriptionBindingSource;
            this.dgvPodDescription.Location = new System.Drawing.Point(77, 239);
            this.dgvPodDescription.Name = "dgvPodDescription";
            this.dgvPodDescription.ReadOnly = true;
            this.dgvPodDescription.RowHeadersWidth = 62;
            this.dgvPodDescription.Size = new System.Drawing.Size(658, 110);
            this.dgvPodDescription.TabIndex = 67;
            // 
            // podTypeDataGridViewTextBoxColumn1
            // 
            this.podTypeDataGridViewTextBoxColumn1.DataPropertyName = "PodType";
            this.podTypeDataGridViewTextBoxColumn1.HeaderText = "Pod Type";
            this.podTypeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.podTypeDataGridViewTextBoxColumn1.Name = "podTypeDataGridViewTextBoxColumn1";
            this.podTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.podTypeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // podDesriptionDataGridViewTextBoxColumn
            // 
            this.podDesriptionDataGridViewTextBoxColumn.DataPropertyName = "PodDesription";
            this.podDesriptionDataGridViewTextBoxColumn.HeaderText = "Pod Desription";
            this.podDesriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.podDesriptionDataGridViewTextBoxColumn.Name = "podDesriptionDataGridViewTextBoxColumn";
            this.podDesriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.podDesriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // podCostPerPersonPerNightDataGridViewTextBoxColumn
            // 
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn.DataPropertyName = "PodCostPerPersonPerNight";
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn.HeaderText = "Cost Per Person Per Night";
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn.Name = "podCostPerPersonPerNightDataGridViewTextBoxColumn";
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn.ReadOnly = true;
            this.podCostPerPersonPerNightDataGridViewTextBoxColumn.Width = 150;
            // 
            // maxOccupancyDataGridViewTextBoxColumn
            // 
            this.maxOccupancyDataGridViewTextBoxColumn.DataPropertyName = "MaxOccupancy";
            this.maxOccupancyDataGridViewTextBoxColumn.HeaderText = "Maximum Occupancy";
            this.maxOccupancyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxOccupancyDataGridViewTextBoxColumn.Name = "maxOccupancyDataGridViewTextBoxColumn";
            this.maxOccupancyDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxOccupancyDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblPodDescriptionBindingSource
            // 
            this.tblPodDescriptionBindingSource.DataMember = "tblPodDescription";
            this.tblPodDescriptionBindingSource.DataSource = this.tblPodDescriptionDataSet;
            // 
            // tblPodDescriptionDataSet
            // 
            this.tblPodDescriptionDataSet.DataSetName = "tblPodDescriptionDataSet";
            this.tblPodDescriptionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPodDescriptionTableAdapter
            // 
            this.tblPodDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAllPod
            // 
            this.dgvAllPod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPod.Location = new System.Drawing.Point(22, 239);
            this.dgvAllPod.Name = "dgvAllPod";
            this.dgvAllPod.ReadOnly = true;
            this.dgvAllPod.RowHeadersWidth = 62;
            this.dgvAllPod.Size = new System.Drawing.Size(814, 110);
            this.dgvAllPod.TabIndex = 68;
            this.dgvAllPod.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(391, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 33);
            this.btnClear.TabIndex = 69;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(27, 30);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 34);
            this.btnExit.TabIndex = 83;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(540, 127);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(195, 19);
            this.lblError.TabIndex = 88;
            this.lblError.Text = "This is an invalid Booking ID";
            this.lblError.Visible = false;
            // 
            // FormViewPod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(848, 524);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvAllPod);
            this.Controls.Add(this.dgvPodDescription);
            this.Controls.Add(this.dgvPod);
            this.Controls.Add(this.cbPodID);
            this.Controls.Add(this.lblPodID);
            this.Controls.Add(this.btnViewPod);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewPod";
            this.Text = "FormViewPod";
            this.Load += new System.EventHandler(this.FormViewPod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTblPodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPodDescriptionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnViewPod;
        private System.Windows.Forms.ComboBox cbPodID;
        private System.Windows.Forms.Label lblPodID;
        private System.Windows.Forms.DataGridView dgvPod;
        private ViewTblPodDataSet viewTblPodDataSet;
        private System.Windows.Forms.BindingSource tblPodBindingSource;
        private ViewTblPodDataSetTableAdapters.tblPodTableAdapter tblPodTableAdapter;
        private System.Windows.Forms.DataGridView dgvPodDescription;
        private tblPodDescriptionDataSet tblPodDescriptionDataSet;
        private System.Windows.Forms.BindingSource tblPodDescriptionBindingSource;
        private tblPodDescriptionDataSetTableAdapters.tblPodDescriptionTableAdapter tblPodDescriptionTableAdapter;
        private System.Windows.Forms.DataGridView dgvAllPod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn podIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn podDesriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podCostPerPersonPerNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxOccupancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblError;
    }
}