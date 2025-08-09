using System.ComponentModel.DataAnnotations;

namespace AdcData.Models
{
    public class Diagnostic
    {
        [Key]
        public long Id { get; set; }
        public long PatientId { get; set; }
        public bool IsPregnent { get; set; }
        public int? LengthOfPregnency { get; set; }
        public string? ChildrenWithSex { get; set; }
        public string? Sonologist { get; set; }
        public string DiagnosticCategory { get; set; }
        public string? DiagnosticSubCategory { get; set; }
        public string ReferredBy { get; set; } = null!;
        public DateTime DiagnosticDate { get; set; }
        public string? Indication { get; set; }
        public Decimal Amount { get; set; }

        public string? Manager { get; set; }

    }
}