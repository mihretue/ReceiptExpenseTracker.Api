using Microsoft.EntityFrameworkCore;
using ReceiptExpenseTracker.Api.Data;
using ReceiptExpenseTracker.Api.Models;

namespace ReceiptExpenseTracker.Api.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}
