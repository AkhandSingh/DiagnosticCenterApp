namespace ADC
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            ToolStripHome = new ToolStrip();
            ToolStripDoctor = new ToolStripButton();
            ToolStripPatient = new ToolStripButton();
            ToolStripPrintPatientReceipt = new ToolStripButton();
            ToolStripPrintMonthlyPatientReport = new ToolStripButton();
            ToolStripPrintMonthlyPatientCMOReport = new ToolStripButton();
            ToolStripSettings = new ToolStripButton();
            HomePanel = new Panel();
            LblHomeMainText = new Label();
            label1 = new Label();
            ToolStripHome.SuspendLayout();
            HomePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripHome
            // 
            ToolStripHome.AutoSize = false;
            ToolStripHome.BackColor = SystemColors.GradientInactiveCaption;
            ToolStripHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ToolStripHome.ImageScalingSize = new Size(20, 20);
            ToolStripHome.Items.AddRange(new ToolStripItem[] { ToolStripDoctor, ToolStripPatient, ToolStripPrintPatientReceipt, ToolStripPrintMonthlyPatientReport, ToolStripPrintMonthlyPatientCMOReport, ToolStripSettings });
            ToolStripHome.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ToolStripHome.Location = new Point(0, 0);
            ToolStripHome.Name = "ToolStripHome";
            ToolStripHome.Size = new Size(1008, 46);
            ToolStripHome.Stretch = true;
            ToolStripHome.TabIndex = 0;
            // 
            // ToolStripDoctor
            // 
            ToolStripDoctor.BackColor = SystemColors.Highlight;
            ToolStripDoctor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripDoctor.ForeColor = SystemColors.ButtonHighlight;
            ToolStripDoctor.ImageTransparentColor = Color.Magenta;
            ToolStripDoctor.Name = "ToolStripDoctor";
            ToolStripDoctor.Size = new Size(91, 43);
            ToolStripDoctor.Text = "Add Doctor";
            ToolStripDoctor.Click += ToolStripDoctor_Click;
            // 
            // ToolStripPatient
            // 
            ToolStripPatient.BackColor = SystemColors.Highlight;
            ToolStripPatient.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripPatient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToolStripPatient.ForeColor = SystemColors.ButtonHighlight;
            ToolStripPatient.ImageTransparentColor = Color.Magenta;
            ToolStripPatient.Name = "ToolStripPatient";
            ToolStripPatient.Size = new Size(92, 43);
            ToolStripPatient.Text = "Add Patient";
            ToolStripPatient.Click += ToolStripPatient_Click;
            // 
            // ToolStripPrintPatientReceipt
            // 
            ToolStripPrintPatientReceipt.BackColor = SystemColors.Highlight;
            ToolStripPrintPatientReceipt.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripPrintPatientReceipt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToolStripPrintPatientReceipt.ForeColor = SystemColors.ButtonHighlight;
            ToolStripPrintPatientReceipt.ImageTransparentColor = Color.Magenta;
            ToolStripPrintPatientReceipt.Name = "ToolStripPrintPatientReceipt";
            ToolStripPrintPatientReceipt.Size = new Size(99, 43);
            ToolStripPrintPatientReceipt.Text = "Print Receipt";
            ToolStripPrintPatientReceipt.Click += ToolStripPrintPatientReceipt_Click;
            // 
            // ToolStripPrintMonthlyPatientReport
            // 
            ToolStripPrintMonthlyPatientReport.BackColor = SystemColors.Highlight;
            ToolStripPrintMonthlyPatientReport.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripPrintMonthlyPatientReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToolStripPrintMonthlyPatientReport.ForeColor = SystemColors.ButtonHighlight;
            ToolStripPrintMonthlyPatientReport.ImageTransparentColor = Color.Magenta;
            ToolStripPrintMonthlyPatientReport.Name = "ToolStripPrintMonthlyPatientReport";
            ToolStripPrintMonthlyPatientReport.Size = new Size(205, 43);
            ToolStripPrintMonthlyPatientReport.Text = "Print Monthly Patient Report";
            ToolStripPrintMonthlyPatientReport.Click += ToolStripPrintMonthlyPatientReport_Click;
            // 
            // ToolStripPrintMonthlyPatientCMOReport
            // 
            ToolStripPrintMonthlyPatientCMOReport.BackColor = SystemColors.Highlight;
            ToolStripPrintMonthlyPatientCMOReport.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripPrintMonthlyPatientCMOReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToolStripPrintMonthlyPatientCMOReport.ForeColor = SystemColors.ButtonHighlight;
            ToolStripPrintMonthlyPatientCMOReport.ImageTransparentColor = Color.Magenta;
            ToolStripPrintMonthlyPatientCMOReport.Name = "ToolStripPrintMonthlyPatientCMOReport";
            ToolStripPrintMonthlyPatientCMOReport.Size = new Size(252, 43);
            ToolStripPrintMonthlyPatientCMOReport.Text = "Print Monthly Patient Report (CMO)";
            ToolStripPrintMonthlyPatientCMOReport.Click += ToolStripPrintMonthlyPatientCMOReport_Click;
            // 
            // ToolStripSettings
            // 
            ToolStripSettings.BackColor = SystemColors.Highlight;
            ToolStripSettings.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToolStripSettings.ForeColor = SystemColors.ButtonHighlight;
            ToolStripSettings.ImageTransparentColor = Color.Magenta;
            ToolStripSettings.Name = "ToolStripSettings";
            ToolStripSettings.Size = new Size(66, 43);
            ToolStripSettings.Text = "Settings";
            // 
            // HomePanel
            // 
            HomePanel.AutoSize = true;
            HomePanel.BackColor = SystemColors.ActiveCaptionText;
            HomePanel.Controls.Add(LblHomeMainText);
            HomePanel.ForeColor = Color.Cornsilk;
            HomePanel.Location = new Point(143, 341);
            HomePanel.Margin = new Padding(3, 2, 3, 2);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(675, 70);
            HomePanel.TabIndex = 1;
            // 
            // LblHomeMainText
            // 
            LblHomeMainText.AutoSize = true;
            LblHomeMainText.Font = new Font("Segoe UI Black", 30F, FontStyle.Italic);
            LblHomeMainText.Location = new Point(32, 5);
            LblHomeMainText.Name = "LblHomeMainText";
            LblHomeMainText.Size = new Size(610, 54);
            LblHomeMainText.TabIndex = 0;
            LblHomeMainText.Text = "ARUSHI DIAGNOSTIC CENTER";
            // 
            // label1
            // 
            label1.Image = Properties.Resources.ADCLogo;
            label1.Location = new Point(371, 177);
            label1.Name = "label1";
            label1.Size = new Size(192, 121);
            label1.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1008, 729);
            Controls.Add(label1);
            Controls.Add(HomePanel);
            Controls.Add(ToolStripHome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeForm";
            Text = "Arushi Diagnostic Center";
            ToolStripHome.ResumeLayout(false);
            ToolStripHome.PerformLayout();
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripHome;
        private ToolStripButton ToolStripDoctor;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private Panel HomePanel;
        private Label LblHomeMainText;
        private ToolStripButton ToolStripPrintPatientReceipt;
        private ToolStripButton ToolStripPatient;
        private ToolStripButton ToolStripPrintMonthlyPatientReport;
        private ToolStripButton ToolStripPrintMonthlyPatientCMOReport;
        private ToolStripButton ToolStripSettings;
        private Label label1;
    }
}
