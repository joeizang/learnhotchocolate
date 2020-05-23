using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using learnhotchocolate.Data;
using learnhotchocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace learnhotchocolate.Schema
{
    public class Query
    {
        public async Task<List<Income>> Incomes([Service] LearnHotChocolateContext db)
        {
            return await db.Incomes.AsNoTracking()
                .Include(x => x.IncomeCategory)
                .Include(x => x.IncomeSource)
                .OrderBy(i => i.CreatedAt)
                .ToListAsync().ConfigureAwait(false);
        }

        public async Task<Income> GetIncomeById([Service] LearnHotChocolateContext db, string id)
        {
            return await db.Incomes.AsNoTracking()
                .Include(x => x.IncomeCategory)
                .Include(x => x.IncomeSource)
                .SingleOrDefaultAsync(t => t.Id.Equals(id))
                .ConfigureAwait(false);
        }
    }
}