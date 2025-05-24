using Isolation.Domain.Enums;

namespace Isolation.Domain.Models;

public class BankAccount
{
    public Guid Id { get; private set; }
    public string AccountNumber { get; private set; }
    public string OwnerName { get; private set; }
    public decimal Balance { get; private set; }

    private List<BankTransaction> _transactions = new();
    public IReadOnlyList<BankTransaction> Transactions => _transactions;

    public BankAccount(Guid id, string accountNumber, string ownerName, decimal initialBalance)
    {
        Id = id;
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Deposit amount must be positive.");
        Balance += amount;
        _transactions.Add(new BankTransaction(Id, amount, TransactionType.Deposit));
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Withdraw amount must be positive.");
        if (amount > Balance) throw new InvalidOperationException("Insufficient funds.");
        Balance -= amount;
        _transactions.Add(new BankTransaction(Id, -amount, TransactionType.Withdrawal));
    }
}