namespace ADC
{
    partial class DoctorForm
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
            LblName = new Label();
            LblHospital = new Label();
            LblAddress = new Label();
            TxtDoctorName = new TextBox();
            TxtHospital = new TextBox();
            TxtAddress = new TextBox();
            BtnAddDoctor = new Button();
            TxtMobileNum = new TextBox();
            LblMobile = new Label();
            TxtSpecialization = new TextBox();
            label1 = new Label();
            TxtDegree = new TextBox();
            LblDegree = new Label();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(39, 54);
            LblName.Name = "LblName";
            LblName.Size = new Size(99, 20);
            LblName.TabIndex = 0;
            LblName.Text = "Doctor Name";
            // 
            // LblHospital
            // 
            LblHospital.AutoSize = true;
            LblHospital.Location = new Point(39, 221);
            LblHospital.Name = "LblHospital";
            LblHospital.Size = new Size(65, 20);
            LblHospital.TabIndex = 2;
            LblHospital.Text = "Hospital";
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Location = new Point(39, 260);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(62, 20);
            LblAddress.TabIndex = 3;
            LblAddress.Text = "Address";
            // 
            // TxtDoctorName
            // 
            TxtDoctorName.Location = new Point(201, 54);
            TxtDoctorName.Name = "TxtDoctorName";
            TxtDoctorName.Size = new Size(234, 27);
            TxtDoctorName.TabIndex = 4;
            // 
            // TxtHospital
            // 
            TxtHospital.Location = new Point(201, 221);
            TxtHospital.Name = "TxtHospital";
            TxtHospital.Size = new Size(234, 27);
            TxtHospital.TabIndex = 6;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(201, 260);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(234, 96);
            TxtAddress.TabIndex = 7;
            // 
            // BtnAddDoctor
            // 
            BtnAddDoctor.Location = new Point(273, 391);
            BtnAddDoctor.Name = "BtnAddDoctor";
            BtnAddDoctor.Size = new Size(162, 29);
            BtnAddDoctor.TabIndex = 8;
            BtnAddDoctor.Text = "Add";
            BtnAddDoctor.UseVisualStyleBackColor = true;
            BtnAddDoctor.Click += BtnAddDoctor_Click;
            // 
            // TxtMobileNum
            // 
            TxtMobileNum.Location = new Point(201, 98);
            TxtMobileNum.Name = "TxtMobileNum";
            TxtMobileNum.Size = new Size(234, 27);
            TxtMobileNum.TabIndex = 10;
            // 
            // LblMobile
            // 
            LblMobile.AutoSize = true;
            LblMobile.Location = new Point(39, 98);
            LblMobile.Name = "LblMobile";
            LblMobile.Size = new Size(114, 20);
            LblMobile.TabIndex = 9;
            LblMobile.Text = "Mobile Number";
            // 
            // TxtSpecialization
            // 
            TxtSpecialization.Location = new Point(201, 184);
            TxtSpecialization.Name = "TxtSpecialization";
            TxtSpecialization.Size = new Size(234, 27);
            TxtSpecialization.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 184);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 11;
            label1.Text = "Specialization";
            // 
            // TxtDegree
            // 
            TxtDegree.Location = new Point(201, 142);
            TxtDegree.Name = "TxtDegree";
            TxtDegree.Size = new Size(234, 27);
            TxtDegree.TabIndex = 14;
            // 
            // LblDegree
            // 
            LblDegree.AutoSize = true;
            LblDegree.Location = new Point(39, 142);
            LblDegree.Name = "LblDegree";
            LblDegree.Size = new Size(58, 20);
            LblDegree.TabIndex = 13;
            LblDegree.Text = "Degree";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1482, 653);
            Controls.Add(TxtDegree);
            Controls.Add(LblDegree);
            Controls.Add(TxtSpecialization);
            Controls.Add(label1);
            Controls.Add(TxtMobileNum);
            Controls.Add(LblMobile);
            Controls.Add(BtnAddDoctor);
            Controls.Add(TxtAddress);
            Controls.Add(TxtHospital);
            Controls.Add(TxtDoctorName);
            Controls.Add(LblAddress);
            Controls.Add(LblHospital);
            Controls.Add(LblName);
            Name = "DoctorForm";
            Text = "Doctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private Label LblHospital;
        private Label LblAddress;
        private TextBox TxtDoctorName;
        private TextBox TxtHospital;
        private TextBox TxtAddress;
        private Button BtnAddDoctor;
        private TextBox TxtMobileNum;
        private Label LblMobile;
        private TextBox TxtSpecialization;
        private Label label1;
        private TextBox TxtDegree;
        private Label LblDegree;
    }
}