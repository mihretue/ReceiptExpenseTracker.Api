namespace ReceiptExpenseTracker.Api.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Category { get; set; }
        public string ReceiptImageUrl { get; set; }
        public string Notes { get; set; }

        public Expense()
        {
            // Default constructor
        }
    }
}