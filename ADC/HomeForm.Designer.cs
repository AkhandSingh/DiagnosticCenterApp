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
            ToolStripHome = new ToolStrip();
            ToolStripDoctor = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            ToolStripPrintPatientReport = new ToolStripButton();
            HomePanel = new Panel();
            LblHomeMainText = new Label();
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
            ToolStripHome.Items.AddRange(new ToolStripItem[] { ToolStripDoctor, toolStripButton1, ToolStripPrintPatientReport });
            ToolStripHome.Location = new Point(0, 0);
            ToolStripHome.Name = "ToolStripHome";
            ToolStripHome.Size = new Size(1482, 50);
            ToolStripHome.Stretch = true;
            ToolStripHome.TabIndex = 0;
            // 
            // ToolStripDoctor
            // 
            ToolStripDoctor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripDoctor.ImageTransparentColor = Color.Magenta;
            ToolStripDoctor.Name = "ToolStripDoctor";
            ToolStripDoctor.Size = new Size(94, 47);
            ToolStripDoctor.Text = "Add Doctor";
            ToolStripDoctor.Click += ToolStripDoctor_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(96, 47);
            toolStripButton1.Text = "Add Patient";
            toolStripButton1.Click += ToolStripPatient_Click;
            // 
            // ToolStripPrintPatientReport
            // 
            ToolStripPrintPatientReport.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripPrintPatientReport.ImageTransparentColor = Color.Magenta;
            ToolStripPrintPatientReport.Name = "ToolStripPrintPatientReport";
            ToolStripPrintPatientReport.Size = new Size(153, 47);
            ToolStripPrintPatientReport.Text = "Print Patient Report";
            ToolStripPrintPatientReport.Click += ToolStripPrintPatientReport_Click;
            // 
            // HomePanel
            // 
            HomePanel.AutoSize = true;
            HomePanel.BackColor = SystemColors.ActiveCaptionText;
            HomePanel.Controls.Add(LblHomeMainText);
            HomePanel.ForeColor = Color.Cornsilk;
            HomePanel.Location = new Point(0, 180);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1316, 93);
            HomePanel.TabIndex = 1;
            // 
            // LblHomeMainText
            // 
            LblHomeMainText.AutoSize = true;
            LblHomeMainText.Font = new Font("Segoe UI Black", 30F, FontStyle.Italic);
            LblHomeMainText.Location = new Point(194, 13);
            LblHomeMainText.Name = "LblHomeMainText";
            LblHomeMainText.Size = new Size(765, 67);
            LblHomeMainText.TabIndex = 0;
            LblHomeMainText.Text = "ARUSHI DIAGNOSTIC CENTRE";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 653);
            Controls.Add(HomePanel);
            Controls.Add(ToolStripHome);
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
        private ToolStripButton ToolStripPrintPatientReport;
        private ToolStripButton toolStripButton1;
    }
}
