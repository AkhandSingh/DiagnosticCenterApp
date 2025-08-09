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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
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
            PnlDoctor = new Panel();
            PnlDcotorList = new Panel();
            DgvDoctor = new DataGridView();
            DgvColName = new DataGridViewTextBoxColumn();
            DgvColMobileNumber = new DataGridViewTextBoxColumn();
            DgvColHospital = new DataGridViewTextBoxColumn();
            DgvColDegree = new DataGridViewTextBoxColumn();
            DgvColSpecialization = new DataGridViewTextBoxColumn();
            DgvColAddress = new DataGridViewTextBoxColumn();
            DgvColId = new DataGridViewTextBoxColumn();
            PnlDoctor.SuspendLayout();
            PnlDcotorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDoctor).BeginInit();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(10, 22);
            LblName.Name = "LblName";
            LblName.Size = new Size(78, 15);
            LblName.TabIndex = 0;
            LblName.Text = "Doctor Name";
            // 
            // LblHospital
            // 
            LblHospital.AutoSize = true;
            LblHospital.Location = new Point(10, 148);
            LblHospital.Name = "LblHospital";
            LblHospital.Size = new Size(51, 15);
            LblHospital.TabIndex = 2;
            LblHospital.Text = "Hospital";
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Location = new Point(10, 177);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(49, 15);
            LblAddress.TabIndex = 3;
            LblAddress.Text = "Address";
            // 
            // TxtDoctorName
            // 
            TxtDoctorName.Location = new Point(152, 22);
            TxtDoctorName.Margin = new Padding(3, 2, 3, 2);
            TxtDoctorName.Name = "TxtDoctorName";
            TxtDoctorName.Size = new Size(205, 23);
            TxtDoctorName.TabIndex = 1;
            // 
            // TxtHospital
            // 
            TxtHospital.Location = new Point(152, 148);
            TxtHospital.Margin = new Padding(3, 2, 3, 2);
            TxtHospital.Name = "TxtHospital";
            TxtHospital.Size = new Size(205, 23);
            TxtHospital.TabIndex = 5;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(152, 177);
            TxtAddress.Margin = new Padding(3, 2, 3, 2);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(205, 113);
            TxtAddress.TabIndex = 6;
            // 
            // BtnAddDoctor
            // 
            BtnAddDoctor.Location = new Point(215, 303);
            BtnAddDoctor.Margin = new Padding(3, 2, 3, 2);
            BtnAddDoctor.Name = "BtnAddDoctor";
            BtnAddDoctor.Size = new Size(142, 22);
            BtnAddDoctor.TabIndex = 7;
            BtnAddDoctor.Text = "Add";
            BtnAddDoctor.UseVisualStyleBackColor = true;
            BtnAddDoctor.Click += BtnAddDoctor_Click;
            // 
            // TxtMobileNum
            // 
            TxtMobileNum.Location = new Point(152, 56);
            TxtMobileNum.Margin = new Padding(3, 2, 3, 2);
            TxtMobileNum.Name = "TxtMobileNum";
            TxtMobileNum.Size = new Size(205, 23);
            TxtMobileNum.TabIndex = 2;
            // 
            // LblMobile
            // 
            LblMobile.AutoSize = true;
            LblMobile.Location = new Point(10, 56);
            LblMobile.Name = "LblMobile";
            LblMobile.Size = new Size(91, 15);
            LblMobile.TabIndex = 9;
            LblMobile.Text = "Mobile Number";
            // 
            // TxtSpecialization
            // 
            TxtSpecialization.Location = new Point(152, 120);
            TxtSpecialization.Margin = new Padding(3, 2, 3, 2);
            TxtSpecialization.Name = "TxtSpecialization";
            TxtSpecialization.Size = new Size(205, 23);
            TxtSpecialization.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 120);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 11;
            label1.Text = "Specialization";
            // 
            // TxtDegree
            // 
            TxtDegree.Location = new Point(152, 88);
            TxtDegree.Margin = new Padding(3, 2, 3, 2);
            TxtDegree.Name = "TxtDegree";
            TxtDegree.Size = new Size(205, 23);
            TxtDegree.TabIndex = 3;
            // 
            // LblDegree
            // 
            LblDegree.AutoSize = true;
            LblDegree.Location = new Point(10, 88);
            LblDegree.Name = "LblDegree";
            LblDegree.Size = new Size(44, 15);
            LblDegree.TabIndex = 13;
            LblDegree.Text = "Degree";
            // 
            // PnlDoctor
            // 
            PnlDoctor.Controls.Add(TxtDegree);
            PnlDoctor.Controls.Add(TxtDoctorName);
            PnlDoctor.Controls.Add(LblDegree);
            PnlDoctor.Controls.Add(LblName);
            PnlDoctor.Controls.Add(TxtSpecialization);
            PnlDoctor.Controls.Add(LblHospital);
            PnlDoctor.Controls.Add(label1);
            PnlDoctor.Controls.Add(LblAddress);
            PnlDoctor.Controls.Add(TxtMobileNum);
            PnlDoctor.Controls.Add(TxtHospital);
            PnlDoctor.Controls.Add(LblMobile);
            PnlDoctor.Controls.Add(TxtAddress);
            PnlDoctor.Controls.Add(BtnAddDoctor);
            PnlDoctor.Location = new Point(10, 38);
            PnlDoctor.Margin = new Padding(3, 2, 3, 2);
            PnlDoctor.Name = "PnlDoctor";
            PnlDoctor.Size = new Size(374, 370);
            PnlDoctor.TabIndex = 15;
            // 
            // PnlDcotorList
            // 
            PnlDcotorList.Controls.Add(DgvDoctor);
            PnlDcotorList.Location = new Point(390, 38);
            PnlDcotorList.Margin = new Padding(3, 2, 3, 2);
            PnlDcotorList.Name = "PnlDcotorList";
            PnlDcotorList.Size = new Size(577, 370);
            PnlDcotorList.TabIndex = 16;
            // 
            // DgvDoctor
            // 
            DgvDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDoctor.Columns.AddRange(new DataGridViewColumn[] { DgvColName, DgvColMobileNumber, DgvColHospital, DgvColDegree, DgvColSpecialization, DgvColAddress, DgvColId });
            DgvDoctor.Location = new Point(10, 22);
            DgvDoctor.Margin = new Padding(3, 2, 3, 2);
            DgvDoctor.Name = "DgvDoctor";
            DgvDoctor.RowHeadersWidth = 51;
            DgvDoctor.Size = new Size(564, 302);
            DgvDoctor.TabIndex = 0;
            // 
            // DgvColName
            // 
            DgvColName.HeaderText = "Name";
            DgvColName.MinimumWidth = 6;
            DgvColName.Name = "DgvColName";
            DgvColName.Width = 125;
            // 
            // DgvColMobileNumber
            // 
            DgvColMobileNumber.HeaderText = "Mob Number";
            DgvColMobileNumber.MinimumWidth = 6;
            DgvColMobileNumber.Name = "DgvColMobileNumber";
            DgvColMobileNumber.Width = 125;
            // 
            // DgvColHospital
            // 
            DgvColHospital.HeaderText = "Hospital";
            DgvColHospital.MinimumWidth = 6;
            DgvColHospital.Name = "DgvColHospital";
            DgvColHospital.Width = 125;
            // 
            // DgvColDegree
            // 
            DgvColDegree.HeaderText = "Degree";
            DgvColDegree.MinimumWidth = 6;
            DgvColDegree.Name = "DgvColDegree";
            DgvColDegree.Width = 125;
            // 
            // DgvColSpecialization
            // 
            DgvColSpecialization.HeaderText = "Specialization";
            DgvColSpecialization.MinimumWidth = 6;
            DgvColSpecialization.Name = "DgvColSpecialization";
            DgvColSpecialization.Width = 125;
            // 
            // DgvColAddress
            // 
            DgvColAddress.HeaderText = "Address";
            DgvColAddress.MinimumWidth = 6;
            DgvColAddress.Name = "DgvColAddress";
            DgvColAddress.Width = 125;
            // 
            // DgvColId
            // 
            DgvColId.HeaderText = "Id";
            DgvColId.MinimumWidth = 6;
            DgvColId.Name = "DgvColId";
            DgvColId.ReadOnly = true;
            DgvColId.Visible = false;
            DgvColId.Width = 125;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightCyan;
            ClientSize = new Size(984, 561);
            Controls.Add(PnlDcotorList);
            Controls.Add(PnlDoctor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoctorForm";
            Text = "Doctor";
            Load += DoctorForm_Load;
            PnlDoctor.ResumeLayout(false);
            PnlDoctor.PerformLayout();
            PnlDcotorList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDoctor).EndInit();
            ResumeLayout(false);
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
        private Panel PnlDoctor;
        private Panel PnlDcotorList;
        private DataGridView DgvDoctor;
        private DataGridViewTextBoxColumn DgvColName;
        private DataGridViewTextBoxColumn DgvColMobileNumber;
        private DataGridViewTextBoxColumn DgvColHospital;
        private DataGridViewTextBoxColumn DgvColDegree;
        private DataGridViewTextBoxColumn DgvColSpecialization;
        private DataGridViewTextBoxColumn DgvColAddress;
        private DataGridViewTextBoxColumn DgvColId;
    }
}