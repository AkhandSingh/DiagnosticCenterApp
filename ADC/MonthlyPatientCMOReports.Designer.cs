namespace ADC
{
    partial class MonthlyPatientCMOReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyPatientCMOReports));
            BtnSearch = new Button();
            BtnPrint = new Button();
            LblStartDate = new Label();
            panel1 = new Panel();
            DtpEndDate = new DateTimePicker();
            DtpStartDate = new DateTimePicker();
            LblEndDate = new Label();
            DtvMonthlyPatientReport = new DataGridView();
            DiagnosticDate = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gaurdian = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            LengthOfPregnency = new DataGridViewTextBoxColumn();
            Indication = new DataGridViewTextBoxColumn();
            ChildrenWithSex = new DataGridViewTextBoxColumn();
            Sonologist = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtvMonthlyPatientReport).BeginInit();
            SuspendLayout();
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(614, 15);
            BtnSearch.Margin = new Padding(3, 2, 3, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(89, 25);
            BtnSearch.TabIndex = 3;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Enabled = false;
            BtnPrint.Location = new Point(717, 15);
            BtnPrint.Margin = new Padding(3, 2, 3, 2);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(89, 25);
            BtnPrint.TabIndex = 4;
            BtnPrint.Text = "Print Receipt";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // LblStartDate
            // 
            LblStartDate.AutoSize = true;
            LblStartDate.Location = new Point(34, 19);
            LblStartDate.Name = "LblStartDate";
            LblStartDate.Size = new Size(61, 15);
            LblStartDate.TabIndex = 32;
            LblStartDate.Text = "Start Date:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(LblStartDate);
            panel1.Controls.Add(DtpEndDate);
            panel1.Controls.Add(DtpStartDate);
            panel1.Controls.Add(LblEndDate);
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(BtnPrint);
            panel1.Location = new Point(9, 32);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 63);
            panel1.TabIndex = 36;
            // 
            // DtpEndDate
            // 
            DtpEndDate.Location = new Point(373, 16);
            DtpEndDate.Margin = new Padding(3, 2, 3, 2);
            DtpEndDate.Name = "DtpEndDate";
            DtpEndDate.Size = new Size(219, 23);
            DtpEndDate.TabIndex = 2;
            // 
            // DtpStartDate
            // 
            DtpStartDate.Location = new Point(108, 16);
            DtpStartDate.Margin = new Padding(3, 2, 3, 2);
            DtpStartDate.Name = "DtpStartDate";
            DtpStartDate.Size = new Size(161, 23);
            DtpStartDate.TabIndex = 1;
            // 
            // LblEndDate
            // 
            LblEndDate.AutoSize = true;
            LblEndDate.Location = new Point(304, 19);
            LblEndDate.Name = "LblEndDate";
            LblEndDate.Size = new Size(57, 15);
            LblEndDate.TabIndex = 37;
            LblEndDate.Text = "End Date:";
            // 
            // DtvMonthlyPatientReport
            // 
            DtvMonthlyPatientReport.AllowUserToAddRows = false;
            DtvMonthlyPatientReport.AllowUserToDeleteRows = false;
            DtvMonthlyPatientReport.ColumnHeadersHeight = 29;
            DtvMonthlyPatientReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DtvMonthlyPatientReport.Columns.AddRange(new DataGridViewColumn[] { DiagnosticDate, PatientName, Age, Gaurdian, Address, LengthOfPregnency, Indication, ChildrenWithSex, Sonologist });
            DtvMonthlyPatientReport.Location = new Point(10, 146);
            DtvMonthlyPatientReport.Margin = new Padding(3, 2, 3, 2);
            DtvMonthlyPatientReport.Name = "DtvMonthlyPatientReport";
            DtvMonthlyPatientReport.RowHeadersWidth = 51;
            DtvMonthlyPatientReport.Size = new Size(842, 141);
            DtvMonthlyPatientReport.TabIndex = 37;
            // 
            // DiagnosticDate
            // 
            DiagnosticDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DiagnosticDate.HeaderText = "Date";
            DiagnosticDate.MinimumWidth = 100;
            DiagnosticDate.Name = "DiagnosticDate";
            DiagnosticDate.Resizable = DataGridViewTriState.False;
            DiagnosticDate.Width = 125;
            // 
            // PatientName
            // 
            PatientName.HeaderText = "Patient Name";
            PatientName.MinimumWidth = 6;
            PatientName.Name = "PatientName";
            PatientName.Width = 150;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // Gaurdian
            // 
            Gaurdian.HeaderText = "Husband/ Father Name";
            Gaurdian.MinimumWidth = 6;
            Gaurdian.Name = "Gaurdian";
            Gaurdian.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 200;
            // 
            // LengthOfPregnency
            // 
            LengthOfPregnency.HeaderText = "Length of pregnency";
            LengthOfPregnency.MinimumWidth = 6;
            LengthOfPregnency.Name = "LengthOfPregnency";
            LengthOfPregnency.Width = 125;
            // 
            // Indication
            // 
            Indication.HeaderText = "Indication";
            Indication.MinimumWidth = 6;
            Indication.Name = "Indication";
            Indication.Width = 125;
            // 
            // ChildrenWithSex
            // 
            ChildrenWithSex.HeaderText = "No. of children with sex";
            ChildrenWithSex.MinimumWidth = 6;
            ChildrenWithSex.Name = "ChildrenWithSex";
            ChildrenWithSex.Width = 125;
            // 
            // Sonologist
            // 
            Sonologist.HeaderText = "Sonologist";
            Sonologist.MinimumWidth = 6;
            Sonologist.Name = "Sonologist";
            Sonologist.Width = 150;
            // 
            // MonthlyPatientCMOReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(859, 415);
            Controls.Add(DtvMonthlyPatientReport);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MonthlyPatientCMOReports";
            Text = "Monthly Patient Report (CMO)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtvMonthlyPatientReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSearch;
        private Button BtnPrint;
        private Label LblStartDate;
        private Panel panel1;
        private DateTimePicker DtpEndDate;
        private DateTimePicker DtpStartDate;
        private Label LblEndDate;
        private DataGridView DtvMonthlyPatientReport;
        private DataGridViewTextBoxColumn DiagnosticDate;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gaurdian;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn LengthOfPregnency;
        private DataGridViewTextBoxColumn Indication;
        private DataGridViewTextBoxColumn ChildrenWithSex;
        private DataGridViewTextBoxColumn Sonologist;
    }
}