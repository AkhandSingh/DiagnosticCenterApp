using AdcData.Interfaces;
using AdcData.Models;
using Microsoft.EntityFrameworkCore;

namespace AdcData.Repositories
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(AdcDbContext context) : base(context)
        {
        }

        public IEnumerable<PatientDiagnostic> GetPatientsByDoctor(string doctorName)
        {
            var patientDiagnostic = _context.Patients.AsNoTracking()
                .Join(_context.Diagnoses.AsNoTracking(),
                    patient => patient.Id,
                    diagnostic => diagnostic.PatientId,
                    (patient, diagnostic) => new { Patient = patient, Diagnostic = diagnostic })
                .Where(p => p.Diagnostic.ReferredBy == doctorName)
                .ToList();

            return patientDiagnostic.Select(pd => new PatientDiagnostic { Patient = pd.Patient, Diagnostic = pd.Diagnostic });
        }

        public PatientDiagnostic? GetPatientDiagnosticByMobileBumber(long mobileNumber)
        {
            var patientDiagnostic = _context.Patients.AsNoTracking()
                .Join(_context.Diagnoses.AsNoTracking(),
                    patient => patient.Id,
                    diagnostic => diagnostic.PatientId,
                    (patient, diagnostic) => new { Patient = patient, Diagnostic = diagnostic })
                .Where(p => p.Patient.MobileNumber == mobileNumber)
                .OrderByDescending(p => p.Diagnostic.Id)
                .FirstOrDefault();

            return patientDiagnostic != null
                ? new PatientDiagnostic { Patient = patientDiagnostic.Patient, Diagnostic = patientDiagnostic.Diagnostic }
                : null;
        }

        public Patient? GetPatientByMobileNumber(long mobileNumber)
        {
          return  _context.Patients
                .AsNoTracking()
                .FirstOrDefault(p => p.MobileNumber == mobileNumber);
        }
    }
}
