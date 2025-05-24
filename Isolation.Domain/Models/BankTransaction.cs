using Isolation.Domain.Enums;

namespace Isolation.Domain.Models;

public class BankTransaction
{
    public Guid Id { get; private set; }
    public Guid BankAccountId { get; private set; }
    public decimal Amount { get; private set; }
    public TransactionType Type { get; private set; }
    public DateTime Timestamp { get; private set; }

    public BankTransaction(Guid accountId, decimal amount, TransactionType type)
    {
        Id = Guid.NewGuid();
        BankAccountId = accountId;
        Amount = amount;
        Type = type;
        Timestamp = DateTime.UtcNow;
    }
}