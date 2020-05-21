using System;
using System.ComponentModel.DataAnnotations;

namespace learnhotchocolate.Models
{
    public class IncomeSource : BaseEntity
    {
        public IncomeSource() : base()
        { }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Name { get; set; } = "";

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
    }
}