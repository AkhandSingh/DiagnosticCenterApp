namespace ADC
{
    partial class MonthlyPatientReports
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
            BtnSearch = new Button();
            TxtDoctor = new TextBox();
            BtnPrint = new Button();
            LblStartDate = new Label();
            panel1 = new Panel();
            LblDoctor = new Label();
            DtpEndDate = new DateTimePicker();
            DtpStartDate = new DateTimePicker();
            LblEndDate = new Label();
            DtvMonthlyPatientReport = new DataGridView();
            DiagnosticDate = new DataGridViewTextBoxColumn();
            ReferredBy = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            DiagnosticCategory = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtvMonthlyPatientReport).BeginInit();
            SuspendLayout();
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(1062, 28);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(102, 29);
            BtnSearch.TabIndex = 35;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtDoctor
            // 
            TxtDoctor.Location = new Point(882, 29);
            TxtDoctor.Name = "TxtDoctor";
            TxtDoctor.Size = new Size(166, 27);
            TxtDoctor.TabIndex = 34;
            // 
            // BtnPrint
            // 
            BtnPrint.Enabled = false;
            BtnPrint.Location = new Point(1271, 27);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(102, 29);
            BtnPrint.TabIndex = 33;
            BtnPrint.Text = "Print Receipt";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // LblStartDate
            // 
            LblStartDate.AutoSize = true;
            LblStartDate.Location = new Point(39, 25);
            LblStartDate.Name = "LblStartDate";
            LblStartDate.Size = new Size(79, 20);
            LblStartDate.TabIndex = 32;
            LblStartDate.Text = "Start Date:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(LblDoctor);
            panel1.Controls.Add(LblStartDate);
            panel1.Controls.Add(DtpEndDate);
            panel1.Controls.Add(DtpStartDate);
            panel1.Controls.Add(LblEndDate);
            panel1.Controls.Add(TxtDoctor);
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(BtnPrint);
            panel1.Location = new Point(41, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1404, 83);
            panel1.TabIndex = 36;
            // 
            // LblDoctor
            // 
            LblDoctor.AutoSize = true;
            LblDoctor.Location = new Point(818, 28);
            LblDoctor.Name = "LblDoctor";
            LblDoctor.Size = new Size(58, 20);
            LblDoctor.TabIndex = 39;
            LblDoctor.Text = "Doctor:";
            // 
            // DtpEndDate
            // 
            DtpEndDate.Location = new Point(504, 27);
            DtpEndDate.Name = "DtpEndDate";
            DtpEndDate.Size = new Size(250, 27);
            DtpEndDate.TabIndex = 38;
            // 
            // DtpStartDate
            // 
            DtpStartDate.Location = new Point(124, 25);
            DtpStartDate.Name = "DtpStartDate";
            DtpStartDate.Size = new Size(250, 27);
            DtpStartDate.TabIndex = 36;
            // 
            // LblEndDate
            // 
            LblEndDate.AutoSize = true;
            LblEndDate.Location = new Point(425, 28);
            LblEndDate.Name = "LblEndDate";
            LblEndDate.Size = new Size(73, 20);
            LblEndDate.TabIndex = 37;
            LblEndDate.Text = "End Date:";
            // 
            // DtvMonthlyPatientReport
            // 
            DtvMonthlyPatientReport.ColumnHeadersHeight = 29;
            DtvMonthlyPatientReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DtvMonthlyPatientReport.Columns.AddRange(new DataGridViewColumn[] { DiagnosticDate, ReferredBy, PatientName, DiagnosticCategory, Amount });
            DtvMonthlyPatientReport.Location = new Point(321, 239);
            DtvMonthlyPatientReport.Name = "DtvMonthlyPatientReport";
            DtvMonthlyPatientReport.RowHeadersWidth = 51;
            DtvMonthlyPatientReport.Size = new Size(827, 188);
            DtvMonthlyPatientReport.TabIndex = 37;
            // 
            // DiagnosticDate
            // 
            DiagnosticDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DiagnosticDate.HeaderText = "DATE";
            DiagnosticDate.MinimumWidth = 100;
            DiagnosticDate.Name = "DiagnosticDate";
            DiagnosticDate.Resizable = DataGridViewTriState.False;
            DiagnosticDate.Width = 125;
            // 
            // ReferredBy
            // 
            ReferredBy.HeaderText = "DR NAME";
            ReferredBy.MinimumWidth = 6;
            ReferredBy.Name = "ReferredBy";
            ReferredBy.Width = 200;
            // 
            // PatientName
            // 
            PatientName.HeaderText = "PATIENT NAME";
            PatientName.MinimumWidth = 6;
            PatientName.Name = "PatientName";
            PatientName.Width = 200;
            // 
            // DiagnosticCategory
            // 
            DiagnosticCategory.HeaderText = "DIAGNOSTIC";
            DiagnosticCategory.MinimumWidth = 6;
            DiagnosticCategory.Name = "DiagnosticCategory";
            DiagnosticCategory.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "AMOUNT";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Resizable = DataGridViewTriState.False;
            Amount.Width = 125;
            // 
            // MonthlyPatientReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 650);
            Controls.Add(DtvMonthlyPatientReport);
            Controls.Add(panel1);
            Name = "MonthlyPatientReports";
            Text = "Monthly Patient Report";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtvMonthlyPatientReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSearch;
        private TextBox TxtDoctor;
        private Button BtnPrint;
        private Label LblStartDate;
        private Panel panel1;
        private Label LblDoctor;
        private DateTimePicker DtpEndDate;
        private DateTimePicker DtpStartDate;
        private Label LblEndDate;
        private DataGridView DtvMonthlyPatientReport;
        private DataGridViewTextBoxColumn DiagnosticDate;
        private DataGridViewTextBoxColumn ReferredBy;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn DiagnosticCategory;
        private DataGridViewTextBoxColumn Amount;
    }
}