using System;

namespace learnhotchocolate.Models
{
    public class Income : BaseEntity
    {
        public Income() : base()
        { }
        public DateTimeOffset IncomeDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";
        public IncomeSource IncomeSource { get; set; } = null!;
        public string IncomeSourceId { get; set; } = "";
        public IncomeCategory IncomeCategory { get; set; } = null!;
        public string IncomeCategoryId { get; set; } = "";
    }
}