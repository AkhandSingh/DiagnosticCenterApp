using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdcData.Models
{
    public class PatientDiagnostic
    {
        public Patient Patient { get; set; }    
        public Diagnostic Diagnostic { get; set; }
    }
}
