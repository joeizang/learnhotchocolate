using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace learnhotchocolate.Models
{
    public class IncomeCategory : BaseEntity
    {
        public IncomeCategory() : base()
        {
            Incomes = new List<Income>();
        }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Text)]
        public string IncomeCategoryName { get; set; } = "";

        public List<Income> Incomes { get; set; }
    }
}