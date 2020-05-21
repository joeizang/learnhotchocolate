using learnhotchocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace learnhotchocolate.Data
{
    public class LearnHotChocolateContext : DbContext
    {

        public LearnHotChocolateContext(DbContextOptions<LearnHotChocolateContext> options)
        : base(options) { }

        public DbSet<Income> Incomes { get; set; } = null!;
        public DbSet<IncomeSource> IncomeSources { get; set; } = null!;
        public DbSet<IncomeCategory> IncomeCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Income>()
                .HasOne(i => i.IncomeSource)
                .WithMany()
                .IsRequired()
                .HasForeignKey(x => x.IncomeSourceId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Income>()
                .HasKey(key => key.Id);
            builder.Entity<Income>()
                .HasOne(i => i.IncomeCategory)
                .WithMany()
                .IsRequired()
                .HasForeignKey(x => x.IncomeCategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}