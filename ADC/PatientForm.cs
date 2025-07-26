using AdcData;
using AdcData.Interfaces;
using AdcData.Models;
using AdcData.Repositories;
using System.Data;

namespace ADC
{
    public partial class PatientForm : Form
    {
        AdcDbContext _context;
        IDoctorRepository _doctorRepository;
        IPatientRepository _patientRepository;
        IDiagnosticRepository _diagnosticRepository;

        public PatientForm()
        {
            InitializeComponent();
            _context = new AdcDbContext();
            _doctorRepository = new DoctorRepository(_context);
            _patientRepository = new PatientRepository(_context);
            _diagnosticRepository = new DiagnosticRepository(_context);
            SetDoctors();
        }

        private void AddDetails_Click(object sender, EventArgs e)
        {
            try
            {
                long patientId;
                var patient =  _patientRepository.GetPatientByMobileNumber(Convert.ToInt64(TxtMobileNum.Text));
                if (patient != null)
                {
                    patientId = patient.Id;
                } 
                else
                {
                    Patient patientNew = new Patient
                    {
                        Name = TxtPatientName.Text,
                        MobileNumber = Convert.ToInt64(TxtMobileNum.Text),
                        Age = Convert.ToInt32(CmbAge.Text),
                        Sex = CmbSex.Text,
                        Address = TxtAddress.Text,
                        Gaurdian = TxtGaurdian.Text
                    };
                    _patientRepository.Add(patientNew);
                    _patientRepository.SaveChanges();

                    patientId = patientNew.Id;
                }

                int lengthOfPregnancy = 0;
                decimal amount = 0;
                int.TryParse(CmbLenOfPregnency.Text, out lengthOfPregnancy);
                decimal.TryParse(TxtAmount.Text, out amount);

                Diagnostic diagnostic = new Diagnostic
                {
                    ReferredBy = CmbRefferedBy.Text.ToString(),
                    Sonologist = CmbSonologist.Text.ToString(),
                    PatientId = patientId,
                    IsPregnent = ChkIsPregnent.Checked,
                    LengthOfPregnency = lengthOfPregnancy,
                    ChildrenWithSex = TxtChildren.Text,
                    DiagnosticCategory = CmbDiagnostic.Text,
                    DiagnosticSubCategory = CmbDiagnosticSubCat.Text,
                    DiagnosticDate = DtpDiagnosticDate.Value,
                    Indication = TxtIndication.Text,
                    Amount = amount,
                    Manager = TxtManager.Text
                };

                _diagnosticRepository.Add(diagnostic);
                _diagnosticRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding patient: {ex.Message}");
            }
            finally
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            TxtPatientName.Clear();
            TxtMobileNum.Clear();
            TxtAddress.Clear();
            CmbAge.SelectedItem = null;
            CmbSex.SelectedItem = null;
            TxtAddress.Clear();
            TxtMobileNum.Clear();
        }

        private void SetDoctors()
        {
            List<Doctor> doctors = _doctorRepository.GetAll().ToList();
            CmbRefferedBy.DisplayMember = "Text";
            CmbRefferedBy.ValueMember = "Value";
            CmbRefferedBy.DataSource = doctors.Select(d => new
            {
                Text = d.Name,
                Value = d.Id
            }).ToList();

            CmbSonologist.DataSource = doctors.Where(d=>d.Specialization.ToLower().Contains("sonologist")).Select(d => new
            {
                Text = d.Name,
                Value = d.Id
            }).ToList();

            CmbSonologist.DisplayMember = "Text";
            CmbSonologist.ValueMember = "Value";

        }
    }
}
