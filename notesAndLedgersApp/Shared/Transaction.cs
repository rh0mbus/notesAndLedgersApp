using notesAndLedgersApp.Shared.Enums;

namespace notesAndLedgersApp.Shared
{
    public class Transaction
    {
        public int Id { get; set; }
        public float Amount { get; set; } = 0;
        public TransactionType Type { get; set; } = TransactionType.Deposit;
        public string? Comment { get; set; }
    }
}
