using System;

namespace learnhotchocolate.Schema
{
    public class IncomeInputModel
    {
        public DateTimeOffset Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";
        public IncomeSourceInputModel SourceModel { get; set; } = new IncomeSourceInputModel();
        public IncomeCategoryInputModel CategoryModel { get; set; } = new IncomeCategoryInputModel();
    }
}