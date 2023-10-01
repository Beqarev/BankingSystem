using System.ComponentModel.DataAnnotations;
using Core.Domain.Enum;

namespace Core.Domain.Models;

public class BankAccount
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "IBAN is required")]
    [RegularExpression(@"^[a-zA-Z]{2}[0-9]{2}[a-zA-Z0-9]{4}[0-9]{7}([a-zA-Z0-9]?){0,16}", ErrorMessage = "Invalid IBAN format")]
    public string IBAN { get; set; }
    public int Amount { get; set; }
    public Currency Currency { get; set; }
    public Client Client { get; set; }
}