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
                    PatientId = patientId,
                    DiagnosticCategory = CmbDiagnostic.Text,
                    DiagnosticSubCategory = string.IsNullOrWhiteSpace(CmbDiagnosticSubCat.Text) ? null : CmbDiagnosticSubCat.Text,
                    DiagnosticDate = DtpDiagnosticDate.Value,
                    Indication = TxtIndication.Text,
                    Amount = amount,
                    Manager = string.IsNullOrWhiteSpace(TxtManager.Text) ? null : TxtManager.Text,
                    IsPregnent = ChkIsPregnent.Checked,
                    LengthOfPregnency = string.IsNullOrWhiteSpace(CmbLenOfPregnency.Text) ? null : lengthOfPregnancy,
                    ChildrenWithSex = string.IsNullOrWhiteSpace(TxtChildren.Text) ? null: TxtChildren.Text,
                    Sonologist = (!ChkIsPregnent.Checked || string.IsNullOrWhiteSpace(CmbSonologist.Text)) ? null : CmbSonologist.Text.ToString(),
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
            TxtGaurdian.Clear();
            TxtPatientName.Clear();
            TxtMobileNum.Clear();
            TxtAddress.Clear();
            CmbAge.SelectedItem = null;
            CmbSex.SelectedItem = null;
            TxtAddress.Clear();
            TxtMobileNum.Clear();

            //Clear diagnostic fields
            DtpDiagnosticDate.Value = DateTime.Now;
            CmbDiagnostic.SelectedItem = null;
            CmbDiagnosticSubCat.Visible = false;
            CmbDiagnosticSubCat.SelectedItem = null;
            CmbDiagnosticSubCat.DataSource = null;
            CmbRefferedBy.SelectedIndex = 0;
            TxtIndication.Text = "Normal";
            TxtAmount.Text = "0.00";
            TxtManager.Clear();
            ChkIsPregnent.Checked = false;

            LblLenOfPregnency.Visible = false;
            CmbLenOfPregnency.Visible = false;
            LblChildren.Visible = false;
            TxtChildren.Visible = false;
            LblSonologist.Visible = false;
            CmbSonologist.Visible = false;
            CmbSonologist.SelectedIndex = 0;
            CmbLenOfPregnency.SelectedItem = null;
            TxtChildren.Clear();
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
               
                if (string.IsNullOrWhiteSpace(TxtSearchMobileNumber.Text) || TxtSearchMobileNumber.Text.Length < 10)
                {
                    MessageBox.Show("Please enter a valid mobile number to search.");
                    return;
                }

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
                    else
                    {
                        MessageBox.Show("No patient found with the provided mobile number. Please add the patient details");
                        ClearFields();
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

        private void ChkIsPregnent_CheckedChanged(object sender, EventArgs e)
        {
            LblLenOfPregnency.Visible = ChkIsPregnent.Checked;
            CmbLenOfPregnency.Visible = ChkIsPregnent.Checked;
            LblChildren.Visible = ChkIsPregnent.Checked;
            TxtChildren.Visible = ChkIsPregnent.Checked;
            LblSonologist.Visible = ChkIsPregnent.Checked;
            CmbSonologist.Visible = ChkIsPregnent.Checked;
        }
    }
}
