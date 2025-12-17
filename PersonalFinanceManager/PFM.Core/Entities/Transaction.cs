using PFM.Core.Enums;

namespace PFM.Core.Entities
{
    public class Transaction : BaseEntity
    {
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public string Currency { get; set; } = "GEL";

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public bool IsRecurring { get; set; }
        public RecurringFrequency RecurringFrequency { get; set; }
        public DateTime? RecurringEndDate { get; set; }
    }
}