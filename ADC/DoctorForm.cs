using AdcData;
using AdcData.Interfaces;
using AdcData.Models;
using AdcData.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADC
{
    public partial class DoctorForm : Form
    {
        AdcDbContext _context;
        IDoctorRepository _doctorRepository;
        public DoctorForm()
        {
            InitializeComponent();
            _context = new AdcDbContext();
            _doctorRepository = new DoctorRepository(_context);
        }
        private void BtnAddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(TxtDoctorName.Text))
                {
                    MessageBox.Show("Please fill doctor name.");
                    return;
                }

                long mobileNo;
                bool isMoNumParsed = long.TryParse(TxtMobileNum.Text, out mobileNo);
                Doctor doctor = new Doctor
                {
                    Name = TxtDoctorName.Text,
                    MobileNo = isMoNumParsed ? Convert.ToInt64(TxtMobileNum.Text) : null,
                    Degree = string.IsNullOrEmpty(TxtDegree.Text)? null: TxtDegree.Text,
                    Specialization = string.IsNullOrEmpty(TxtSpecialization.Text) ? null : TxtSpecialization.Text,
                    Address = string.IsNullOrEmpty(TxtAddress.Text) ? null : TxtAddress.Text,
                    Hospital = string.IsNullOrEmpty(TxtHospital.Text) ? null : TxtHospital.Text
                };
                _doctorRepository.Add(doctor);
                _doctorRepository.SaveChanges();
                MessageBox.Show($"Doctor added successfully.");
                LoadDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}");
            }
            finally
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            TxtDoctorName.Clear();
            TxtMobileNum.Clear();
            TxtAddress.Clear();
            TxtHospital.Clear();
            TxtDegree.Clear();
            TxtSpecialization.Clear();
            TxtMobileNum.Clear();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            try
            {
                // Fetch all doctors and bind to DataGridView with columns matching the Doctor model
                var doctors = _doctorRepository.GetAll()
                    .Select(d => new
                    {
                        d.Id,
                        d.Name,
                        d.MobileNo,
                        d.Degree,
                        d.Specialization,
                        d.Address,
                        d.Hospital
                    })
                    .ToList();

                DgvDoctor.Rows.Clear();
                foreach (var doc in doctors)
                {
                    DgvDoctor.Rows.Add(
                        doc.Name,
                        doc.MobileNo,
                        doc.Hospital,
                        doc.Degree,
                        doc.Specialization,
                        doc.Address,
                        doc.Id
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}");
            }
        }
    }
}
