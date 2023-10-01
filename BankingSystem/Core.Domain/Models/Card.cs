using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Models;

public class Card
{
    public Guid Id { get; set; }
    public string CardNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime ActivationStartDate { get; set; }
    public DateTime ActivationEndDate { get; set; }
    
    [Required(ErrorMessage = "CCV code is required")]
    [RegularExpression(@"^\d{3}$", ErrorMessage = "Invalid CCV code")]
    public string CCV { get; set; }
    
    [Required(ErrorMessage = "PIN code is required")]
    [RegularExpression(@"^\d{4}$", ErrorMessage = "Invalid PIN code")]
    public string PIN { get; set; }

    public BankAccount BankAccount { get; set; }
}