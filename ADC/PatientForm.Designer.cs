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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
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
            BtnClear = new Button();
            PnlPatient.SuspendLayout();
            PnlDiagnostic.SuspendLayout();
            SuspendLayout();
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(18, 86);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(28, 15);
            LblAge.TabIndex = 26;
            LblAge.Text = "Age";
            // 
            // LblSex
            // 
            LblSex.AutoSize = true;
            LblSex.Location = new Point(18, 117);
            LblSex.Name = "LblSex";
            LblSex.Size = new Size(25, 15);
            LblSex.TabIndex = 24;
            LblSex.Text = "Sex";
            // 
            // TxtMobileNum
            // 
            TxtMobileNum.Location = new Point(185, 50);
            TxtMobileNum.Margin = new Padding(3, 2, 3, 2);
            TxtMobileNum.Name = "TxtMobileNum";
            TxtMobileNum.Size = new Size(174, 23);
            TxtMobileNum.TabIndex = 2;
            // 
            // LblMobile
            // 
            LblMobile.AutoSize = true;
            LblMobile.Location = new Point(18, 50);
            LblMobile.Name = "LblMobile";
            LblMobile.Size = new Size(91, 15);
            LblMobile.TabIndex = 22;
            LblMobile.Text = "Mobile Number";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(185, 178);
            TxtAddress.Margin = new Padding(3, 2, 3, 2);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(174, 164);
            TxtAddress.TabIndex = 6;
            // 
            // TxtGaurdian
            // 
            TxtGaurdian.Location = new Point(185, 149);
            TxtGaurdian.Margin = new Padding(3, 2, 3, 2);
            TxtGaurdian.Name = "TxtGaurdian";
            TxtGaurdian.Size = new Size(174, 23);
            TxtGaurdian.TabIndex = 5;
            // 
            // TxtPatientName
            // 
            TxtPatientName.Location = new Point(185, 14);
            TxtPatientName.Margin = new Padding(3, 2, 3, 2);
            TxtPatientName.Name = "TxtPatientName";
            TxtPatientName.Size = new Size(174, 23);
            TxtPatientName.TabIndex = 1;
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Location = new Point(18, 178);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(49, 15);
            LblAddress.TabIndex = 17;
            LblAddress.Text = "Address";
            // 
            // LblGaurdian
            // 
            LblGaurdian.AutoSize = true;
            LblGaurdian.Location = new Point(18, 149);
            LblGaurdian.Name = "LblGaurdian";
            LblGaurdian.Size = new Size(128, 15);
            LblGaurdian.TabIndex = 16;
            LblGaurdian.Text = "Husband/Father Name";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(18, 14);
            LblName.Name = "LblName";
            LblName.Size = new Size(79, 15);
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
            PnlPatient.Location = new Point(42, 105);
            PnlPatient.Margin = new Padding(3, 2, 3, 2);
            PnlPatient.Name = "PnlPatient";
            PnlPatient.Size = new Size(387, 362);
            PnlPatient.TabIndex = 28;
            // 
            // CmbSex
            // 
            CmbSex.AutoCompleteCustomSource.AddRange(new string[] { "Female", "Male", "Other" });
            CmbSex.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSex.FormattingEnabled = true;
            CmbSex.Items.AddRange(new object[] { "Female", "Male", "Other" });
            CmbSex.Location = new Point(185, 117);
            CmbSex.Margin = new Padding(3, 2, 3, 2);
            CmbSex.Name = "CmbSex";
            CmbSex.Size = new Size(89, 23);
            CmbSex.TabIndex = 4;
            // 
            // CmbAge
            // 
            CmbAge.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbAge.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbAge.FormattingEnabled = true;
            CmbAge.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            CmbAge.Location = new Point(185, 86);
            CmbAge.Margin = new Padding(3, 2, 3, 2);
            CmbAge.Name = "CmbAge";
            CmbAge.Size = new Size(44, 23);
            CmbAge.TabIndex = 3;
            // 
            // AddDetails
            // 
            AddDetails.Location = new Point(756, 482);
            AddDetails.Margin = new Padding(3, 2, 3, 2);
            AddDetails.Name = "AddDetails";
            AddDetails.Size = new Size(175, 30);
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
            PnlDiagnostic.Location = new Point(497, 105);
            PnlDiagnostic.Margin = new Padding(3, 2, 3, 2);
            PnlDiagnostic.Name = "PnlDiagnostic";
            PnlDiagnostic.Size = new Size(434, 362);
            PnlDiagnostic.TabIndex = 31;
            // 
            // LblDiagnosticDate
            // 
            LblDiagnosticDate.AutoSize = true;
            LblDiagnosticDate.Location = new Point(20, 14);
            LblDiagnosticDate.Name = "LblDiagnosticDate";
            LblDiagnosticDate.Size = new Size(90, 15);
            LblDiagnosticDate.TabIndex = 44;
            LblDiagnosticDate.Text = "Diagnostic Date";
            // 
            // DtpDiagnosticDate
            // 
            DtpDiagnosticDate.Location = new Point(191, 14);
            DtpDiagnosticDate.Margin = new Padding(3, 2, 3, 2);
            DtpDiagnosticDate.Name = "DtpDiagnosticDate";
            DtpDiagnosticDate.Size = new Size(204, 23);
            DtpDiagnosticDate.TabIndex = 7;
            // 
            // TxtChildren
            // 
            TxtChildren.Location = new Point(192, 292);
            TxtChildren.Margin = new Padding(3, 2, 3, 2);
            TxtChildren.Name = "TxtChildren";
            TxtChildren.Size = new Size(205, 23);
            TxtChildren.TabIndex = 16;
            TxtChildren.Visible = false;
            // 
            // LblChildren
            // 
            LblChildren.AutoSize = true;
            LblChildren.Location = new Point(20, 294);
            LblChildren.Name = "LblChildren";
            LblChildren.Size = new Size(101, 15);
            LblChildren.TabIndex = 41;
            LblChildren.Text = "Children With Sex";
            LblChildren.Visible = false;
            // 
            // TxtManager
            // 
            TxtManager.Location = new Point(192, 198);
            TxtManager.Margin = new Padding(3, 2, 3, 2);
            TxtManager.Name = "TxtManager";
            TxtManager.Size = new Size(205, 23);
            TxtManager.TabIndex = 13;
            // 
            // LblLenOfPregnency
            // 
            LblLenOfPregnency.AutoSize = true;
            LblLenOfPregnency.Location = new Point(20, 262);
            LblLenOfPregnency.Name = "LblLenOfPregnency";
            LblLenOfPregnency.Size = new Size(123, 15);
            LblLenOfPregnency.TabIndex = 16;
            LblLenOfPregnency.Text = "Length of Pregenency";
            LblLenOfPregnency.Visible = false;
            // 
            // TxtIndication
            // 
            TxtIndication.Location = new Point(192, 140);
            TxtIndication.Margin = new Padding(3, 2, 3, 2);
            TxtIndication.Name = "TxtIndication";
            TxtIndication.Size = new Size(205, 23);
            TxtIndication.TabIndex = 11;
            TxtIndication.Text = "Normal";
            // 
            // LblManager
            // 
            LblManager.AutoSize = true;
            LblManager.Location = new Point(20, 198);
            LblManager.Name = "LblManager";
            LblManager.Size = new Size(54, 15);
            LblManager.TabIndex = 39;
            LblManager.Text = "Manager";
            // 
            // LblIndication
            // 
            LblIndication.AutoSize = true;
            LblIndication.Location = new Point(20, 140);
            LblIndication.Name = "LblIndication";
            LblIndication.Size = new Size(60, 15);
            LblIndication.TabIndex = 35;
            LblIndication.Text = "Indication";
            // 
            // CmbSonologist
            // 
            CmbSonologist.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSonologist.FormattingEnabled = true;
            CmbSonologist.Items.AddRange(new object[] { "Self" });
            CmbSonologist.Location = new Point(192, 321);
            CmbSonologist.Margin = new Padding(3, 2, 3, 2);
            CmbSonologist.Name = "CmbSonologist";
            CmbSonologist.Size = new Size(205, 23);
            CmbSonologist.TabIndex = 17;
            CmbSonologist.Visible = false;
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(192, 171);
            TxtAmount.Margin = new Padding(3, 2, 3, 2);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(205, 23);
            TxtAmount.TabIndex = 12;
            TxtAmount.Text = "0.00";
            // 
            // LblSonologist
            // 
            LblSonologist.AutoSize = true;
            LblSonologist.Location = new Point(20, 321);
            LblSonologist.Name = "LblSonologist";
            LblSonologist.Size = new Size(63, 15);
            LblSonologist.TabIndex = 33;
            LblSonologist.Text = "Sonologist";
            LblSonologist.Visible = false;
            // 
            // LblAmount
            // 
            LblAmount.AutoSize = true;
            LblAmount.Location = new Point(20, 171);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(51, 15);
            LblAmount.TabIndex = 37;
            LblAmount.Text = "Amount";
            // 
            // CmbLenOfPregnency
            // 
            CmbLenOfPregnency.FormattingEnabled = true;
            CmbLenOfPregnency.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            CmbLenOfPregnency.Location = new Point(192, 262);
            CmbLenOfPregnency.Margin = new Padding(3, 2, 3, 2);
            CmbLenOfPregnency.Name = "CmbLenOfPregnency";
            CmbLenOfPregnency.Size = new Size(76, 23);
            CmbLenOfPregnency.TabIndex = 15;
            CmbLenOfPregnency.Visible = false;
            // 
            // ChkIsPregnent
            // 
            ChkIsPregnent.AutoSize = true;
            ChkIsPregnent.Location = new Point(192, 235);
            ChkIsPregnent.Margin = new Padding(3, 2, 3, 2);
            ChkIsPregnent.Name = "ChkIsPregnent";
            ChkIsPregnent.Size = new Size(15, 14);
            ChkIsPregnent.TabIndex = 14;
            ChkIsPregnent.UseVisualStyleBackColor = true;
            ChkIsPregnent.CheckedChanged += ChkIsPregnent_CheckedChanged;
            // 
            // CmbDiagnosticSubCat
            // 
            CmbDiagnosticSubCat.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbDiagnosticSubCat.FormattingEnabled = true;
            CmbDiagnosticSubCat.Location = new Point(191, 76);
            CmbDiagnosticSubCat.Margin = new Padding(3, 2, 3, 2);
            CmbDiagnosticSubCat.Name = "CmbDiagnosticSubCat";
            CmbDiagnosticSubCat.Size = new Size(205, 23);
            CmbDiagnosticSubCat.TabIndex = 9;
            CmbDiagnosticSubCat.Visible = false;
            // 
            // CmbDiagnostic
            // 
            CmbDiagnostic.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbDiagnostic.FormattingEnabled = true;
            CmbDiagnostic.Items.AddRange(new object[] { "USG", "XRAY", "ECG", "PATHOALOGY" });
            CmbDiagnostic.Location = new Point(191, 44);
            CmbDiagnostic.Margin = new Padding(3, 2, 3, 2);
            CmbDiagnostic.Name = "CmbDiagnostic";
            CmbDiagnostic.Size = new Size(204, 23);
            CmbDiagnostic.TabIndex = 8;
            CmbDiagnostic.SelectedIndexChanged += CmbDiagnostic_SelectedIndexChanged;
            // 
            // CmbRefferedBy
            // 
            CmbRefferedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbRefferedBy.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbRefferedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbRefferedBy.FormattingEnabled = true;
            CmbRefferedBy.Items.AddRange(new object[] { "Self" });
            CmbRefferedBy.Location = new Point(191, 109);
            CmbRefferedBy.Margin = new Padding(3, 2, 3, 2);
            CmbRefferedBy.Name = "CmbRefferedBy";
            CmbRefferedBy.Size = new Size(205, 23);
            CmbRefferedBy.TabIndex = 10;
            // 
            // LblDiagnosticCategory
            // 
            LblDiagnosticCategory.AutoSize = true;
            LblDiagnosticCategory.Location = new Point(20, 44);
            LblDiagnosticCategory.Name = "LblDiagnosticCategory";
            LblDiagnosticCategory.Size = new Size(114, 15);
            LblDiagnosticCategory.TabIndex = 15;
            LblDiagnosticCategory.Text = "Diagnostic Category";
            // 
            // LblReferredBy
            // 
            LblReferredBy.AutoSize = true;
            LblReferredBy.Location = new Point(20, 109);
            LblReferredBy.Name = "LblReferredBy";
            LblReferredBy.Size = new Size(67, 15);
            LblReferredBy.TabIndex = 26;
            LblReferredBy.Text = "Referred By";
            // 
            // LblIsPregenent
            // 
            LblIsPregenent.AutoSize = true;
            LblIsPregenent.Location = new Point(20, 230);
            LblIsPregenent.Name = "LblIsPregenent";
            LblIsPregenent.Size = new Size(66, 15);
            LblIsPregenent.TabIndex = 24;
            LblIsPregenent.Text = "Is Pregnent";
            // 
            // LblDiagnosticSubCat
            // 
            LblDiagnosticSubCat.AutoSize = true;
            LblDiagnosticSubCat.Location = new Point(20, 76);
            LblDiagnosticSubCat.Name = "LblDiagnosticSubCat";
            LblDiagnosticSubCat.Size = new Size(78, 15);
            LblDiagnosticSubCat.TabIndex = 22;
            LblDiagnosticSubCat.Text = "Sub Category";
            LblDiagnosticSubCat.Visible = false;
            // 
            // BtnSearchByMob
            // 
            BtnSearchByMob.Location = new Point(677, 21);
            BtnSearchByMob.Margin = new Padding(3, 2, 3, 2);
            BtnSearchByMob.Name = "BtnSearchByMob";
            BtnSearchByMob.Size = new Size(89, 22);
            BtnSearchByMob.TabIndex = 34;
            BtnSearchByMob.Text = "Search";
            BtnSearchByMob.UseVisualStyleBackColor = true;
            BtnSearchByMob.Click += BtnSearchByMob_Click;
            // 
            // TxtSearchMobileNumber
            // 
            TxtSearchMobileNumber.Location = new Point(203, 21);
            TxtSearchMobileNumber.Margin = new Padding(3, 2, 3, 2);
            TxtSearchMobileNumber.Name = "TxtSearchMobileNumber";
            TxtSearchMobileNumber.Size = new Size(183, 23);
            TxtSearchMobileNumber.TabIndex = 33;
            // 
            // LabelSearchByMob
            // 
            LabelSearchByMob.AutoSize = true;
            LabelSearchByMob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelSearchByMob.Location = new Point(42, 20);
            LabelSearchByMob.Name = "LabelSearchByMob";
            LabelSearchByMob.Size = new Size(155, 15);
            LabelSearchByMob.TabIndex = 32;
            LabelSearchByMob.Text = "Search By Mobile Number:";
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(497, 482);
            BtnClear.Margin = new Padding(3, 2, 3, 2);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(175, 30);
            BtnClear.TabIndex = 35;
            BtnClear.Text = "Clear Details";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(984, 561);
            Controls.Add(BtnClear);
            Controls.Add(BtnSearchByMob);
            Controls.Add(TxtSearchMobileNumber);
            Controls.Add(LabelSearchByMob);
            Controls.Add(PnlDiagnostic);
            Controls.Add(AddDetails);
            Controls.Add(PnlPatient);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private Button BtnClear;
    }
}