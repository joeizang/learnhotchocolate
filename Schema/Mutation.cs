using System.Threading.Tasks;
using HotChocolate;
using learnhotchocolate.Data;
using learnhotchocolate.Models;

namespace learnhotchocolate.Schema
{
    public class Mutation
    {

        public async Task<Income> CreateIncome([Service] LearnHotChocolateContext db, IncomeInputModel model)
        {
            var income = new Income
            {
                IncomeDate = model.Date,
                Amount = model.Amount,
                Description = model.Description,
                IncomeCategory = new IncomeCategory
                {
                    IncomeCategoryName = model.CategoryModel.CategoryName
                },
                IncomeSource = new IncomeSource
                {
                    Name = model.SourceModel.Name,
                    PhoneNumber = model.SourceModel.PhoneNumber
                }
            };

            try
            {
                db.Incomes.Add(income);
                await db.SaveChangesAsync();
                return income;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception($"{ex.Message}");
            }
        }

        public async Task<Income> UpdateIncome([Service] LearnHotChocolateContext db, IncomeUpdateModel model)
        {

            var target = await db.Incomes.FindAsync(model.IncomeId);
            target.Amount = model.Amount;
            target.Description = model.Description;
            target.IncomeDate = model.Date;
            target.IncomeCategory.IncomeCategoryName = model.CategoryModel.CategoryName;
            target.IncomeSource.Name = model.SourceModel.Name;
            target.IncomeSource.PhoneNumber = model.SourceModel.PhoneNumber;
            try
            {
                await db.SaveChangesAsync();
                return target;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception($"{ex.Message}");
            }
        }

        public async Task DeleteIncome([Service] LearnHotChocolateContext db, IncomeDeleteModel model)
        {
            try
            {
                var entity = db.Incomes.FindAsync(model.IncomeId);
                db.Remove(entity);
                await db.SaveChangesAsync();

            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}