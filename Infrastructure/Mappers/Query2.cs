using Infrastructure.Enums;

namespace Infrastructure.Mappers
{
    public class Query2
    {
        public string FullName { get; set; } = null!;
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; } = null!;
    }
}