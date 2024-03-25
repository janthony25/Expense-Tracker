    namespace Expense_Tracker.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        // CategoryId

        public int Amount { get; set; }
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
