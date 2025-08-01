﻿using AdcData.Models;

namespace AdcData.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        /// <summary>
        /// Gets a list of patients along with their diagnostics by the doctor's name.
        /// </summary>
        /// <param name="doctorName"></param>
        /// <returns></returns>
        IEnumerable<PatientDiagnostic> GetPatientsByDoctor(string doctorName);

        /// <summary>
        /// Gets a patient details along with their diagnostics by mobile number.
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        PatientDiagnostic? GetPatientDiagnosticByMobileBumber(long mobileNumber);


        /// <summary>
        /// Gets a patient by their mobile number.
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        Patient? GetPatientByMobileNumber(long mobileNumber);

        /// <summary>
        /// Gets a list of patients along with their diagnostics by the doctor's name, start and end date.
        /// </summary>
        /// <param name="startDate">Start Date</param>
        /// <param name="endDate">Start Date</param>
        /// <param name="doctorName"></param>
        /// <returns></returns>
        IEnumerable<PatientDiagnostic> GetPatientDiagnostic(DateTime startDate, DateTime endDate, string? doctorName);
    }
}
