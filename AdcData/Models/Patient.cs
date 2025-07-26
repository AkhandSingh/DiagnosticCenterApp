using System.ComponentModel.DataAnnotations;

namespace AdcData.Models
{
    public class Patient
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public long MobileNumber { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; } = null!;
        public string Gaurdian { get; set; } = null!;
        public string? Address { get; set; }
       
    }
}