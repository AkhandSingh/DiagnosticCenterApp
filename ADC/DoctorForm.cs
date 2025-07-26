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
                int mobileNo;
                bool isMoNumParsed = int.TryParse(TxtMobileNum.Text, out mobileNo);
                Doctor doctor = new Doctor
                {
                    Name = TxtDoctorName.Text,
                    MobileNo = isMoNumParsed ? Convert.ToInt32(TxtMobileNum.Text) : null,
                    Degree = TxtDegree.Text,
                    Specialization = TxtMobileNum.Text,
                    Address = TxtAddress.Text,
                    Hospital = TxtHospital.Text
                };
                _doctorRepository.Add(doctor);
                _doctorRepository.SaveChanges();
                MessageBox.Show($"Doctor added successfully.");
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
    }
}
