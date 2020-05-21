using System;

namespace learnhotchocolate.Schema
{
    public class IncomeUpdateModel
    {
        public string IncomeId { get; set; } = null!;
        public DateTimeOffset Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = null!;
        public IncomeSourceInputModel SourceModel { get; set; } = null!;
        public IncomeCategoryInputModel CategoryModel { get; set; } = null!;
    }
}