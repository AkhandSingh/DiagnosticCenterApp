using System.ComponentModel.DataAnnotations;

namespace AdcData.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public int? MobileNo { get; set; }
        public string? Degree { get; set; }
        public string? Specialization { get; set; }
        public string? Address { get; set; }
        public string? Hospital { get; set; }
       
    }
}