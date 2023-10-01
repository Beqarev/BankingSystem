namespace Core.Domain.Models;

public class Transaction
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public DateTime Timestamp { get; set; }
    public BankAccount recipient { get; set; }
    public BankAccount Sender { get; set; }
}