using Microsoft.AspNetCore.Mvc;
using ReceiptExpenseTracker.Api.Data;
using ReceiptExpenseTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ReceiptExpenseTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseControllers : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExpenseControllers(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Expense
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses()
        {
            return await _context.Expenses.ToListAsync();
        }
    }
}