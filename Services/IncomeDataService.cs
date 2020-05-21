using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using learnhotchocolate.Data;
using learnhotchocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace learnhotchocolate.Services
{
    public class IncomeDataService
    {
        public async Task<List<Income>> GetAllIncomes([Service] LearnHotChocolateContext db)
        {
            return await db.Incomes.AsNoTracking()
                .OrderBy(i => i.CreatedAt)
                .ToListAsync().ConfigureAwait(false);
        }

        public async Task<Income> GetIncomeById([Service] LearnHotChocolateContext db, string id)
        {
            return await db.Incomes.AsNoTracking()
                .SingleOrDefaultAsync(t => t.Id.Equals(id))
                .ConfigureAwait(false);
        }

    }
}