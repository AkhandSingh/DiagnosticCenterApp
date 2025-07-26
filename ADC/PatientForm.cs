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
                long mobileNumber;
                long.TryParse(TxtMobileNum.Text, out mobileNumber);
                if (mobileNumber <= 0 || TxtMobileNum.Text.Length < 10)
                {
                    MessageBox.Show("Please enter a valid mobile number.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtPatientName.Text) || string.IsNullOrWhiteSpace(CmbAge.Text) ||
                    string.IsNullOrWhiteSpace(CmbSex.Text) || string.IsNullOrWhiteSpace(TxtAddress.Text) ||
                    string.IsNullOrWhiteSpace(TxtGaurdian.Text) || string.IsNullOrWhiteSpace(CmbDiagnostic.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                long patientId;
                var patient = _patientRepository.GetPatientByMobileNumber(mobileNumber);
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

            CmbSonologist.DataSource = doctors.Where(d => !string.IsNullOrWhiteSpace(d.Specialization) && d.Specialization.ToLower().Contains("sonologist")).Select(d => new
            {
                Text = d.Name,
                Value = d.Id
            }).ToList();

            CmbSonologist.DisplayMember = "Text";
            CmbSonologist.ValueMember = "Value";

        }

        private void BtnSearchByMob_Click(object sender, EventArgs e)
        {
            try
            {
                long mobileNumber;
                long.TryParse(TxtSearchMobileNumber.Text, out mobileNumber);

                if (mobileNumber > 0)
                {
                    var patient = _patientRepository.GetPatientByMobileNumber(mobileNumber);
                    if (patient != null)
                    {
                        TxtPatientName.Text = patient.Name;
                        CmbAge.Text = patient.Age.ToString();
                        CmbSex.Text = patient.Sex;
                        TxtAddress.Text = patient.Address;
                        TxtGaurdian.Text = patient.Gaurdian;
                        TxtMobileNum.Text = patient.MobileNumber.ToString();
                    }
                }
                else
                {
                    MessageBox.Show($"Please enter the correct mobile number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching patient details: {ex.Message}");
            }
        }

        private void CmbDiagnostic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDiagnostic.SelectedItem != null)
            {
                string selectedDiagnostic = CmbDiagnostic.SelectedItem.ToString();
                if (selectedDiagnostic == "USG")
                {
                    var subCategories = new List<string>
                    {
                        "WHOLE ABDOMEN",
                        "FWB",
                        "COLOR DOPPLER"
                    };
                    CmbDiagnosticSubCat.Visible = true;
                    CmbDiagnosticSubCat.DisplayMember = "Text";
                    CmbDiagnosticSubCat.ValueMember = "Value";
                    CmbDiagnosticSubCat.DataSource = subCategories.Select(subCategory => new
                    {
                        Text = subCategory,
                        Value = subCategory
                    }).ToList();
                }
                else
                {
                    CmbDiagnosticSubCat.Visible = false;
                    CmbDiagnosticSubCat.DataSource = null;
                }
            }
            else
            {
                CmbDiagnosticSubCat.Visible = false;
                CmbDiagnosticSubCat.DataSource = null;
            }
        }
    }
}
