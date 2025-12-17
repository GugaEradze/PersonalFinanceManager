using PFM.Core.Enums;
using System.Transactions;

namespace PFM.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Color { get; set; } = "#808080";
        public TransactionType Type { get; set; }
        public decimal? BudgetLimit { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}