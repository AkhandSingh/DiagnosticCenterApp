using AdcData;
using AdcData.Interfaces;
using AdcData.Repositories;

namespace ADC
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ToolStripDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
        }

        private void ToolStripPatient_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
        }

        private void ToolStripPrintPatientReceipt_Click(object sender, EventArgs e)
        {
            Receipt receiptForm = new Receipt();
            receiptForm.Show();
        }
    }
}
