namespace ADC
{
    partial class PatientForm
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
            LblAge = new Label();
            LblSex = new Label();
            TxtMobileNum = new TextBox();
            LblMobile = new Label();
            TxtAddress = new TextBox();
            TxtGaurdian = new TextBox();
            TxtPatientName = new TextBox();
            LblAddress = new Label();
            LblGaurdian = new Label();
            LblName = new Label();
            PnlPatient = new Panel();
            CmbSex = new ComboBox();
            CmbAge = new ComboBox();
            AddDetails = new Button();
            PnlDiagnostic = new Panel();
            LblDiagnosticDate = new Label();
            DtpDiagnosticDate = new DateTimePicker();
            TxtChildren = new TextBox();
            LblChildren = new Label();
            TxtManager = new TextBox();
            LblLenOfPregnency = new Label();
            TxtIndication = new TextBox();
            LblManager = new Label();
            LblIndication = new Label();
            CmbSonologist = new ComboBox();
            TxtAmount = new TextBox();
            LblSonologist = new Label();
            LblAmount = new Label();
            CmbLenOfPregnency = new ComboBox();
            ChkIsPregnent = new CheckBox();
            CmbDiagnosticSubCat = new ComboBox();
            CmbDiagnostic = new ComboBox();
            CmbRefferedBy = new ComboBox();
            LblDiagnosticCategory = new Label();
            LblReferredBy = new Label();
            LblIsPregenent = new Label();
            LblDiagnosticSubCat = new Label();
            BtnSearchByMob = new Button();
            TxtSearchMobileNumber = new TextBox();
            LabelSearchByMob = new Label();
            PnlPatient.SuspendLayout();
            PnlDiagnostic.SuspendLayout();
            SuspendLayout();
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(79, 109);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(36, 20);
            LblAge.TabIndex = 26;
            LblAge.Text = "Age";
            // 
            // LblSex
            // 
            LblSex.AutoSize = true;
            LblSex.Location = new Point(79, 151);
            LblSex.Name = "LblSex";
            LblSex.Size = new Size(32, 20);
            LblSex.TabIndex = 24;
            LblSex.Text = "Sex";
            // 
            // TxtMobileNum
            // 
            TxtMobileNum.Location = new Point(269, 61);
            TxtMobileNum.Name = "TxtMobileNum";
            TxtMobileNum.Size = new Size(234, 27);
            TxtMobileNum.TabIndex = 2;
            // 
            // LblMobile
            // 
            LblMobile.AutoSize = true;
            LblMobile.Location = new Point(79, 61);
            LblMobile.Name = "LblMobile";
            LblMobile.Size = new Size(114, 20);
            LblMobile.TabIndex = 22;
            LblMobile.Text = "Mobile Number";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(269, 233);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(234, 217);
            TxtAddress.TabIndex = 6;
            // 
            // TxtGaurdian
            // 
            TxtGaurdian.Location = new Point(269, 194);
            TxtGaurdian.Name = "TxtGaurdian";
            TxtGaurdian.Size = new Size(234, 27);
            TxtGaurdian.TabIndex = 5;
            // 
            // TxtPatientName
            // 
            TxtPatientName.Location = new Point(269, 14);
            TxtPatientName.Name = "TxtPatientName";
            TxtPatientName.Size = new Size(234, 27);
            TxtPatientName.TabIndex = 1;
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Location = new Point(79, 233);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(62, 20);
            LblAddress.TabIndex = 17;
            LblAddress.Text = "Address";
            // 
            // LblGaurdian
            // 
            LblGaurdian.AutoSize = true;
            LblGaurdian.Location = new Point(79, 194);
            LblGaurdian.Name = "LblGaurdian";
            LblGaurdian.Size = new Size(158, 20);
            LblGaurdian.TabIndex = 16;
            LblGaurdian.Text = "Husband/Father Name";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(79, 14);
            LblName.Name = "LblName";
            LblName.Size = new Size(98, 20);
            LblName.TabIndex = 15;
            LblName.Text = "Patient Name";
            // 
            // PnlPatient
            // 
            PnlPatient.BorderStyle = BorderStyle.FixedSingle;
            PnlPatient.Controls.Add(CmbSex);
            PnlPatient.Controls.Add(CmbAge);
            PnlPatient.Controls.Add(TxtGaurdian);
            PnlPatient.Controls.Add(LblName);
            PnlPatient.Controls.Add(LblAge);
            PnlPatient.Controls.Add(LblGaurdian);
            PnlPatient.Controls.Add(LblAddress);
            PnlPatient.Controls.Add(LblSex);
            PnlPatient.Controls.Add(TxtPatientName);
            PnlPatient.Controls.Add(TxtMobileNum);
            PnlPatient.Controls.Add(TxtAddress);
            PnlPatient.Controls.Add(LblMobile);
            PnlPatient.Location = new Point(63, 76);
            PnlPatient.Name = "PnlPatient";
            PnlPatient.Size = new Size(596, 482);
            PnlPatient.TabIndex = 28;
            // 
            // CmbSex
            // 
            CmbSex.FormattingEnabled = true;
            CmbSex.Items.AddRange(new object[] { "Female", "Male", "Other" });
            CmbSex.Location = new Point(269, 151);
            CmbSex.Name = "CmbSex";
            CmbSex.Size = new Size(86, 28);
            CmbSex.TabIndex = 4;
            // 
            // CmbAge
            // 
            CmbAge.FormattingEnabled = true;
            CmbAge.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            CmbAge.Location = new Point(269, 109);
            CmbAge.Name = "CmbAge";
            CmbAge.Size = new Size(86, 28);
            CmbAge.TabIndex = 3;
            // 
            // AddDetails
            // 
            AddDetails.Location = new Point(1113, 578);
            AddDetails.Name = "AddDetails";
            AddDetails.Size = new Size(249, 29);
            AddDetails.TabIndex = 18;
            AddDetails.Text = "Add Details";
            AddDetails.UseVisualStyleBackColor = true;
            AddDetails.Click += AddDetails_Click;
            // 
            // PnlDiagnostic
            // 
            PnlDiagnostic.BorderStyle = BorderStyle.FixedSingle;
            PnlDiagnostic.Controls.Add(LblDiagnosticDate);
            PnlDiagnostic.Controls.Add(DtpDiagnosticDate);
            PnlDiagnostic.Controls.Add(TxtChildren);
            PnlDiagnostic.Controls.Add(LblChildren);
            PnlDiagnostic.Controls.Add(TxtManager);
            PnlDiagnostic.Controls.Add(LblLenOfPregnency);
            PnlDiagnostic.Controls.Add(TxtIndication);
            PnlDiagnostic.Controls.Add(LblManager);
            PnlDiagnostic.Controls.Add(LblIndication);
            PnlDiagnostic.Controls.Add(CmbSonologist);
            PnlDiagnostic.Controls.Add(TxtAmount);
            PnlDiagnostic.Controls.Add(LblSonologist);
            PnlDiagnostic.Controls.Add(LblAmount);
            PnlDiagnostic.Controls.Add(CmbLenOfPregnency);
            PnlDiagnostic.Controls.Add(ChkIsPregnent);
            PnlDiagnostic.Controls.Add(CmbDiagnosticSubCat);
            PnlDiagnostic.Controls.Add(CmbDiagnostic);
            PnlDiagnostic.Controls.Add(CmbRefferedBy);
            PnlDiagnostic.Controls.Add(LblDiagnosticCategory);
            PnlDiagnostic.Controls.Add(LblReferredBy);
            PnlDiagnostic.Controls.Add(LblIsPregenent);
            PnlDiagnostic.Controls.Add(LblDiagnosticSubCat);
            PnlDiagnostic.Location = new Point(766, 76);
            PnlDiagnostic.Name = "PnlDiagnostic";
            PnlDiagnostic.Size = new Size(596, 482);
            PnlDiagnostic.TabIndex = 31;
            // 
            // LblDiagnosticDate
            // 
            LblDiagnosticDate.AutoSize = true;
            LblDiagnosticDate.Location = new Point(79, 14);
            LblDiagnosticDate.Name = "LblDiagnosticDate";
            LblDiagnosticDate.Size = new Size(116, 20);
            LblDiagnosticDate.TabIndex = 44;
            LblDiagnosticDate.Text = "Diagnostic Date";
            // 
            // DtpDiagnosticDate
            // 
            DtpDiagnosticDate.Location = new Point(274, 14);
            DtpDiagnosticDate.Name = "DtpDiagnosticDate";
            DtpDiagnosticDate.Size = new Size(233, 27);
            DtpDiagnosticDate.TabIndex = 7;
            // 
            // TxtChildren
            // 
            TxtChildren.Location = new Point(276, 384);
            TxtChildren.Name = "TxtChildren";
            TxtChildren.Size = new Size(234, 27);
            TxtChildren.TabIndex = 16;
            TxtChildren.Visible = false;
            // 
            // LblChildren
            // 
            LblChildren.AutoSize = true;
            LblChildren.Location = new Point(79, 387);
            LblChildren.Name = "LblChildren";
            LblChildren.Size = new Size(126, 20);
            LblChildren.TabIndex = 41;
            LblChildren.Text = "Children With Sex";
            LblChildren.Visible = false;
            // 
            // TxtManager
            // 
            TxtManager.Location = new Point(276, 259);
            TxtManager.Name = "TxtManager";
            TxtManager.Size = new Size(234, 27);
            TxtManager.TabIndex = 13;
            // 
            // LblLenOfPregnency
            // 
            LblLenOfPregnency.AutoSize = true;
            LblLenOfPregnency.Location = new Point(79, 345);
            LblLenOfPregnency.Name = "LblLenOfPregnency";
            LblLenOfPregnency.Size = new Size(152, 20);
            LblLenOfPregnency.TabIndex = 16;
            LblLenOfPregnency.Text = "Length of Pregenency";
            LblLenOfPregnency.Visible = false;
            // 
            // TxtIndication
            // 
            TxtIndication.Location = new Point(276, 181);
            TxtIndication.Name = "TxtIndication";
            TxtIndication.Size = new Size(234, 27);
            TxtIndication.TabIndex = 11;
            TxtIndication.Text = "Normal";
            // 
            // LblManager
            // 
            LblManager.AutoSize = true;
            LblManager.Location = new Point(79, 259);
            LblManager.Name = "LblManager";
            LblManager.Size = new Size(68, 20);
            LblManager.TabIndex = 39;
            LblManager.Text = "Manager";
            // 
            // LblIndication
            // 
            LblIndication.AutoSize = true;
            LblIndication.Location = new Point(79, 181);
            LblIndication.Name = "LblIndication";
            LblIndication.Size = new Size(75, 20);
            LblIndication.TabIndex = 35;
            LblIndication.Text = "Indication";
            // 
            // CmbSonologist
            // 
            CmbSonologist.FormattingEnabled = true;
            CmbSonologist.Items.AddRange(new object[] { "Self" });
            CmbSonologist.Location = new Point(276, 423);
            CmbSonologist.Name = "CmbSonologist";
            CmbSonologist.Size = new Size(234, 28);
            CmbSonologist.TabIndex = 17;
            CmbSonologist.Visible = false;
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(276, 223);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(234, 27);
            TxtAmount.TabIndex = 12;
            TxtAmount.Text = "0.00";
            // 
            // LblSonologist
            // 
            LblSonologist.AutoSize = true;
            LblSonologist.Location = new Point(79, 423);
            LblSonologist.Name = "LblSonologist";
            LblSonologist.Size = new Size(80, 20);
            LblSonologist.TabIndex = 33;
            LblSonologist.Text = "Sonologist";
            LblSonologist.Visible = false;
            // 
            // LblAmount
            // 
            LblAmount.AutoSize = true;
            LblAmount.Location = new Point(79, 223);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(62, 20);
            LblAmount.TabIndex = 37;
            LblAmount.Text = "Amount";
            // 
            // CmbLenOfPregnency
            // 
            CmbLenOfPregnency.FormattingEnabled = true;
            CmbLenOfPregnency.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            CmbLenOfPregnency.Location = new Point(276, 345);
            CmbLenOfPregnency.Name = "CmbLenOfPregnency";
            CmbLenOfPregnency.Size = new Size(86, 28);
            CmbLenOfPregnency.TabIndex = 15;
            CmbLenOfPregnency.Visible = false;
            // 
            // ChkIsPregnent
            // 
            ChkIsPregnent.AutoSize = true;
            ChkIsPregnent.Location = new Point(276, 308);
            ChkIsPregnent.Name = "ChkIsPregnent";
            ChkIsPregnent.Size = new Size(18, 17);
            ChkIsPregnent.TabIndex = 14;
            ChkIsPregnent.UseVisualStyleBackColor = true;
            ChkIsPregnent.CheckedChanged += ChkIsPregnent_CheckedChanged;
            // 
            // CmbDiagnosticSubCat
            // 
            CmbDiagnosticSubCat.FormattingEnabled = true;
            CmbDiagnosticSubCat.Location = new Point(274, 96);
            CmbDiagnosticSubCat.Name = "CmbDiagnosticSubCat";
            CmbDiagnosticSubCat.Size = new Size(234, 28);
            CmbDiagnosticSubCat.TabIndex = 9;
            CmbDiagnosticSubCat.Visible = false;
            // 
            // CmbDiagnostic
            // 
            CmbDiagnostic.FormattingEnabled = true;
            CmbDiagnostic.Items.AddRange(new object[] { "USG", "XRAY", "ECG", "PATHOALOGY" });
            CmbDiagnostic.Location = new Point(274, 53);
            CmbDiagnostic.Name = "CmbDiagnostic";
            CmbDiagnostic.Size = new Size(233, 28);
            CmbDiagnostic.TabIndex = 8;
            CmbDiagnostic.SelectedIndexChanged += CmbDiagnostic_SelectedIndexChanged;
            // 
            // CmbRefferedBy
            // 
            CmbRefferedBy.FormattingEnabled = true;
            CmbRefferedBy.Items.AddRange(new object[] { "Self" });
            CmbRefferedBy.Location = new Point(274, 140);
            CmbRefferedBy.Name = "CmbRefferedBy";
            CmbRefferedBy.Size = new Size(234, 28);
            CmbRefferedBy.TabIndex = 10;
            // 
            // LblDiagnosticCategory
            // 
            LblDiagnosticCategory.AutoSize = true;
            LblDiagnosticCategory.Location = new Point(79, 53);
            LblDiagnosticCategory.Name = "LblDiagnosticCategory";
            LblDiagnosticCategory.Size = new Size(144, 20);
            LblDiagnosticCategory.TabIndex = 15;
            LblDiagnosticCategory.Text = "Diagnostic Category";
            // 
            // LblReferredBy
            // 
            LblReferredBy.AutoSize = true;
            LblReferredBy.Location = new Point(79, 140);
            LblReferredBy.Name = "LblReferredBy";
            LblReferredBy.Size = new Size(86, 20);
            LblReferredBy.TabIndex = 26;
            LblReferredBy.Text = "Referred By";
            // 
            // LblIsPregenent
            // 
            LblIsPregenent.AutoSize = true;
            LblIsPregenent.Location = new Point(79, 302);
            LblIsPregenent.Name = "LblIsPregenent";
            LblIsPregenent.Size = new Size(82, 20);
            LblIsPregenent.TabIndex = 24;
            LblIsPregenent.Text = "Is Pregnent";
            // 
            // LblDiagnosticSubCat
            // 
            LblDiagnosticSubCat.AutoSize = true;
            LblDiagnosticSubCat.Location = new Point(79, 96);
            LblDiagnosticSubCat.Name = "LblDiagnosticSubCat";
            LblDiagnosticSubCat.Size = new Size(98, 20);
            LblDiagnosticSubCat.TabIndex = 22;
            LblDiagnosticSubCat.Text = "Sub Category";
            LblDiagnosticSubCat.Visible = false;
            // 
            // BtnSearchByMob
            // 
            BtnSearchByMob.Location = new Point(548, 27);
            BtnSearchByMob.Name = "BtnSearchByMob";
            BtnSearchByMob.Size = new Size(102, 29);
            BtnSearchByMob.TabIndex = 34;
            BtnSearchByMob.Text = "Search";
            BtnSearchByMob.UseVisualStyleBackColor = true;
            BtnSearchByMob.Click += BtnSearchByMob_Click;
            // 
            // TxtSearchMobileNumber
            // 
            TxtSearchMobileNumber.Location = new Point(333, 29);
            TxtSearchMobileNumber.Name = "TxtSearchMobileNumber";
            TxtSearchMobileNumber.Size = new Size(209, 27);
            TxtSearchMobileNumber.TabIndex = 33;
            // 
            // LabelSearchByMob
            // 
            LabelSearchByMob.AutoSize = true;
            LabelSearchByMob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelSearchByMob.Location = new Point(63, 29);
            LabelSearchByMob.Name = "LabelSearchByMob";
            LabelSearchByMob.Size = new Size(196, 20);
            LabelSearchByMob.TabIndex = 32;
            LabelSearchByMob.Text = "Search By Mobile Number:";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 653);
            Controls.Add(BtnSearchByMob);
            Controls.Add(TxtSearchMobileNumber);
            Controls.Add(LabelSearchByMob);
            Controls.Add(PnlDiagnostic);
            Controls.Add(AddDetails);
            Controls.Add(PnlPatient);
            Name = "PatientForm";
            Text = "Patient Diagnostic";
            PnlPatient.ResumeLayout(false);
            PnlPatient.PerformLayout();
            PnlDiagnostic.ResumeLayout(false);
            PnlDiagnostic.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblAge;
        private Label LblSex;
        private TextBox TxtMobileNum;
        private Label LblMobile;
        private TextBox TxtAddress;
        private TextBox TxtGaurdian;
        private TextBox TxtPatientName;
        private Label LblAddress;
        private Label LblGaurdian;
        private Label LblName;
        private Panel PnlPatient;
        private ComboBox CmbAge;
        private ComboBox CmbSex;
        private Button AddDetails;
        private Panel PnlDiagnostic;
        private Label LblManager;
        private TextBox TxtAmount;
        private Label LblAmount;
        private Label LblLenOfPregnency;
        private TextBox TxtIndication;
        private Label LblIndication;
        private ComboBox CmbSonologist;
        private Label LblSonologist;
        private ComboBox CmbLenOfPregnency;
        private CheckBox ChkIsPregnent;
        private ComboBox CmbDiagnosticSubCat;
        private ComboBox CmbDiagnostic;
        private ComboBox CmbRefferedBy;
        private Label LblDiagnosticCategory;
        private Label LblReferredBy;
        private Label LblIsPregenent;
        private Label LblDiagnosticSubCat;
        private TextBox TxtManager;
        private TextBox TxtChildren;
        private Label LblChildren;
        private Label LblDiagnosticDate;
        private DateTimePicker DtpDiagnosticDate;
        private Button BtnSearchByMob;
        private TextBox TxtSearchMobileNumber;
        private Label LabelSearchByMob;
    }
}